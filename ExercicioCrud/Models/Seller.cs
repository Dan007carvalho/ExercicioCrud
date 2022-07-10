using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ExercicioCrud.Models
{
    public class Seller
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="{0} é obrigatório.")]
        [StringLength(60, MinimumLength = 3, ErrorMessage = "O tamanho do nome tem que ser entre {2} e {1} caracteres.")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "{0} é obrigatório.")]
        [EmailAddress(ErrorMessage ="Entre com um email válido.")]
        public string Email { get; set; }
        [Display(Name = "Data de nascimento")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        [Required(ErrorMessage = "{0} é obrigatório.")]
        public DateTime DataNascimento { get; set; }
        [Display(Name ="Salário base")]
        [DisplayFormat(DataFormatString ="{0:f2}")]
        [Required(ErrorMessage = "{0} é obrigatório.")]
        [Range(100.0, 50000.0, ErrorMessage ="O {0} tem que ser entre {1} e {2}")]
        public double SalarioBase { get; set; }
        [Display(Name ="Departamento")]
        public Department Department { get; set; }
        public int DepartmentId { get; set; }
        public ICollection<SalesRecord> Sales { get; set; } = new List<SalesRecord>();

        public Seller()
        {
        }

        public Seller(int id, string nome, string email, DateTime birthDate, double baseSalary, Department department)
        {
            Id = id;
            Nome = nome;
            Email = email;
            DataNascimento = birthDate;
            SalarioBase = baseSalary;
            Department = department;
        }

        public void AddSales(SalesRecord sr)
        {
            Sales.Add(sr);

        }

        public void RemoveSales(SalesRecord sr)
        {
            Sales.Remove(sr);

        }

        public double TotalSales(DateTime initial, DateTime final)
        {
            return Sales.Where(sr => sr.Data >= initial && sr.Data <= final).Sum(sr => sr.Quantia);
        }
    }
}
