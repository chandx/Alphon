﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApp.Models;

namespace WebApp.Features.Admin.Professors
{
    [Area("Admin")]
    public class ProfessorsController : Controller
    {
        [Route("/Admin/Professors")]
        public IActionResult Professors()
        {
            //For Prototyping: Just create an arbitrary list of Students (Accounts entity)
            List<Professor> model = new List<Professor>
            {
                new Professor

                {
                    firstname = "Justin",
                    lastname = "Timberlake",
                    Id = 1,
                    usertype = "admin",
                    lastlogin = DateTime.Now
                },
                new Account
                {
                    firstname = "Chris",
                    lastname = "Green",
                    Id = 2,
                    usertype = "admin",
                    lastlogin = DateTime.Now
                }
            };

            ViewData["Title"] = "Professors";
            return View("Professors", model);
        }

        [Route("/Admin/Professors/{id}")]
        public IActionResult Professor(int id)
        {
            //For Prototyping: Just create an arbitrary student entity
            var model = new Professor
            {
                firstname = "Chris",
                lastname = "Green",
                Id = id,
                usertype = "admin",
                lastlogin = DateTime.Now
            };

            ViewData["Title"] = model.firstname + " " + model.lastname;
            return View("Professor", model);
        }

        [HttpPost]
        [Route("/Admin/Professors/Create")]
        public IActionResult Create(Professor professor) => Redirect("/Admin/Professors");
    }
}