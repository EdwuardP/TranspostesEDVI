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
    public class GuiaRemisionServiceTest
    {
        private Mock<Databases> databaseMock;

        [SetUp]
        public void SetUp()
        {
            //  Arrange 
            var db = GuiaRemisionFakeDB();
            var mockDbset = new Mock<IDbSet<GuiaRemision>>();
            mockDbset.Setup(x => x.Provider).Returns(db.Provider);
            mockDbset.Setup(x => x.Expression).Returns(db.Expression);
            mockDbset.Setup(x => x.ElementType).Returns(db.ElementType);
            mockDbset.Setup(x => x.GetEnumerator()).Returns(db.GetEnumerator);
            //mock Database
            databaseMock = new Mock<Databases>();
            databaseMock.Setup(x => x.GuiaRemisions).Returns(mockDbset.Object);
        }

        [Test]
        public void TestAddNewGuia()
        {

            var service = new GuiaRemisionService(databaseMock.Object);

            service.AddGuiaRemision(new GuiaRemision { Id = 4, Nro = "4567",PesoTotal = 4000});
        }
        private IQueryable<GuiaRemision> GuiaRemisionFakeDB()
        {
            return new List<GuiaRemision>
            {
                new GuiaRemision { Id = 4, Nro = "1234",PesoTotal = 1000},
                new GuiaRemision { Id = 4, Nro = "2345",PesoTotal = 2000},
                new GuiaRemision { Id = 4, Nro = "3456",PesoTotal = 3000}
            }.AsQueryable();
        }
    }
}
