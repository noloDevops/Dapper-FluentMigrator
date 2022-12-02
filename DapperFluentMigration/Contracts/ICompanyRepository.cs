using DapperFluentMigration.Entities;

namespace DapperFluentMigration.Contracts
{
    public interface ICompanyRepository
    {
        public Task<IEnumerable<Company>> GetCompanies();
    }
}

