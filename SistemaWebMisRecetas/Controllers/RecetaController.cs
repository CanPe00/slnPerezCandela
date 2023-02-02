using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SistemaWebMisRecetas.Data;
using SistemaWebMisRecetas.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace SistemaWebMisRecetas.Controllers
{
    public class RecetaController : Controller
    {
        private readonly DBSistemaWebMisRecetaContext context;

        public RecetaController(DBSistemaWebMisRecetaContext context)
        {
            this.context = context;
        }

        public IActionResult Filtro(string NombreAutor, string ApellidoAutor)
        {
            List<Receta> recetas = (from m in context.Recetas
                                    where m.ApellidoAutor.Contains(ApellidoAutor) || m.NombreAutor.Contains(NombreAutor)
                                    select m).ToList();

            //List<Receta> recetas = context.Recetas.ToList();
            return View("Index",recetas);
        }

        public IActionResult Index()
        {
            List<Receta> recetas = context.Recetas.ToList();
            return View(recetas);
        }

        public IActionResult Create()
        {
            Receta receta = new Receta();
            return View(receta);
        }

        [HttpPost]
        public IActionResult Create(Receta receta)
        {
            if (ModelState.IsValid)
            {
                context.Recetas.Add(receta);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(receta);
        }

        public IActionResult Details(int id)
        {
            Receta receta = TraerUna(id);
            if (receta == null)
            {
                return NotFound();
            }
            return View(receta);
        }
       
        public IActionResult Delete(int id)
        {
            Receta receta = TraerUna(id);
            if (receta == null)
            {
                return NotFound();
            }
            return View(receta);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            Receta receta = TraerUna(id);
            if (receta == null)
            {
                return NotFound();
            }
            context.Recetas.Remove(receta);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            Receta receta = TraerUna(id);
            if (receta == null)
            {
                return NotFound();
            }
            return View(receta);
        }

        [HttpPost]
        [ActionName("Edit")]
        public IActionResult EditConfirmed(Receta receta)
        {
            if (ModelState.IsValid)
            {
                context.Entry(receta).State = EntityState.Modified;
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(receta);
        }

        private Receta TraerUna(int id)
        {
            return context.Recetas.Find(id);
        }
    }
}
