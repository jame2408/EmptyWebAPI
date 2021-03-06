// <copyright file="ProductsControllerTest.cs">Copyright ©  2016</copyright>
using System;
using System.Net.Http;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NorthwindDb.Controllers;

namespace NorthwindDb.Controllers.Tests
{
    /// <summary>此類別包含 ProductsController 的參數化單元測試</summary>
    [PexClass(typeof(ProductsController))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class ProductsControllerTest
    {
        /// <summary>GetProducts(Int32) 的測試虛設常式</summary>
        [PexMethod]
        public HttpResponseMessage GetProductsTest([PexAssumeUnderTest]ProductsController target, int id)
        {
            HttpResponseMessage result = target.GetProducts(id);
            return result;
            // TODO: 將判斷提示加入 方法 ProductsControllerTest.GetProductsTest(ProductsController, Int32)
        }
    }
}
