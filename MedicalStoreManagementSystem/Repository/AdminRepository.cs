using MedicalStoreManagementSystem.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedicalStoreManagementSystem.Repository
{
    public class AdminRepository:IAdminRepository    
    {
        private MedicalContext context = null;

        public AdminRepository(MedicalContext context)
        {
            this.context = context;
        }
       
        public void AddCompany(Company company)
        {
            context.Company.Add(company);
            context.SaveChanges();
        }

        public void DeleteCompanyById(int companyId)
        {
            Company company = context.Company.SingleOrDefault(a => a.CompanyId == companyId);
            context.Company.Remove(company);
            context.SaveChanges();
        }

        public List<Company> GetCompany()
        {
           return context.Company.ToList() ;
        }

        public void AddStock(Stock stock)
        {
            context.Stock.Add(stock);
            context.SaveChanges();
        }
        public Client GetClientById(int clientId)
        {
            return context.Client.SingleOrDefault(i => i.ClientId == clientId);
        }

        public Company GetSupplierById(int companyId)
        {
            return context.Company.SingleOrDefault(i => i.CompanyId == companyId);
        }

        public Stock GetStockById(int stockId)
        {
            return context.Stock.SingleOrDefault(i => i.StockID == stockId);
        }

        public List<Stock> GetStocks()
        {
            return context.Stock.ToList();
        }
        public void UpdateClient(int clientId, Client client)
        {
            client.ClientId = clientId;
            context.Entry(client).State = EntityState.Modified;
            context.SaveChanges();
            
        }

        public void UpdateCompany(int companyId, Company company)
        {
            company.CompanyId = companyId;
            context.Entry(company).State = EntityState.Modified;
            context.SaveChanges();
        }

        public void UpdateStock(int stockId)
        {
            Stock stock = context.Stock.Find(stockId);
            stock.StockID = stockId;
            context.SaveChanges();
        }

        

            public void DeleteStockById(int stockId)
        {
            Stock stock = context.Stock.SingleOrDefault(a => a.StockID == stockId);
            context.Stock.Remove(stock);
            context.SaveChanges();
        }

        public void AddClient(Client client)
        {
            context.Client.Add(client);
            context.SaveChanges();
        }

        public List<Client> GetClients()
        {
            return context.Client.ToList();
        }

        public void DeleteClientById(int clientId)
        {
            Client client = context.Client.SingleOrDefault(a => a.ClientId == clientId);
            context.Client.Remove(client);
            context.SaveChanges();
        }

        public List<Sell> GetSell()
        {
            return context.Sell.ToList();
        }

        public Sell GetSellbyId(int sellId)
        {
            return context.Sell.SingleOrDefault(i => i.SellId == sellId);
        }

        public void AddCustomer(Customer customer)
        {
            context.Customer.Add(customer);
            context.SaveChanges();
        }

        public void DeleteCustomerById(int customerId)
        {
            Customer customer = context.Customer.SingleOrDefault(a => a.CustomerId == customerId);
            context.Customer.Remove(customer);
            context.SaveChanges();
        }

        public List<Customer> GetCustomer()
        {
            return context.Customer.ToList();
        }


    }
}
