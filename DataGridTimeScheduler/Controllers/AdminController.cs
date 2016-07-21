using DataGridTimeScheduler.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DataGridTimeScheduler.Controllers
{
    public class AdminController : Controller
    {
        //
        // GET: /Admin/

        public ActionResult Home(int adminId)
        {
            return View();
        }

        public ActionResult CreateEmployee()
        {
            return View();
        }

        [HttpGet]
        public ActionResult DeleteEmployee(int id)
        {
            return View();
        }

        [HttpPost]
        public ActionResult DeleteEmployee(Employee employee)
        {
            return View();
        }

        [HttpGet]
        public ActionResult ResetPassword(int employeeId)
        {
            return View();
        }

        [HttpPost]
        public ActionResult ResetPassword(Employee employee)
        {
            return View();
        }


        public ActionResult EmployeeList(int departmentId)
        {
            return View();
        }

        [HttpGet]
        public ActionResult CreateDepartment()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateDepartment(Department department)
        {
            return View();
        }

        [HttpGet]
        public ActionResult EditDepartment(int departmentId)
        {
            return View();
        }

        [HttpPost]
        public ActionResult EditDepartment(Department department)
        {
            return View();
        }

        [HttpGet]
        public ActionResult DeleteDepartment(int departmentId)
        {
            return View();
        }

        [HttpPost]
        public ActionResult DeleteDepartment(Department department)
        {
            return View();
        }

        [HttpGet]
        public ActionResult SetScheduleType()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SetScheduleType(TimeScheduleType timescheduleType)
        {
            return View();
        }

        [HttpGet]
        public ActionResult CreateAdmin()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateAdmin(Employee employee)
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
