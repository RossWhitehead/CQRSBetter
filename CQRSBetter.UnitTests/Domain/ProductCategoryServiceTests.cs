using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using CQRSBetter.CommandStack.Handlers;
using CQRSBetter.Domain.Services;
using NodaTime;
using Ploeh.AutoFixture;
using CQRSBetter.Domain.DomainModel;
using CQRSBetter.Infrastructure.Domain;

namespace CQRSBetter.UnitTests.Domain
{
    [TestClass]
    public class ProductCategoryServiceTests
    {
        [TestMethod]
        public void AddOrUpdateProductCategorySucceeds()
        {
            // Arrange
            var mockHandler = new Mock<IProductCategoryCommandHandler>();
            var mockClock = new Mock<IClock>();
            var expectedDate = DateTime.Now;
            mockClock.Setup(c => c.Now.ToDateTimeUtc()).Returns(expectedDate);
            var fixture = new Fixture();
            var productCategory = fixture.Create<ProductCategory>();

            // Act
            //var service = new ProductCategoryService(mockClock.Object, mockHandler.Object);
            //DomainResult result = service.AddOrUpdateProductCategory(productCategory).Result;
    
            // Assert

        }
    }
}
