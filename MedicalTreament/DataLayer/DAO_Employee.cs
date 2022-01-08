using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DataLayer
{
    public class DAO_Employee
    {
        MedicalTreatmentEntities db;

        private static DAO_Employee instance;
        private DAO_Employee()
        {
            db = new MedicalTreatmentEntities();
        }
        public static DAO_Employee getInstance()
        {
            if (instance == null)
            {
                instance = new DAO_Employee();
            }
            return instance;
        }
        public dynamic GetGP()
        {
            var list = from GP in db.Set<Employee>()
                       where GP.Position == "GP" 
                       select new
                       {
                           GP.EmployeeID,
                           GP.Name,
                           GP.Position,
                           GP.Salary,
                           GP.Email
                       };

            return list.ToList();
        }

        public decimal? GetEmployeeSalary(int id)
        {
            Employee employee = db.Employees.Where(e => e.EmployeeID == id).Single();
            return employee.Salary;
        }

        public string GetEmployeeEmail(int id)
        {
            Employee employee = db.Employees.Where(e => e.EmployeeID == id).Single();
            return employee.Email;
        }

        public string GetEmployeePosition(int id)
        {
            Employee employee = db.Employees.Where(e => e.EmployeeID == id).Single();
            return employee.Position;
        }

        public void AddGP(string name, string phone, DateTime birth, string gender = "",
       string address = "", string healthInsurance = "", string nation = "", string workplace = "")
        {
            Patient patient = new Patient()
            {
                Name = name,
                Phone = phone,
                DateOfBirth = birth.Date,
                Gender = gender,
                Address = address,
                HealthInsuarance = healthInsurance,
                Nation = nation,
                WorkPlace = workplace
            };

            db.Patients.Add(patient);
            db.SaveChanges();

        }
        public dynamic GetEmployee()
        {
            var list = from employee in db.Set<Employee>()
                       orderby employee.EmployeeID
                       select new
                       {
                           employee.EmployeeID,
                           employee.Name,
                           employee.Position,
                           Salary = (int)employee.Salary,
                           employee.Email
                       };

            return list.ToList();
        }
        public int GetLength()
        {
            var list = from employee in db.Set<Employee>()
                       select new
                       { };
            int length = list.ToList().Count;
            return length;
        }
        public dynamic GetNewestEmployee()
        {
            var list = from employee in db.Set<Employee>()
                       orderby employee.EmployeeID descending
                       select new
                       {
                           employee.EmployeeID,
                           employee.Name,
                           employee.Position,
                           employee.Salary,
                           employee.Email
                       };

            return list.ToList();
        }

        public string GetEmployeeName(int specialistID)
        {
            Employee employee = db.Employees.Where(e => e.EmployeeID == specialistID).Single();
            return employee.Name;
        }

        public dynamic GetSalaryOver()
        {
            var list = from employee in db.Set<Employee>()
                       where employee.Salary >= 100000000
                       select new
                       {
                           employee.EmployeeID,
                           employee.Name,
                           employee.Position,
                           employee.Salary,
                           employee.Email
                       };

            return list.ToList();
        }
        public dynamic GetSalaryUnder()
        {
            var list = from employee in db.Set<Employee>()
                       where employee.Salary < 100000000
                       select new
                       {
                           employee.EmployeeID,
                           employee.Name,
                           employee.Position,
                           employee.Salary,
                           employee.Email
                       };

            return list.ToList();
        }
        public dynamic GetSearchEmployee(string search)
        {
            var list = from employee in db.Set<Employee>()
                       where employee.Name.Contains(search)
                       select new
                       {
                           employee.EmployeeID,
                           employee.Name,
                           employee.Position,
                           employee.Salary,
                           employee.Email
                       };

            return list.ToList();
        }
        public int GetEmployeeID(string name, string email)
        {
            Employee employee = db.Employees.Where(e => e.Name == name && e.Email == email).Single();
            return employee.EmployeeID;
        }

        public void AddEmloyee(string name, string position, string email, decimal salary)
        {
            Employee employee = new Employee()
            {
                Name = name,
                Position = position,
                Salary = salary,
                Email = email

            };

            db.Employees.Add(employee);
            db.SaveChanges();

        }

        public void EditEmployee(int employeeid, string name, string position, string email, decimal salary)
        {
            Employee employee = db.Employees.Find(employeeid);
            employee.Name = name;
            employee.Position = position;
            employee.Email = email;
            employee.Salary = salary;

            db.SaveChanges();
        }
        public void DeleteEmployee(int employeeid)
        {
            Employee employee = db.Employees.Find(employeeid);
            db.Employees.Remove(employee);
            db.SaveChanges();
        }
        public void PayEmployee(decimal value, int employeeid)
        {
            PaySalary paysalary = new PaySalary()
            {
                Date = DateTime.Now,
                Value = value,
                EmployeeID = employeeid
            };

            db.PaySalaries.Add(paysalary);
            db.SaveChanges();
        }
    }
}
