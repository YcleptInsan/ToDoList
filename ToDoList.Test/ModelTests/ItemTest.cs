using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDoList.Models;
using Xunit;


namespace ToDoList.Test
{
    public class ItemTest
    {
        [Fact]
        public void GetDescriptionTest()
        {
            var item = new Item();

            item.Description = "Wash the dog";

            var result = item.Description; 

            Assert.Equal("Wash the dog", result);
        }
    }
}
