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
    public class RutaServiceTest
    {
        private Mock<Databases> databaseMock;

        [SetUp]
        public void SetUp()
        {
            //  Arrange 
            var db = RutaFakeDB();
            var mockDbset = new Mock<IDbSet<Ruta>>();
            mockDbset.Setup(x => x.Provider).Returns(db.Provider);
            mockDbset.Setup(x => x.Expression).Returns(db.Expression);
            mockDbset.Setup(x => x.ElementType).Returns(db.ElementType);
            mockDbset.Setup(x => x.GetEnumerator()).Returns(db.GetEnumerator);
            databaseMock = new Mock<Databases>();
            databaseMock.Setup(x => x.Rutas).Returns(mockDbset.Object);
        }

        [Test]
        public void TestAddNewRuta()
        {

            var service = new RutaService(databaseMock.Object);

            service.AddRuta(new Ruta { Id = 4, Origen = "Cajamarca", Destino = "Lima" });
        }
        private IQueryable<Ruta> RutaFakeDB()
        {
            return new List<Ruta>
            {
                new Ruta { Id = 1, Origen = "Cajamarca", Destino = "Trujillo" },
                new Ruta { Id = 2, Origen = "Cajamarca", Destino = "Chiclayo" },
                new Ruta { Id = 3, Origen = "Cajamarca", Destino = "Piura" }
            }.AsQueryable();
        }
    }
}
