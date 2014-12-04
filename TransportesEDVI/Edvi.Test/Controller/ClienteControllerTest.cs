using System.Collections.Generic;
using Edvi.Web.Controllers;
using Edvi.Interfaces.Service;
using Edvi.Models.Model;
using Edvi.Services.Service;
//using Edvi.Validations.validation;
using Edvi.Interfaces.Validador;
using Moq;
using NUnit.Framework;
using System.Web.Mvc;
namespace Edvi.Test.Controller
{
    [TestFixture]
    public class ClienteControllerTest
    {
        [Test]
        public void TestIndexReturnViewIsOk()
        {
            //Arrange
            var mock = new Mock<IClienteService>();
            var mockvalidacion = new Mock<Ivalidador>();
            //mock.Setup(x => x.All()).Returns(new List<Cliente>());
            var controller = new ClienteController(mock.Object,mockvalidacion.Object);

            // Act
            var view = controller.IndexCliente();

            //Assert
            //mock.Verify(x => x.All(), Times.Once);
            //AssertViewsWithModel(view, "Index");
            Assert.IsNotNull(view);
            
        }

        [Test]
        public void TestAddReturnViewIsOk()
        {
            var controller = new ClienteController(null,null);
           

            var view = controller.Create() as ViewResult;

            AssertViewWithoutModel(view, "Create");
        }


        [Test]
        public void TestUpdateReturnViewIsOk()
        {
            var controller = new ClienteController(null,null);

            var view = controller.Update() as ViewResult;

            AssertViewWithoutModel(view, "Update");
        }

        [Test]
        public void TestRemoveReturnViewIsOk()
        {
            var controller = new ClienteController(null,null);

            var view = controller.Remove() as ViewResult;

            AssertViewWithoutModel(view, "Remove");
        }

        [Test]
        public void TestValidationReturnViewCreate()
        {
            var mock = new Mock<IClienteService>();
            var mockValidacion = new Mock<Ivalidador>();

            var controller = new ClienteController(mock.Object,mockValidacion.Object);

            var view = controller.Create(new Cliente()) as ViewResult;
            var valido = controller.CreateValidado(new Cliente()) as ViewResult;

            AssertViewsWithModel(view, "Create");
            Assert.IsInstanceOf(typeof(Cliente), view.Model);
        }


        private void AssertViewsWithModel(ViewResult view, string viewName)
        {
            Assert.IsNotNull(view, "Vista no puede ser nulo");
            Assert.AreEqual(viewName, view.ViewName);
            Assert.IsNotNull(view.Model);
        }

        private void AssertViewWithoutModel(ViewResult view, string viewName)
        {
            Assert.IsNotNull(view);
            Assert.AreEqual(viewName, view.ViewName);
            Assert.IsNull(view.Model);
        }
    }
}
