using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using AcmeCurso.UI.MVC.Models;
using AcmeCurso.Domain;

namespace AcmeCurso.UI.MVC.Controllers
{
    [Authorize]
    public class EstudanteController : Controller
    {

        private WcfEstudanteService.IEstudanteService _serviceEstudante;

        public EstudanteController(WcfEstudanteService.IEstudanteService serviceEstudante)
        {
            _serviceEstudante = serviceEstudante;
        }
        [Authorize]
        public ActionResult Index()
        {
            return View(_serviceEstudante.GetAll());
        }

        [Authorize]
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Estudante estudante = _serviceEstudante.GetById(id.Value);
            if (estudante == null)
            {
                return HttpNotFound();
            }
            return View(estudante);
        }


        public ActionResult Create()
        {
            return View();
        }

        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Nome,Sobrenome,DataMatricula,DataCriacao")] Estudante estudante)
        {
            if (ModelState.IsValid)
            {
                _serviceEstudante.Add(estudante);
                return RedirectToAction("Index");
            }

            return View(estudante);
        }

        [Authorize]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Estudante estudante = _serviceEstudante.GetById(id.Value);
            if (estudante == null)
            {
                return HttpNotFound();
            }
            return View(estudante);
        }

        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Nome,Sobrenome,DataMatricula,DataCriacao")] Estudante estudante)
        {
            if (ModelState.IsValid)
            {
                _serviceEstudante.Update(estudante);
                return RedirectToAction("Index");
            }
            return View(estudante);
        }

        [Authorize]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Estudante estudante = _serviceEstudante.GetById(id.Value);
            if (estudante == null)
            {
                return HttpNotFound();
            }
            return View(estudante);
        }

        [Authorize]
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            _serviceEstudante.Delete(id);
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {

            //service.Close();
            base.Dispose(disposing);
        }
    }
}
