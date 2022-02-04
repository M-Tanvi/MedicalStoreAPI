using MedicalStoreManagementSystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedicalStoreManagementSystem.Repository
{
    public interface IAdminRepository
    {
        void AddCustomer(Customer customer);
        void DeleteCustomerById(int customerId);
        List<Customer> GetCustomer();
        void AddCompany(Company company);
        void DeleteCompanyById(int companyId);
        List<Company> GetCompany();
        void AddStock(Stock stock);
        Client GetClientById(int clientId);
        Company GetSupplierById(int companyId);
        Stock GetStockById(int stockId);
        List<Stock> GetStocks();
        void UpdateClient(int clientId, Client client);

        void UpdateCompany(int companyId, Company company);
        void UpdateStock(int stockId);
        
        void DeleteStockById(int stockId);
        void AddClient(Client client);
        List<Client> GetClients();
        void DeleteClientById(int clientId);
        List<Sell> GetSell();
        Sell GetSellbyId(int sellId);
    }
}
