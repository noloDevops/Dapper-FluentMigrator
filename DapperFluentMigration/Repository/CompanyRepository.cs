using System;
using DapperFluentMigration.Context;
using DapperFluentMigration.Contracts;

namespace DapperFluentMigration.Repository
{
    public class CompanyRepository : ICompanyRepository
    {
        private readonly DapperContext _context;

        public CompanyRepository(DapperContext context)
        {
            _context = context;
        }
    }
}

