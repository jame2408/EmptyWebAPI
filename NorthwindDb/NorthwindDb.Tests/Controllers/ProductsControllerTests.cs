using Microsoft.VisualStudio.TestTools.UnitTesting;
using NorthwindDb.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NorthwindDb.Models;
using RestSharp;

namespace NorthwindDb.Controllers.Tests
{
    [TestClass()]
    public class ProductsControllerTests
    {
        [TestMethod()]
        public void GetProductsTest()
        {            
            // arrange
            var expected = 1;

            var client = new RestClient("http://localhost:9735/api/products/1");
            var request = new RestRequest(Method.GET);
            request.AddHeader("postman-token", "350c30d9-33dc-2a75-e6ca-824fecdd599d");
            request.AddHeader("cache-control", "no-cache");

            // act
            // Execute<T> 執自動進行反序列化
            var response = client.Execute<Products>(request);
            // assert
            // response.Data. <-- 自己點點看，強型別才有辦法驗證
            Assert.AreEqual(expected, response.Data.ProductID);
        }

        public partial class Products
        {
            public int ProductID { get; set; }

            public string ProductName { get; set; }

            public int? SupplierID { get; set; }

            public int? CategoryID { get; set; }

            public string QuantityPerUnit { get; set; }

            public decimal? UnitPrice { get; set; }

            public short? UnitsInStock { get; set; }

            public short? UnitsOnOrder { get; set; }

            public short? ReorderLevel { get; set; }

            public bool Discontinued { get; set; }
        }
    }
}