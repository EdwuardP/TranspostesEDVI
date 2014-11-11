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
    public class VehiculoServiceTest
    {
        private Mock<Databases> databaseMock;

        [SetUp]
        public void SetUp()
        {
            //  Arrange 
            var db = VehiculoFakeDB();
            var mockDbset = new Mock<IDbSet<Vehiculo>>();
            mockDbset.Setup(x => x.Provider).Returns(db.Provider);
            mockDbset.Setup(x => x.Expression).Returns(db.Expression);
            mockDbset.Setup(x => x.ElementType).Returns(db.ElementType);
            mockDbset.Setup(x => x.GetEnumerator()).Returns(db.GetEnumerator);
            databaseMock = new Mock<Databases>();
            databaseMock.Setup(x => x.Vehiculos).Returns(mockDbset.Object);
        }

        [Test]
        public void TestAddNewVehiculo()
        {

            var service = new VehiculoService(databaseMock.Object);

            service.AddVehiculo(new Vehiculo { Id = 4, PlacaVehiculo = "123456" ,CargaBruta = 4000});
        }
        private IQueryable<Vehiculo> VehiculoFakeDB()
        {
            return new List<Vehiculo>
            {
                new Vehiculo { Id = 1, PlacaVehiculo = "123456" ,CargaBruta = 1000},
                new Vehiculo { Id = 2, PlacaVehiculo = "234567" ,CargaBruta = 2000},
                new Vehiculo { Id = 3, PlacaVehiculo = "345678" ,CargaBruta = 3000}
            }.AsQueryable();
        }
    }
}
