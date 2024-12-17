using Microsoft.AspNetCore.Mvc;
using POC.Rotativa.AspNetCore.Models.Customer;
using Rotativa.AspNetCore;

namespace POC.Rotativa.AspNetCore.Controllers.Customer;

public class CustomerController : Controller
{
    public IActionResult Index()
    {
        var customers = new List<CustomerViewModel>()
        {
            new(){ Cpf = "382.256.369.35", Name = "Lucas Santos", Gender = "Male", Age = 23, Telephone = "3841-3856" },
            new(){ Cpf = "185.989.636.85", Name = "Júlia Almeida", Gender = "Female", Age = 13, Telephone = "3142-3885" },
            new(){ Cpf = "589.245.854.14", Name = "Carlos Cesar", Gender = "Male", Age = 35, Telephone = "3885-1212" },
            new(){ Cpf = "753.357.147.25", Name = "Altair Silva", Gender = "Male", Age = 58, Telephone = "3696-1296" },
            new(){ Cpf = "441.258.369.85", Name = "Ana Clara", Gender = "Female", Age = 21, Telephone = "3758-4745" },
            new(){ Cpf = "758.969.354.14", Name = "Lara Magalhães", Gender = "Female", Age = 18, Telephone = "3996-6658" },
            new(){ Cpf = "894.758.263.21", Name = "Ronaldo Santos", Gender = "Male", Age = 40, Telephone = "3745-7585" },
            new(){ Cpf = "141.456.251.32", Name = "Marcus Vinícius", Gender = "Male", Age = 32, Telephone = "3442-3365" }
        };

        return new ViewAsPdf("Index", customers);
    }
}