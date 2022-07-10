using ExercicioCrud.Data;
using ExercicioCrud.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ExercicioCrud.Service
{
    public class SalesRecordService
    {
        private readonly ExercicioCrudContext _context;

        public SalesRecordService(ExercicioCrudContext context)
        {
            _context = context;
        }

        public async Task<List<SalesRecord>> FindByDateAsync(DateTime? minDate, DateTime? maxDate)
        {
            var result = from obj in _context.SalesRecord select obj;

            if (minDate.HasValue)
            {
                result = result.Where(x => x.Data >= minDate.Value);
            }

            if (maxDate.HasValue)
            {
                result = result.Where(x => x.Data <= maxDate.Value);
            }
            return await result
                .Include(x => x.Vendedor)
                .Include(x => x.Vendedor.Department)
                .OrderByDescending(x => x.Data)
                .ToListAsync();
        }

        public async Task<List<IGrouping<Department, SalesRecord>>> FindByDateGroupingAsync(DateTime? minDate, DateTime? maxDate)
        {
            var result = from obj in _context.SalesRecord select obj;

            if (minDate.HasValue)
            {
                result = result.Where(x => x.Data >= minDate.Value);
            }

            if (maxDate.HasValue)
            {
                result = result.Where(x => x.Data <= maxDate.Value);
            }
            var data = await result

                .Include(x => x.Vendedor)

                .Include(x => x.Vendedor.Department)

                .OrderByDescending(x => x.Data)

                .ToListAsync();

            return data.GroupBy(x => x.Vendedor.Department).ToList();
        }
    }
}
