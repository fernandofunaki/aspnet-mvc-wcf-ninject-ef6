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
    public class InscricaoController : Controller
    {
        private WcfInscricaoService.IInscricaoService _inscricaoService;
        private WcfEstudanteService.IEstudanteService _estudanteService;
        private WcfCursoService.ICursoService _cursoService;

        public InscricaoController(
            WcfInscricaoService.IInscricaoService inscricaoService,
            WcfEstudanteService.IEstudanteService estudanteService, 
            WcfCursoService.ICursoService cursoService)
        {
            _inscricaoService = inscricaoService;
            _estudanteService = estudanteService;
            _cursoService = cursoService;
        }


        [HttpGet]
        public ActionResult Index()
        {
            var result = _inscricaoService.GetAll();
            return View(result);
        }


        [HttpGet]
        public ActionResult CadastrarEstudante()
        {
            var estudantes = _estudanteService.GetAll();
            var cursos = _cursoService.GetAll();

            List<SelectListItem> selectEstudantes = estudantes.Select(a => new SelectListItem()
            {
                Text = string.Format("{0} {1}", a.Nome, a.Sobrenome),
                Value = a.Id.ToString()
            }).ToList();


            List<SelectListItem> selectCursos = cursos.Select(a => new SelectListItem()
            {
                Text = a.Nome,
                Value = a.Id.ToString()
            }).ToList();

            ViewBag.CursoId = selectCursos;
            ViewBag.EstudanteId = selectEstudantes;

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CadastrarEstudante(Inscricao inscricao)
        {
            if (ModelState.IsValid)
            {
                _inscricaoService.Add(inscricao);
                return RedirectToAction("index");
            }

            return View(inscricao);
        }

        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Inscricao inscricao = _inscricaoService.GetById(id.Value);
            if (inscricao == null)
            {
                return HttpNotFound();
            }
            return View(inscricao);
        }



        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id)
        {
            if (ModelState.IsValid)
            {
                _inscricaoService.Delete(id);
                return RedirectToAction("index");
            }

            return View();
        }

    }
}
