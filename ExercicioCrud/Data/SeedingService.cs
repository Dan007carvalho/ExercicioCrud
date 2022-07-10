using ExercicioCrud.Models;
using ExercicioCrud.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace ExercicioCrud.Data
{
    public class SeedingService
    {
        private ExercicioCrudContext _context;

        public SeedingService(ExercicioCrudContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if (_context.Department.Any() || 
                _context.Seller.Any() ||
                _context.SalesRecord.Any())
            {
                return; // O banco de dados já foi populado
            }

            Department d1 = new Department(new int(),"Informática" );
            Department d2 = new Department(new int(), "Eletro" );
            Department d3 = new Department(new int(), "Moda" );
            Department d4 = new Department(new int(), "Livro" );

            Seller s1 = new Seller(new int(), "Lirito", "lirito@hotmail.com", new DateTime(2002, 6, 25), 2500.00, d4);
            Seller s2 = new Seller(new int(), "Lembe Bosta", "bosta@gmail.com", new DateTime(2005, 10, 12), 1500.00, d1);
            Seller s3 = new Seller(new int(), "Garotinho", "garotinho@hotmail.com", new DateTime(1999, 4, 9), 3500.00, d3);
            Seller s4 = new Seller(new int(), "Tim Maia", "tim@hotmail.com", new DateTime(2010, 5, 18), 4000.00, d1);
            Seller s5 = new Seller(new int(), "Pilantroso", "pilantroso@gmail.com", new DateTime(2007, 2, 13), 5200.00, d2);
            Seller s6 = new Seller(new int(), "X nove", "xnove@hotmail.com", new DateTime(2004, 12, 22), 3800.00, d2);

            SalesRecord sr1 = new SalesRecord(new int(), new DateTime(2012, 2, 23), 15000.00, SaleStatus.Faturado, s2);
            SalesRecord sr2 = new SalesRecord(new int(), new DateTime(2013, 5, 12), 25000.00, SaleStatus.Cancelado, s3);
            SalesRecord sr3 = new SalesRecord(new int(), new DateTime(2012, 8, 17), 11000.00, SaleStatus.Pendente, s6);
            SalesRecord sr4 = new SalesRecord(new int(), new DateTime(2015, 1, 5), 13000.00, SaleStatus.Faturado, s4);
            SalesRecord sr5 = new SalesRecord(new int(), new DateTime(2014, 10, 2), 21000.00, SaleStatus.Faturado, s1);
            SalesRecord sr6 = new SalesRecord(new int(), new DateTime(2011, 7, 25), 7000.00, SaleStatus.Pendente, s2);
            SalesRecord sr7 = new SalesRecord(new int(), new DateTime(2016, 8, 14), 1400.00, SaleStatus.Faturado, s3);
            SalesRecord sr8 = new SalesRecord(new int(), new DateTime(2017, 9, 3), 23000.00, SaleStatus.Cancelado, s5);
            SalesRecord sr9 = new SalesRecord(new int(), new DateTime(2019, 10, 20), 17000.00, SaleStatus.Faturado, s1);
            SalesRecord sr10 = new SalesRecord(new int(), new DateTime(2013, 5, 18), 12800.00, SaleStatus.Cancelado, s2);
            SalesRecord sr11 = new SalesRecord(new int(), new DateTime(2013, 7, 25), 11700.00, SaleStatus.Faturado, s4);
            SalesRecord sr12 = new SalesRecord(new int(), new DateTime(2014, 6, 30), 31200.00, SaleStatus.Faturado, s2);
            SalesRecord sr13 = new SalesRecord(new int(), new DateTime(2015, 6, 11), 24100.00, SaleStatus.Faturado, s3);


            _context.Department.AddRange(d1, d2, d3, d4);
            _context.Seller.AddRange(s1, s2, s3, s4, s5, s6);
            _context.SalesRecord.AddRange(sr1, sr2, sr3, sr4, sr5, sr6, sr7, sr8, sr9, sr10, sr11, sr12, sr13);

            _context.SaveChanges();

        }
    }
}
