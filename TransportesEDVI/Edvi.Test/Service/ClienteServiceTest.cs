using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using Edvi.Services.Service;
using Edvi.Models.Model;
using Moq;
using System.Data.Entity;
using Edvi.DB.DB;

namespace Edvi.Test.Service
{
    [TestFixture]
    public class ClienteServiceTest
    {
        private Mock<Databases> databaseMock;

        [SetUp]
        public void SetUp()
        {
            //  Arrange 
            var db = ClienteFakeDB();
            var mockDbset = new Mock<IDbSet<Cliente>>();
            mockDbset.Setup(x => x.Provider).Returns(db.Provider);
            mockDbset.Setup(x => x.Expression).Returns(db.Expression);
            mockDbset.Setup(x => x.ElementType).Returns(db.ElementType);
            mockDbset.Setup(x => x.GetEnumerator()).Returns(db.GetEnumerator);
            //mock Database
            databaseMock = new Mock<Databases>();
            databaseMock.Setup(x => x.Clientes).Returns(mockDbset.Object);
        }

        [Test]
        public void TestAddNewClient()
        {

            var service = new ClienteService(databaseMock.Object);

            service.AddCliente(new Cliente {Id = 4, Ruc = "10702078530", RazSocial = "Tiger SA" });
        }
        private IQueryable<Cliente> ClienteFakeDB()
        {
            return new List<Cliente>
            {
                new Cliente { Id = 1, Ruc = "10702078500", RazSocial = "Pereda SA",Direccion = "Jr PSA 123", Telefono = "962739511"},
                new Cliente { Id = 2, Ruc = "10702078510", RazSocial = "Rabanal SA",Direccion = "Jr RSA 456", Telefono = "962739512"},
                new Cliente { Id = 3, Ruc = "10702078520", RazSocial = "Marin SA",Direccion = "Jr MSA 789", Telefono = "962739513"},
            }.AsQueryable();
        }
    }
}


