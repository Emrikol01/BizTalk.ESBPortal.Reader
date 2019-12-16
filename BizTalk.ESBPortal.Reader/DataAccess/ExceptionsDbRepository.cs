using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BizTalk.ESBPortal.Reader.DataAccess
{
    public class ExceptionsDbRepository
    {
        public ExceptionsDbRepository()
        {

        }

        public vwFaultMessageInfo GetFullFaultMsgInfo(Guid messageId)
        {
            EsbExceptionsDb db = new EsbExceptionsDb();

            vwFaultMessageInfo vwF = new vwFaultMessageInfo();

            //var query = from msg in db.Message
            //            join md in db.MessageData on msg.MessageID equals md.MessageID
            //            join f in db.Fault on msg.FaultID equals f.FaultID
            //            where msg.MessageID == messageId
            //            select  { vwF.ActivityID = msg.ActivityID, vwF.Application = msg.Application; }

            var result = db.Message
                .Join(db.MessageData
                , msg => msg.MessageID
                , md => md.MessageID
                , (msg, md) => new
                {
                    MessageId = msg.MessageID,
                    MessageData = md.MessageData1
                });

            var o = result.FirstOrDefault(x => x.MessageId == messageId);

            vwF.MessageID = o.MessageId;
            vwF.MessageData = o.MessageData;

            return vwF;
        }


    }
}