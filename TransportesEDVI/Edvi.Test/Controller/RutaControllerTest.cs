using System;
using System.Collections.Generic;
using Edvi.Web.Controllers;
using Edvi.Interfaces.Service;
using Edvi.Models.Model;
using Edvi.Services.Service;
using Moq;
using NUnit.Framework;
using System.Web.Mvc;

namespace Edvi.Test.Controller
{
    [TestFixture]
    public class RutaControllerTest
    {
        [Test]
        public void TestIndexReturnViewIsOk()
        {
            //Arrange
            var mock = new Mock<IRutaService>();
            //mock.Setup(x => x.All()).Returns(new List<Cliente>());
            var controller = new RutaController(mock.Object);

            // Act
            var view = controller.Index();

            //Assert
            //mock.Verify(x => x.All(), Times.Once);
            //AssertViewsWithModel(view, "Index");
            Assert.IsNotNull(view);
        }
        [Test]
        public void TestCreateReturnViewIsOk()
        {
            var controller = new RutaController(null);

            var view = controller.Create() as ViewResult;

            AssertViewWithoutModel(view, "Create");

        }

        [Test]
        public void TestPostValicacionFallaReturnViewCreate()
        {
            var mock = new Mock<IRutaService>();

            var controller = new RutaController(mock.Object);

            var view = controller.Create(new Ruta()) as ViewResult;

            AssertViewsWithModel(view, "create");
            Assert.IsInstanceOf(typeof(Ruta), view.Model);

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