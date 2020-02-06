using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PrimerParcialAP2.Data;
using PrimerParcialAP2.Models;

namespace PrimerParcialAP2.Controllers
{
    public class RegistroController : Controller
    {
        public bool Guardar(Registros registros)
        {
            bool paso = false;
            Contexto db = new Contexto();
            db.registros.Add(registros);
            paso = db.SaveChanges() > 0;
            return paso;

        }
        public Registros Buscar(int Id)
        {
            Contexto db = new Contexto();
            Registros registros = new Registros();
            registros = db.registros.Find(Id);
            return registros;
        }
        public bool Eliminar(int Id)
        {
            bool paso = false;
            Contexto db = new Contexto();
            var eliminar = db.registros.Find(Id);
            db.Entry(eliminar).State = EntityState.Deleted;
            paso = db.SaveChanges() > 0;
            return paso;
        }
        public bool Modificar(Registros registros)
        {
            bool paso = false;
            Contexto db = new Contexto();
            db.Entry(registros).State = EntityState.Modified;
            paso = db.SaveChanges() > 0;
            return paso;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}