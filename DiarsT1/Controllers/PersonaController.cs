using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using DiarsT1.Models;
using Microsoft.EntityFrameworkCore;

namespace DiarsT1.Controllers
{

    public class PersonaController : Controller
    {
        private PersonaContext _context;
        public PersonaController(PersonaContext context)
        {
            _context = context;

        }
        [HttpGet]
        public ActionResult Index()
        {
            var person = _context.Persona.ToList();
           var city = _context.Persona.Include(o => o.IdCiudad).ToList();
            return View(person);
        }
        [HttpGet]

        ///////////////////////
        ///

        [HttpGet]
        public ActionResult Create() // GET
        {

            ViewBag.Ciudades = _context.Ciudad.ToList();
            return View("Create", new Persona());
        }

        [HttpPost]
        public ActionResult Create(Persona person) // POST
        {
            //if(account.Name == null || account.Name == "")
            //    ModelState.AddModelError("Name1", "El campo Nombre es requerido");

            if (!ModelState.IsValid)
            {
                ViewBag.Ciudades = _context.Ciudad.ToList();
                return View(person);
            }

            _context.Persona.Add(person);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        //////////////////


        /*
        public ActionResult Create() // GET
        {
            return View("Create", new Persona());
        }
        [HttpPost]
        public ActionResult Create(Persona person) // POST
        {
            if (ModelState.IsValid)
            {
                _context.Persona.Add(person);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View("Create", person);
        }
        */
        [HttpGet]
        public ActionResult Edit(int id)
        {
            ViewBag.Persona = new List<string> { "Nombre","Apellido", "FechaNacimiento","Dni","Genero","IdCiudad", "Directorio","Correo","UserName","Password"};
            var person = _context.Persona.Where(o => o.Id == id).FirstOrDefault();

            return View("Edit", person);
        }
     
        [HttpPost]
        public ActionResult Edit(Persona person)
        {
            if (ModelState.IsValid)
            {
                _context.Persona.Update(person);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Product = person;
            return View("Edit");
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            var person = _context.Persona.Where(o => o.Id == id).FirstOrDefault();
            _context.Persona.Remove(person);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
