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
    public class ProfessorController : Controller
    {

        WcfProfessorService.IProfessorService _professorService;
        WcfCursoService.ICursoService _cursoService;
        public ProfessorController(WcfProfessorService.IProfessorService professorService, WcfCursoService.ICursoService cursoService)
        {
            _professorService = professorService;
            _cursoService = cursoService;

        }
        public ActionResult Index()
        {
            return View(_professorService.GetAll());
        }

        
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Professor professor = _professorService.GetById(id.Value);
            if (professor == null)
            {
                return HttpNotFound();
            }
            return View(professor);
        }

        
        public ActionResult Create()
        {
            ViewBag.CursoId = new SelectList(_cursoService.GetAll(), "Id", "Nome");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Nome,Sobrenome,Titulacao,CursoId,DataCriacao")] Professor professor)
        {
            if (ModelState.IsValid)
            {
                _professorService.Add(professor);
                return RedirectToAction("Index");
            }

            ViewBag.CursoId = new SelectList(_cursoService.GetAll(), "Id", "Nome", professor.CursoId);
            return View(professor);
        }


        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Professor professor = _professorService.GetById(id.Value);
            if (professor == null)
            {
                return HttpNotFound();
            }
            ViewBag.CursoId = new SelectList(_cursoService.GetAll(), "Id", "Nome", professor.CursoId);
            return View(professor);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Nome,Sobrenome,Titulacao,CursoId,DataCriacao")] Professor professor)
        {
            if (ModelState.IsValid)
            {
                _professorService.Update(professor);
                return RedirectToAction("Index");
            }
            ViewBag.CursoId = new SelectList(_cursoService.GetAll(), "Id", "Nome", professor.CursoId);
            return View(professor);
        }


        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Professor professor = _professorService.GetById(id.Value);
            if (professor == null)
            {
                return HttpNotFound();
            }
            return View(professor);
        }


        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            _professorService.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
