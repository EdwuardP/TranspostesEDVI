using System.Web.Mvc;
using Microsoft.Practices.Unity;
using Unity.Mvc4;
using Edvi.Interfaces.Service;
using Edvi.Interfaces.Validador;
using Edvi.Services.Service;
using Edvi.Validations.validation;

namespace Edvi.Web
{
  public static class Bootstrapper
  {
    public static IUnityContainer Initialise()
    {
      var container = BuildUnityContainer();

      DependencyResolver.SetResolver(new UnityDependencyResolver(container));

      return container;
    }

    private static IUnityContainer BuildUnityContainer()
    {
      var container = new UnityContainer();

      // register all your components with the container here
      // it is NOT necessary to register your controllers
        
      RegisterTypes(container);

      return container;
    }

    public static void RegisterTypes(IUnityContainer container)
    {
        container.RegisterType<IClienteService, ClienteService>();
        container.RegisterType<IRutaService, RutaService>();
        container.RegisterType<IGuiaRemisionService, GuiaRemisionService>();
        container.RegisterType<IVehiculoService, VehiculoService>();
        container.RegisterType<Ivalidador, Validaciones>();
     }
  }
}