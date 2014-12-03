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
    public class RutaController:Controller
    {
          private readonly IRutaService service;
          public RutaController(IRutaService service)
        {
            this.service = service;
        }

          [HttpGet]
          public ViewResult IndexRuta()
          {

              return View("IndexRuta", service.AllRuta());
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
          public ActionResult Create(Ruta ruta)
          {

              //ValidateCreatePost(post);
              if (ModelState.IsValid)
              {
                  service.AddRuta(ruta);
                  return RedirectToAction("IndexRuta");
              }
              return View("create", ruta);
          }

    }
}