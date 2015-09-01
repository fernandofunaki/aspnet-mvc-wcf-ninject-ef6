using AcmeCurso.Domain;
using ConsoleApplicationTests.WcfEstudanteService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationTests
{
    class Program
    {
        static void Main(string[] args)
        {
            WcfInscricaoService.InscricaoServiceClient inscricaoService = new WcfInscricaoService.InscricaoServiceClient();
            var todasInscricoes = inscricaoService.GetAll();



            WcfEstudanteService.EstudanteServiceClient estudanteService = new WcfEstudanteService.EstudanteServiceClient();
            var todosEstudantes = estudanteService.GetAll();
            //var estudante = new WcfEstudanteService.EstudanteServiceClient() { Nome = "Joselito", Sobrenome = "Feliciano", DataMatricula = DateTime.Now };
           
            //estudanteService.Add(estudante);
        }
    }
}
