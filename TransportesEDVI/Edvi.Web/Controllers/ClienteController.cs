using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using Edvi.Interfaces.Service;
using System.Web.Mvc;
using Edvi.Models.Model;
using Edvi.Services.Service;
namespace Edvi.Web.Controllers
{
    public class ClienteController:Controller
    {
        private readonly IClienteService service;
        public ClienteController(IClienteService service)
        {
            this.service = service;
        }

        [HttpGet]
        public ViewResult Index()
        {
            return View("Index");
        }
    }
}