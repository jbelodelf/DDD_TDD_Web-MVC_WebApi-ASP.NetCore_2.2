using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Application.Interfaces;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using WebApplication.Models;

namespace WebApplication.Controllers
{
    public class HomeController : Controller
    {
        private IFuncionarioApp _rep;

        public HomeController(IFuncionarioApp rep)
        {
            _rep = rep;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Funcionario()
        {
            var funcsViewModel = new List<FuncionarioViewModel>();
            //List<Funcionario> data = new List<Funcionario>();
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44315");
                MediaTypeWithQualityHeaderValue contentType = new MediaTypeWithQualityHeaderValue("application/json");
                client.DefaultRequestHeaders.Accept.Add(contentType);
                HttpResponseMessage response = client.GetAsync("/api/Funcionario/Listar").Result;
                string stringData = response.Content.ReadAsStringAsync().Result;
                List<Funcionario> data = JsonConvert.DeserializeObject<List<Funcionario>>(stringData);
                //return View(data);

                foreach (var item in data)
                {
                    var funcViewModel = new FuncionarioViewModel();

                    funcViewModel.IdFuncionario = item.IdFuncionario;
                    funcViewModel.Nome = item.Nome;
                    funcViewModel.Cpf = item.Cpf;
                    funcViewModel.Rg = item.Rg;
                    funcViewModel.Endereco = item.Endereco;
                    funcViewModel.Cep = item.Cep;
                    funcViewModel.Cidade = item.Cidade;
                    funcViewModel.Estado = item.Estado;
                    funcViewModel.Pais = item.Pais;
                    funcViewModel.IdSupervisor = item.IdSupervisor;
                    funcViewModel.IdDepartamento = item.IdDepartamento;
                    funcViewModel.IdCargo = item.IdCargo;

                    funcsViewModel.Add(funcViewModel);
                }

                return View(funcsViewModel);
            }



            //try
            //{
            //    var funcsViewModel = new List<FuncionarioViewModel>();
            //    var funcionario = await _rep.Get();

            //    foreach (var item in funcionario)
            //    {
            //        var funcViewModel = new FuncionarioViewModel();

            //        funcViewModel.IdFuncionario = item.IdFuncionario;
            //        funcViewModel.Nome = item.Nome;
            //        funcViewModel.Cpf = item.Cpf;
            //        funcViewModel.Rg = item.Rg;
            //        funcViewModel.Endereco = item.Endereco;
            //        funcViewModel.Cep = item.Cep;
            //        funcViewModel.Cidade = item.Cidade;
            //        funcViewModel.Estado = item.Estado;
            //        funcViewModel.Pais = item.Pais;
            //        funcViewModel.IdSupervisor = item.IdSupervisor;
            //        funcViewModel.IdDepartamento = item.IdDepartamento;
            //        funcViewModel.IdCargo = item.IdCargo;

            //        funcsViewModel.Add(funcViewModel);
            //    }
            //    return View(funcsViewModel);
            //}
            //catch (Exception ex)
            //{
            //    throw;
            //}
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
