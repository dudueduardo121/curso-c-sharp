using SalesWebMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SalesWebMvc.Services
{
    public class RegistrosVendaServico
    {
        private readonly SalesWebMvcContext _context;

        public RegistrosVendaServico(SalesWebMvcContext context)
        {
            _context = context;
        }

        public async Task<List<RegistrosVenda>> FindByDateAsync(DateTime? dataMinima, DateTime? dataMaxima)
        {
            IQueryable<RegistrosVenda> result = from obj in _context.RegistroVendas select obj;

            if (dataMinima.HasValue)
            {
                result = result.Where(x => x.Data >= dataMinima.Value);
            }

            if (dataMaxima.HasValue)
            {
                result = result.Where(x => x.Data <= dataMaxima.Value);
            }

            return await result
                .Include(x => x.Vendedor)
                .Include(x => x.Vendedor.Departamento)
                .OrderByDescending(x => x.Data)
                .ToListAsync();
        }
    }
}
