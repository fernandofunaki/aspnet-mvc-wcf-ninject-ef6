using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using AcmeCurso.Domain;
using AcmeCurso.UI.MVC.Models;

namespace AcmeCurso.UI.MVC.Controllers
{
    [Authorize]
    public class CursoController : Controller
    {


        private WcfCursoService.ICursoService _cursoService;

        public CursoController(WcfCursoService.ICursoService cursoService)
        {
            _cursoService = cursoService;
        }

        public ActionResult Index()
        {
            return View(_cursoService.GetAll());
        }


        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Curso curso = _cursoService.GetById(id.Value);
            if (curso == null)
            {
                return HttpNotFound();
            }
            return View(curso);
        }


        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Nome,Descricao,DataLimiteInscricao,DataCriacao")] Curso curso)
        {
            if (ModelState.IsValid)
            {
                _cursoService.Add(curso);
                return RedirectToAction("Index");
            }

            return View(curso);
        }

        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Curso curso = _cursoService.GetById(id.Value);
            if (curso == null)
            {
                return HttpNotFound();
            }
            return View(curso);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Nome,Descricao,DataLimiteInscricao,DataCriacao")] Curso curso)
        {
            if (ModelState.IsValid)
            {
                _cursoService.Update(curso);
                return RedirectToAction("Index");
            }
            return View(curso);
        }


        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Curso curso = _cursoService.GetById(id.Value);
            if (curso == null)
            {
                return HttpNotFound();
            }
            return View(curso);
        }


        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            _cursoService.Delete(id);
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            //_cursoService.Close();
            base.Dispose(disposing);
        }

    }
}
