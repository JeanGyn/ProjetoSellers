using System;

namespace ProjetoSellers.Services.Exception
{
    public class DbConcurrencyException : ApplicationException
    {
        public DbConcurrencyException(string message) : base(message)
        {
        }
    }
}
