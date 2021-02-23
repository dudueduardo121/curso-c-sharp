using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SalesWebMvc.Services;

namespace SalesWebMvc.Controllers
{
    public class RegistrosVendasController : Controller
    {
        private readonly RegistrosVendaServico _registrosVendaServico;

        public RegistrosVendasController(RegistrosVendaServico registrosVendaServico)
        {
            _registrosVendaServico = registrosVendaServico;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> BuscaSimples(DateTime? dataMinima, DateTime? dataMaxima)
        {
            var result = await _registrosVendaServico.FindByDateAsync(dataMinima, dataMaxima);
            return  View(result);
        }

        public IActionResult BuscaGrupo()
        {
            return View();
        }
    }
}
