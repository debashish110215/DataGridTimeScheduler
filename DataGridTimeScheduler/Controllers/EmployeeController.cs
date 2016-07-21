using DataGridTimeScheduler.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DataGridTimeScheduler.Controllers
{
    public class EmployeeController : Controller
    {
        //
        // GET: /Employee/

        public ActionResult Home(int employeeId)
        {
            return View();
        }

        public ActionResult ChangePassword(int employeeId)
        {
            return View();
        }

        [HttpPost]
        public ActionResult StartSchedule(TimeSpan time)
        {

            return RedirectToAction("StartSlot", new { time = time});
        }

        [HttpPost]
        public ActionResult StartSlot(TimeSpan time)
        {

            return View();
        }

        [HttpPost]
        public ActionResult EndSlot(TimeSpan time)
        {
            return View();
        }

        [HttpPost]
        public ActionResult EndSchedule(TimeSpan time)
        {
            return RedirectToAction("EndSlot", new { time = time });
        }

        [HttpPost]
        public ActionResult Records(int month)
        {
            return View();
        }

        [HttpPost]
        public ActionResult Records(DateTime date)
        {
            return View();
        }

        [HttpGet]
        public ActionResult SendMessage()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SendMessage(Message message)
        {
            return View();
        }

        public ActionResult LoadMessage(int messageId)
        {
            return View();
        }

    }
}
