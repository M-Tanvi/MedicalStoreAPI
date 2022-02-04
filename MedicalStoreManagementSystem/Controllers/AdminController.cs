using MedicalStoreManagementSystem.Entities;
using MedicalStoreManagementSystem.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedicalStoreManagementSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme, Policy = "IsAdmin")]
    public class AdminController : ControllerBase
    {
        private IAdminRepository repoObj;
        public AdminController(IAdminRepository repo)
        {
            this.repoObj = repo;
        }
        [HttpPost]
        [Route("AddCompany")]
        public IActionResult AddCompany(Company company)// admin add Company
        {
            if (company != null)
            {
                repoObj.AddCompany(company);
                return Ok(company);
            }
            else
                return BadRequest("Invalid");
        }

        [HttpPost]
        [Route("AddStock")]
        public IActionResult AddStock(Stock stock)// admin add Stock
        {
            if (stock != null)
            {
                repoObj.AddStock(stock);
                return Ok(stock);
            }
            else
                return BadRequest("Invalid");
        }

        [HttpPost]
        [Route("AddClient")]
        public IActionResult AddClient(Client client)// admin add Client
        {
            if (client != null)
            {
                repoObj.AddClient(client);
                return Ok(client);
            }
            else
                return BadRequest("Invalid");
        }

        [HttpGet]
        [Route("GetCompany")]
        public List<Company> GetCompany()// Admin view Company
        {

            return repoObj.GetCompany();
        }

        [HttpGet]
        [Route("GetStocks")]
        public List<Stock> GetStocks()// Admin view Stock
        {
            return repoObj.GetStocks();
        }

        [HttpGet]
        [Route("GetClients")]
        public List<Client> GetClients()// Admin view Client
        {
            return repoObj.GetClients();
        }

        [HttpGet] // Client by Id
        [Route("GetClientById/{clientId}")]
        public IActionResult GetClientById(int clientId)
        {
            if (clientId != 0)
            {
                return Ok(repoObj.GetClientById(clientId));
            }
            else
            {
                return BadRequest("Enter Valid Input");
            }
        }


        [HttpGet] // Company by Id
        [Route("GetSupplierById/{companyId}")]
        public IActionResult GetSupplierById(int companyId)
        {
            if (companyId != 0)
            {
                return Ok(repoObj.GetSupplierById(companyId));
            }
            else
            {
                return BadRequest("Enter Valid Input");
            }
        }

        [HttpGet] // Admin view Stock by Id
        [Route("GetStockById/{stockId}")]
        public IActionResult GetStockById(int stockId)
        {
            if (stockId != 0)
            {
                return Ok(repoObj.GetStockById(stockId));
            }
            else
            {
                return BadRequest("Enter Valid Input");
            }
        }

        [HttpGet] // Admin view Stock by Id
        [Route("GetSellById/{sellId}")]
        public IActionResult GetSellbyId(int sellId)
        {
            if (sellId != 0)
            {
                return Ok(repoObj.GetSellbyId(sellId));
            }
            else
            {
                return BadRequest("Enter Valid Input");
            }
        }

        [HttpGet]
        [Route("GetSell")]
        public List<Sell> GetSell()// Admin view Client
        {
            return repoObj.GetSell();
        }

        [HttpPut]  
        [Route("UpdateClientById/{clientId}")]
        
        public string UpdateClient(int clientId, Client client)
        {
            repoObj.UpdateClient(clientId, client);
            return "Client updated";
        }
        [HttpPut] 
        [Route("UpdateCompanyById/{companyId}")]
        public string UpdateCompany(int companyId, Company company)
        {
            repoObj.UpdateCompany(companyId, company);
            return "Company updated";
        }

        [HttpPut] //UpdateStock by stockId
        [Route("UpdateStock")]
        public string UpdateStock(int stockId)
        {
            repoObj.UpdateStock( stockId);
            return "Stock updated";
        }



        [HttpDelete]  //Delete Company By Id
        [Route("DeleteCompanyById/{companyId}")]
        public IActionResult DeleteCompanyById(int companyId)
        {
            try
            {
                repoObj.DeleteCompanyById(companyId);
                return Ok("Company is  Deleted");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete] //Delete Stock By Id
        [Route("DeleteStockById/{stockId}")]
        public IActionResult DeleteStockById(int stockId)
        {
            try
            {
                repoObj.DeleteStockById(stockId);
                return Ok("Company is  Deleted");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete] //Delete Client By Id
        [Route("DeleteClientById/{clientId}")]
        public IActionResult DeleteClientById(int clientId)
        {
            try
            {
                repoObj.DeleteClientById(clientId);
                return Ok("Client is  Deleted");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        [Route("AddCustomer")]
        public IActionResult AddCustomer(Customer customer)// admin add Customer
        {
            if (customer != null)
            {
                repoObj.AddCustomer(customer);
                return Ok(customer);
            }
            else
                return BadRequest("Invalid");
        }

        [HttpDelete] //Delete Customer By Id
        [Route("DeleteCustomerById/{customerId}")]
        public IActionResult DeleteCustomerById(int customerId)
        {
            try
            {
                repoObj.DeleteCustomerById(customerId);
                return Ok("Customer is  Deleted");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("GetCustomer")]
        public List<Customer> GetCustomer()// Admin view Customer
        {
            return repoObj.GetCustomer();
        }
    }
}
