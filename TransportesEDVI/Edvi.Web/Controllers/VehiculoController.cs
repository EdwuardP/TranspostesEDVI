using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web.UI.WebControls;
using Edvi.Interfaces.Service;
using System.Web.Mvc;
using Edvi.Models.Model;
using Edvi.Services.Service;

namespace Edvi.Web.Controllers
{
    public class VehiculoController:Controller
    {
          private readonly IVehiculoService service;
          public VehiculoController(IVehiculoService service)
        {
            this.service = service;
        }

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

          public ActionResult Update()
          {
              return View("Update");
          }

          public ActionResult Remove()
          {
              return View("Remove");
          }

          [HttpPost]
          public ActionResult Create(Vehiculo vehiculo)
          {

              //ValidateCreatePost(post);
              if (ModelState.IsValid)
              {
                  service.AddVehiculo(vehiculo);
                  return RedirectToAction("Index");
              }
              return View("create", vehiculo);
          }


    }
}