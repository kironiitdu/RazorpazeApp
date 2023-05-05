using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.Extensions.Logging;
using RazorpazeApp.Pages;


namespace RazorpageApp.Test
{
    

    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void UnitTestProject()
        {

            // Arrange
            var logger = new LoggerFactory().CreateLogger<IndexModel>();

            var modelMetadataProvider = new EmptyModelMetadataProvider();
            //Creating View data instance
            var viewData = new ViewDataDictionary(modelMetadataProvider, new ModelStateDictionary());
            var pageModel = new IndexModel(logger)
            {
                PageContext = new PageContext
                {
                    ViewData = viewData
                },
                MetadataProvider = modelMetadataProvider,
            };
            

            // Act
            pageModel.OnGet();
            string title = pageModel.Title!;

            // Assert
            Assert.IsNotNull(title);
            Assert.AreEqual("Home page", title);
        }
    }
}