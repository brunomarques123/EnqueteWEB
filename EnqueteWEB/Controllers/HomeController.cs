using EnqueteWEB.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace EnqueteWEB.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Responder()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Responder(Resposta resposta)
        {
            Repositorio.AdicionarResposta(resposta);
            return View("Obrigado");
        }

        public IActionResult Resultado()
        {
            return View(Repositorio.Respostas);
        }

    }
}
