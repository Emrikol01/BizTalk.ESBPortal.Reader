using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using BizTalk.ESBPortal.Reader;

namespace BizTalk.ESBPortal.Reader.Controllers
{
    public class vwFaultMessageInfoesController : Controller
    {
        private EsbExceptionsDb db = new EsbExceptionsDb();

        // GET: vwFaultMessageInfoes
        public ActionResult Index()
        {
            //ExceptionsDbRepository repo = new ExceptionsDbRepository();
            //Guid param = new Guid("0E391B37-6A8F-4B0A-AD16-00006CBF6B20");
            //vwFaultMessageInfo result = repo.GetFullFaultMsgInfo(param);

            return View(db.vwFaultMessageInfo.OrderByDescending(x => x.FaultInsertDate).ToList().Take(100));
        }

        // GET: vwFaultMessageInfoes/Details/5
        public ActionResult Details(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            vwFaultMessageInfo vwFaultMessageInfo = db.vwFaultMessageInfo.FirstOrDefault(x => x.MessageID == id);

            if (vwFaultMessageInfo == null)
            {
                return HttpNotFound();
            }
            return View(vwFaultMessageInfo);
        }

        // GET: vwFaultMessageInfoes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: vwFaultMessageInfoes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MessageID,FaultID,ContentType,MessageName,ResubmitAttempted,ResubmitSuccessful,Application,ErrorType,FailureCategory,FaultCode,Scope,ServiceInstanceID,ServiceName,ExceptionMessage,ExceptionType,ExceptionSource,ExceptionTargetSite,ExceptionStackTrace,InnerExceptionMessage,FaultInsertDate,MessageData,InterchangeID,RoutingUrl,MsgInsertDate,ActivityID,NativeMessageID,Description,FaultDescription,FaultSeverity,FaultGenerator,MachineName,DateTime,InsertMessagesFlag")] vwFaultMessageInfo vwFaultMessageInfo)
        {
            if (ModelState.IsValid)
            {
                vwFaultMessageInfo.MessageID = Guid.NewGuid();
                db.vwFaultMessageInfo.Add(vwFaultMessageInfo);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(vwFaultMessageInfo);
        }

        // GET: vwFaultMessageInfoes/Edit/5
        public ActionResult Edit(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            vwFaultMessageInfo vwFaultMessageInfo = db.vwFaultMessageInfo.Find(id);
            if (vwFaultMessageInfo == null)
            {
                return HttpNotFound();
            }
            return View(vwFaultMessageInfo);
        }

        // POST: vwFaultMessageInfoes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MessageID,FaultID,ContentType,MessageName,ResubmitAttempted,ResubmitSuccessful,Application,ErrorType,FailureCategory,FaultCode,Scope,ServiceInstanceID,ServiceName,ExceptionMessage,ExceptionType,ExceptionSource,ExceptionTargetSite,ExceptionStackTrace,InnerExceptionMessage,FaultInsertDate,MessageData,InterchangeID,RoutingUrl,MsgInsertDate,ActivityID,NativeMessageID,Description,FaultDescription,FaultSeverity,FaultGenerator,MachineName,DateTime,InsertMessagesFlag")] vwFaultMessageInfo vwFaultMessageInfo)
        {
            if (ModelState.IsValid)
            {
                db.Entry(vwFaultMessageInfo).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(vwFaultMessageInfo);
        }

        // GET: vwFaultMessageInfoes/Delete/5
        public ActionResult Delete(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            vwFaultMessageInfo vwFaultMessageInfo = db.vwFaultMessageInfo.Find(id);
            if (vwFaultMessageInfo == null)
            {
                return HttpNotFound();
            }
            return View(vwFaultMessageInfo);
        }

        // POST: vwFaultMessageInfoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(Guid id)
        {
            vwFaultMessageInfo vwFaultMessageInfo = db.vwFaultMessageInfo.Find(id);
            db.vwFaultMessageInfo.Remove(vwFaultMessageInfo);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
