﻿using System.Collections.Generic;
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
    public class ClienteControllerTest
    {
        [Test]
        public void TestIndexReturnViewIsOk()
        {
            //Arrange
            var mock = new Mock<IClienteService>();
            //mock.Setup(x => x.All()).Returns(new List<Cliente>());
            var controller = new ClienteController(mock.Object);

            // Act
            var view = controller.Index();

            //Assert
            //mock.Verify(x => x.All(), Times.Once);
            //AssertViewsWithModel(view, "Index");
            Assert.IsNotNull(view);
            
        }
    }
}
