using Microsoft.VisualStudio.TestTools.UnitTesting;
using CourseWorkClinic.Controllers;
using System.Web.Mvc;
using System.Configuration;
using System.Data.SqlClient;
using System;

namespace Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void EditViewModelNotNull()
        {
            // Arrange
            EditController controller = new EditController();

            // Act
            ViewResult result = controller.EditRecept(new Guid("104412ab-1a4b-410c-aa7a-2dfbe6c69bbb")) as ViewResult;

            // Assert
            Assert.IsNotNull(result.Model);
        }
        [TestMethod]
        public void ConnectionUserDataBaseTest()
        {
            var userConnectionString = ConfigurationManager.ConnectionStrings["ClinicEntities"].ConnectionString;

            var exceptionExist = false;
            var connectionExist = false;
            try
            {
                var connection = new SqlConnection(userConnectionString);
                connectionExist = true;
            }
            catch
            {
                exceptionExist = true;
            }

            Assert.AreNotEqual(exceptionExist, connectionExist);
        }
        [TestMethod]
        public void RedirectWhenNotLogged()
        {
            AdminController controller = new AdminController();

            // Act
            var result = controller.UserControl() as RedirectToRouteResult;

            // Assert
            Assert.AreEqual(result.RouteValues["action"], "Index");

        }


        //[TestMethod]
        //public void IndexViewEqualIndexCshtml()
        //{
        //    StoreController controller = new StoreController();

        //    ViewResult result = controller.Index() as ViewResult;

        //    Assert.AreEqual("Index", result.ViewName);
        //}

        //[TestMethod]
        //public void IndexStringInViewbag()
        //{
        //    StoreController controller = new StoreController();

        //    ViewResult result = controller.Index() as ViewResult;

        //    Assert.AreEqual("Hello world!", result.ViewBag.Message);
        //}
    }
}

