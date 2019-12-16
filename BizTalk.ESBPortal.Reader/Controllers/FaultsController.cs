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
    public class FaultsController : Controller
    {
        private EsbExceptionsDb db = new EsbExceptionsDb();

        // GET: Faults
        public ActionResult Index()
        {
            return View(db.Fault.OrderByDescending(x => x.InsertedDate).ToList());
        }

        // GET: Faults/Details/5
        public ActionResult Details(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Fault fault = db.Fault.Find(id);
            if (fault == null)
            {
                return HttpNotFound();
            }
            return View(fault);
        }

        // GET: Faults/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Faults/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "FaultID,NativeMessageID,ActivityID,Application,Description,ErrorType,FailureCategory,FaultCode,FaultDescription,FaultSeverity,Scope,ServiceInstanceID,ServiceName,FaultGenerator,MachineName,DateTime,ExceptionMessage,ExceptionType,ExceptionSource,ExceptionTargetSite,ExceptionStackTrace,InnerExceptionMessage,InsertMessagesFlag,InsertedDate")] Fault fault)
        {
            if (ModelState.IsValid)
            {
                fault.FaultID = Guid.NewGuid();
                db.Fault.Add(fault);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(fault);
        }

        // GET: Faults/Edit/5
        public ActionResult Edit(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Fault fault = db.Fault.Find(id);
            if (fault == null)
            {
                return HttpNotFound();
            }
            return View(fault);
        }

        // POST: Faults/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "FaultID,NativeMessageID,ActivityID,Application,Description,ErrorType,FailureCategory,FaultCode,FaultDescription,FaultSeverity,Scope,ServiceInstanceID,ServiceName,FaultGenerator,MachineName,DateTime,ExceptionMessage,ExceptionType,ExceptionSource,ExceptionTargetSite,ExceptionStackTrace,InnerExceptionMessage,InsertMessagesFlag,InsertedDate")] Fault fault)
        {
            if (ModelState.IsValid)
            {
                db.Entry(fault).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(fault);
        }

        // GET: Faults/Delete/5
        public ActionResult Delete(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Fault fault = db.Fault.Find(id);
            if (fault == null)
            {
                return HttpNotFound();
            }
            return View(fault);
        }

        // POST: Faults/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(Guid id)
        {
            Fault fault = db.Fault.Find(id);
            db.Fault.Remove(fault);
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
