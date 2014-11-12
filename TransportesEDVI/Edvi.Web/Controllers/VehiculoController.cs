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
              //view("IndexVehiculo");
              return null;
          }

          [HttpGet]
          public ActionResult Create()
          {
              return View("Create");
          }

    }
}