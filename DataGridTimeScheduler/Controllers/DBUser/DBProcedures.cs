using DataGridTimeScheduler.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DataGridTimeScheduler.Controllers.DBUser
{
    public class DBProcedures
    {
        public void CreateScheduleType(TimeScheduleType timescheduletype)
        {

        }

        public void CreateDepartment(Department department)
        {

        }

        public void CreateEmployee(Employee employee)
        {

        }

        public void CreateAdmin(Employee employee)
        {

        }

        public void SendMesage(Message message)
        {

        }

        public IEnumerable<Message> GetAllMessageToMe(int myId, string orderBy)
        {
            return null;
        }

        public Employee UpdateEmployeeInfo(Employee employee)
        {
            return null;
        }

        public void UpdatePassword(int employeeId , string newPassword)
        {
           
        }

        public TimeScheduleType UpdateTimeSchedule(TimeScheduleType timeschedule)
        {
            return null;
        }

        public Department UpdateDepartment(Department department)
        {
            return null;
        }

        public void DeleteEmployee(Employee employee)
        {
            
        }

        public void DeleteDepartment(Department department)
        {
           
        }

        public void DeleteMessage(Message message)
        {

        }

        public void DeleteAdmin(Employee employee)
        {

        }

        public void StartSchedule(int EmployeeId)
        {
            //1. insert startTime 2. insert startSlot
        }

        public void StartSlot(int EmployeeId)
        {
            //Dont insert Computed field - Duration
            //1. update status: not changed 2. insert status- "Break"

        }


        public void EndSlot(int EmployeeId)
        {
            //Dont insert Computed field - Duration
            //1. update status: not changed 2. insert status- "Running"
        }

        public void EndSchedule(int EmployeeId)
        {
            //1.Update EndSlot 2. Insert EndTime //status not changed
        }
    }
}