using DataGridTimeScheduler.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DataGridTimeScheduler.Controllers
{
    public class DBStatistics
    {
        public IEnumerable<Department> GetDepartmentList()
        {
            return null;
        }

        public Employee GetEmployeeInfo(int employeeId)
        {
            return null;
        }

        public IEnumerable<Employee> GetEmployeeList(int departmentId)
        {
            return null;
        }

        public IEnumerable<Employee> GetEmployeeTodaySchedule(int employeeId)
        {
            return null;
        }

        public IEnumerable<Department> GetTodaysSchedule(int departmentId)
        {
            //DateTime today = null;
            return null;
        }

        public IEnumerable<Employee> GetEmployeeMonthSchedule(int employeeId)
        {
            return null;
        }

        public Employee SearchEmployeeByName(string employeeName)
        {
            return null;
        }

        

    }
}