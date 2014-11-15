﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using Edvi.Interfaces.Service;
using System.Web.Mvc;
using Edvi.Models.Model;
using Edvi.Services.Service;
//using Edvi.Validations.validation;
using Edvi.Interfaces.Validador;


namespace Edvi.Web.Controllers
{
    public class ClienteController:Controller
    {
        private readonly IClienteService service;
        private readonly Ivalidador validador;
        public ClienteController(IClienteService service, Ivalidador validador)
        {
            this.service = service;
            this.validador = validador;
        }

         //private readonly Ivalidador validador;
         //public ClienteController(Ivalidador validador)
         // {
         //     this.validador = validador;
         // }

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
        [HttpPost]
        public ActionResult CreateValidado(Cliente cliente)
        {

<<<<<<< HEAD
            //ValidateCreatePost(post);
            if (ModelState.IsValid)
            {
                validador.ValidarClinte(cliente);
                return RedirectToAction("Index");
            }
            return View("create", cliente);
=======
            //inyeccion de modelstate a un diccionario traerlo de otro lugar Validador.validar se inyecta como un service 
            //Private readonly validador, moquear clase validador, interface Ivalidador  
            //Test unitario necesita a los 2 
            //instanciar clase mandar objeto y esperar true objeto false placa vehiculo

          
>>>>>>> e1e2553897f70b54d9bc98da3c84cc0e80b4486f
        }

        //private void validador(Cliente cliente) 
        //{
        //    if(cliente.Ruc.Length!=11)
        //    {
        //        ModelState.AddModelError("Ruc","Ruta debe de ser 11 digitos");
        //    }
        //}

     }
}