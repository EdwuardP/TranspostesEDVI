using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Edvi.Web.Controllers;
using Edvi.Interfaces.Service;
using Edvi.Models.Model;
using Edvi.Services.Service;
using Edvi.DB.DB;
using Moq;
using NUnit.Framework;
using System.Web.Mvc;
namespace Edvi.Test.Validation
{
    public class ClienteValidationTest
    {
        [Test]
        public void TestValidationFallaReturnViewCreate()
        {
            var modelState = new Mock<ModelStateDictionary>();

        }

    }
}
