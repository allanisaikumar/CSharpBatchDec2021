using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using EntityFrameworkCRUDExample.Models;

namespace EntityFrameworkCRUDExample.Controllers
{
    public class HomeController : Controller
    {
        CompanyDbContext db = new CompanyDbContext();

        // GET: /Home/Index
        public ActionResult Index()
        {
            List<Employee> emps = db.Employees.ToList();

            return View(emps);
        }

        // GET: /Home/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: /Home/Create
        [HttpPost]
        public ActionResult Create(string EmpName, decimal Salary)
        {
            Employee emp = new Employee();
            //emp.EmpID = EmpID;
            emp.EmpName = EmpName;
            emp.Salary = Salary;
            db.Employees.Add(emp);
            db.SaveChanges();

            return RedirectToAction("Index");
        }

        // GET: /Home/Details
        public ActionResult Details(int id)
        {
            Employee emp = db.Employees.Find(id);

            return View(emp);
        }

        // GET: /Home/Edit
        public ActionResult Edit(int id)
        {
            Employee emp = db.Employees.Find(id);

            return View(emp);
        }

        // POST: /Home/Edit
        [HttpPost]
        public ActionResult Edit(Employee e)
        {
            Employee emp = db.Employees.Find(e.EmpID);
            emp.EmpName = e.EmpName;
            emp.Salary = e.Salary;
            db.SaveChanges();

            return RedirectToAction("Index");
        }

        // GET: /Home/Delete
        public ActionResult Delete(int id)
        {
            Employee emp = db.Employees.Find(id);

            return View(emp);
        }

        // POST: /Home/Delete
        [HttpPost]
        public ActionResult Delete(int id, Employee e)
        {
            Employee emp = db.Employees.Find(id);
            db.Employees.Remove(emp);
            db.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}

