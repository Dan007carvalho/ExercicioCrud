using ExercicioCrud.Data;
using ExercicioCrud.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ExercicioCrud.Service
{
    public class DepartmentService
    {
        private readonly ExercicioCrudContext _context;

        public DepartmentService(ExercicioCrudContext context)
        {
            _context = context;
        }

        public async Task<List<Department>> FindAllAsync()
        {
            return await _context.Department.OrderBy(x => x.Nome).ToListAsync();
        }
    }

}
