using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCDBFirstAutoMapper.Business.ModelEntity;
using MVCDBFirstAutoMapper.Business.Interface;
namespace MVCDBFirstAutoMapper.Web.Controllers
{
    public class ContactController : Controller
    {
        IContactRepository _IContactService = null;
        // GET: Contact

        public ContactController(IContactRepository Contact)
        {
            _IContactService = Contact;
        }
        public ActionResult Index()
        {
            return View(_IContactService.GetContacts());
        }

        // GET: Contact/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Contact/Create
        [HttpPost]
        //public ActionResult Create(FormCollection collection)
        public ActionResult Create(ContactDTO Contact)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    // TODO: Add insert logic here
                    _IContactService.CreateContact(Contact);
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Contact/Edit/5
        public ActionResult Edit(int id)
        {
            return View(_IContactService.GetContactbyId(id));
        }

        // POST: Contact/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, ContactDTO Contact)
        {
            try
            {
                // TODO: Add update logic here
                if (ModelState.IsValid)
                {
                    _IContactService.UpdateContact(Contact);
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Contact/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Contact/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, ContactDTO Contact)
        {
            try
            {
                // TODO: Add delete logic here
                if (ModelState.IsValid)
                {
                    _IContactService.DeleteContact(Contact);
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
