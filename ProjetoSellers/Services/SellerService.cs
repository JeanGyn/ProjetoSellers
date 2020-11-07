using ProjetoSellers.Data;
using ProjetoSellers.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoSellers.Services
{
    public class SellerService
    {
        private readonly ProjetoSellersContext _context;

        public SellerService(ProjetoSellersContext context)
        {
            _context = context;
        }

        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }

        public void Insert(Seller obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }
    }
}
