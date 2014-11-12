using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web.UI.WebControls;
using Edvi.Interfaces.Service;
using System.Web.Mvc;
using Edvi.Models.Model;
using Edvi.Services.Service;
namespace Edvi.Web.Controllers
{
    public class GuiaRemisionController:Controller
    {
          private readonly IGuiaRemisionService service;
          public GuiaRemisionController(IGuiaRemisionService service)
        {
            this.service = service;
        }
        
        [HttpGet]
          public ViewResult Index()
          {
              return View("IndexGuiaRemision");
          }
          [HttpGet]
          public ActionResult Create()
          {
              return View("Create");
          }

          [HttpPost]
          public ActionResult Create(GuiaRemision guiaRemision)
          {

              //ValidateCreatePost(post);
              if (ModelState.IsValid)
              {
                  service.AddGuiaRemision(guiaRemision);
                  return RedirectToAction("Index");
              }
              return View("create", guiaRemision);
          }
       

    }
}