using Microsoft.AspNetCore.Mvc;
using Rotativa.AspNetCore;
using Rotativa.Net6.Models;
using System.Diagnostics;

namespace Rotativa.Net6.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var clients = new List<Client>()
            {
                new Client(){ Cpf="127.256.369.35", Name="Lucas Santos", Gender="Masculino", Age=23, Telephone="3841-3856" },
                new Client(){ Cpf="185.989.636.85", Name="Júlia Almeida", Gender="Feminino", Age=13, Telephone="3142-3885" },
                new Client(){ Cpf="589.245.854.14", Name="Carlos Cesar", Gender="Masculino", Age=35, Telephone="3885-1212" },
                new Client(){ Cpf="753.357.147.25", Name="Altair Silva", Gender="Masculino", Age=58, Telephone="3696-1296" },
                new Client(){ Cpf="441.258.369.85", Name="Ana Clara", Gender="Feminino", Age=21, Telephone="3758-4745" },
                new Client(){ Cpf="758.969.354.14", Name="Lara Magalhães", Gender="Feminino", Age=18, Telephone="3996-6658" },
                new Client(){ Cpf="894.758.263.21", Name="Ronaldo Santos", Gender="Masculino", Age=40, Telephone="3745-7585" },
                new Client(){ Cpf="141.456.251.32", Name="Marcus Vinícius", Gender="Masculino", Age=32, Telephone="3442-3365" },
            };

            return new ViewAsPdf("Index", clients);
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}