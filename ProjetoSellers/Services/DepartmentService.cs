using ProjetoSellers.Data;
using ProjetoSellers.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoSellers.Services
{
    public class DepartmentService
    {
        private readonly ProjetoSellersContext _context;

        public DepartmentService(ProjetoSellersContext context)
        {
            _context = context;
        }

        public List<Department> FindAll()
        {
            return _context.Department.OrderBy(x => x.Name).ToList();
        }
    }
}
