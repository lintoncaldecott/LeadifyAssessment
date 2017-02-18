﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using LeadifyAssessment.DataLayer.Models;

namespace LeadifyAssessment.Controllers
{
    public class ContactController : Controller
    {
        private LeadifyAssessmentContext db = new LeadifyAssessmentContext();

        // GET: Contact
        public ActionResult Index()
        {

            return View(db.ContactModels.ToList());
        }

        // GET: Contact/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ContactModel contactModel = db.ContactModels.Find(id);
            if (contactModel == null)
            {
                return HttpNotFound();
            }
            return View(contactModel);
        }

        // GET: Contact/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Contact/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ContactId,FirstName,LastName,CellPhone,Email")] ContactModel contactModel)
        {
            if (ModelState.IsValid)
            {
                db.ContactModels.Add(contactModel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(contactModel);
        }

        // GET: Contact/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ContactModel contactModel = db.ContactModels.Find(id);
            if (contactModel == null)
            {
                return HttpNotFound();
            }
            return View(contactModel);
        }

        // POST: Contact/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ContactId,FirstName,LastName,CellPhone,Email")] ContactModel contactModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(contactModel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(contactModel);
        }

        // GET: Contact/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ContactModel contactModel = db.ContactModels.Find(id);
            if (contactModel == null)
            {
                return HttpNotFound();
            }
            return View(contactModel);
        }

        // POST: Contact/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ContactModel contactModel = db.ContactModels.Find(id);
            db.ContactModels.Remove(contactModel);
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
