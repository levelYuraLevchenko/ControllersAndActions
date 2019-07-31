﻿using System.Web.Mvc;
using ControllersAndActions.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ControllersAndActions.Tests
{
    [TestClass]
    public class ActionTests
    {
        [TestMethod]
        public void ControllerTest()
        {
            // Организация - создание контроллера
            ExampleController target = new ExampleController();
            // Действие - вызов метода действия
            ViewResult result = target.Index();
            // Утверждение - проверка результата
            Assert.AreEqual("", result.ViewName);
        }
    }
}