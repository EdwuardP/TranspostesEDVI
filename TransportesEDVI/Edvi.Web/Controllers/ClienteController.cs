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
            return View("IndexCliente");
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View("Create");
        }

        public ActionResult Update()
        {
            return View("Update");
        }

        public ActionResult Remove()
        {
            return View("Remove");
        }
        [HttpPost]
        public ActionResult Create(Cliente cliente)
        {

            //ValidateCreatePost(post);
            if (ModelState.IsValid)
            {
                service.AddCliente(cliente);
                return RedirectToAction("Index");
            }
            return View("create", cliente);
        }

        public void Validar(Cliente cliente)
        {
            if(cliente.Ruc.Length!=11) ModelState.AddModelError("Ruc","Debe ser 11 digitos");

            //inyeccion de modelstate a un diccionario traerlo de otro lugar Validador.validar se inyecta como un service 
            //Private readonly validador, moquear clase validador, interface Ivalidador  
            //Test unitario necesita a los 2 
            //instanciar clase mandar objeto y esperar true objeto false placa vehiculo

          
        }

     }
}