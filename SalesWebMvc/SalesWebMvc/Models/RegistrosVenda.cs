using SalesWebMvc.Models.Enums;
using System;

namespace SalesWebMvc.Models
{
    public class RegistrosVenda
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public double Montante { get; set; }
        public VendasAtualizada Status { get; set; }
        public Vendedor Vendedor { get; set; }
        public DateTime? Date { get; internal set; }

        public RegistrosVenda()
        {
        }

        public RegistrosVenda(int id, DateTime data, double montante, VendasAtualizada status, Vendedor vendedor)
        {
            Id = id;
            Data = data;
            Montante = montante;
            this.Status = status;
            this.Vendedor = vendedor;
        }
    }
}
