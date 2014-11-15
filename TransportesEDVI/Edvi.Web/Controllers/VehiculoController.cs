﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web.UI.WebControls;
using Edvi.Interfaces.Service;
using System.Web.Mvc;
using Edvi.Models.Model;
using Edvi.Services.Service;
using Edvi.Validations.validation;

namespace Edvi.Web.Controllers
{
    public class VehiculoController:Controller
    {
          private readonly IVehiculoService service;
          public VehiculoController(IVehiculoService service)
        {
            this.service = service;
        }
          //private readonly Ivalidador validador;
          //public VehiculoController(Ivalidador validador)
          //{
          //    this.validador = validador;
          //}

          [HttpGet]
          public ViewResult Index()
          {

              return View("IndexVehiculo");
          }

          [HttpGet]
          public ActionResult Create()
          {
              return View("Create");
          }

          [HttpPost]
          public ActionResult Create(Vehiculo vehiculo)
          {

              //ValidateCreatePost(post);

              if (ModelState.IsValid)//validador.ValidarVehiculo(vehiculo)
              {
                  service.AddVehiculo(vehiculo);
                  return RedirectToAction("Index");
              }
              return View("create", vehiculo);
          }


    }
}