using Entities.Models;

namespace Repositories.Interfaces;

public interface ICompanyRepository
{
    public Company GetOneCompany(int id);
    public List<Company> GetAllCompany();

    public void CreateCompany(Company company);
    public void UpdateOneCompany(int id, Company company);
    public Company DeleteOneCompany(int id);
}