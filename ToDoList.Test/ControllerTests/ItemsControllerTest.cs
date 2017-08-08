using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using ToDoList.Controllers;
using ToDoList.Models;
using Xunit;

namespace ToDoList.Test.ControllerTests
{
    public class ItemsControllerTest
    {
        [Fact]
        public void Get_ViewResult_Index_Test()
        {
            ItemsController controller = new ItemsController();
            IActionResult actionResult = controller.Index();
            ViewResult indexView = new ItemsController().Index() as ViewResult;
            var result = indexView.ViewData.Model;

            Assert.IsType<List<Item>>(result);
        }
    }
}
