using ExercicioCrud.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ExercicioCrud.Models
{
    public class SalesRecord
    {
        public int Id { get; set; }
        [DisplayFormat(DataFormatString = " {0:dd/MM/yyyy} ")]
        public DateTime Data { get; set; }
        [DisplayFormat(DataFormatString = "{0:F2}")]
        public double Quantia { get; set; }
        public SaleStatus Status { get; set; }
        public Seller Vendedor { get; set; }

        public SalesRecord()
        {
        }

        public SalesRecord(int id, DateTime data, double quantia, SaleStatus status, Seller vendedor)
        {
            Id = id;
            Data = data;
            Quantia = quantia;
            Status = status;
            Vendedor = vendedor;
        }
    }
}
