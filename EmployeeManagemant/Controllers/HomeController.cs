﻿using EmployeeManagemant.Models;
using Microsoft.AspNetCore.Mvc;
using EmployeeManagemant.ViewModels;


namespace EmployeeManagemant.Controllers
{
   
    public class HomeController : Controller
    {
        private readonly IEmployeeRepository _employeeRepository;

        public HomeController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }
      
        public ViewResult Index()
        {
            var model = _employeeRepository.GetAllEmployee();
            return View(model);
        }
       
        public ViewResult Details(int? id)
        {
            HomeDetailsViewModel homeDetailsViewModel = new HomeDetailsViewModel()
            {
                Employee = _employeeRepository.GetEmployee(id ?? 1),
                PageTitle = "Employee Details"
            };

            return View(homeDetailsViewModel);
        }
        [HttpGet]
        public ViewResult Create()
        {
            return View();
        }
        [HttpPost]
        public RedirectToActionResult Create(Employee employee)
        {
           Employee newEmployee = _employeeRepository.Add(employee);
            return RedirectToAction("details", new { id = newEmployee.Id});
        }
    }
}