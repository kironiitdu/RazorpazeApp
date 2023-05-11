using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Routing;
using RazorpazeApp.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorpageApp.Test
{
    [TestClass]
    public class IndexTest
    {
        [TestMethod]
        public void GivenPage_WhenLoad_TitleOfPageIsRight()
        {
            // Arrange
            var modelMetadataProvider = new EmptyModelMetadataProvider();

            //Creating View data instance
            var viewData = new ViewDataDictionary(modelMetadataProvider, new ModelStateDictionary());
            //Binding viewData in page model
            var indexModel = new IndexModel()
            {
                PageContext = new PageContext
                {
                    ViewData = viewData
                },
                MetadataProvider = modelMetadataProvider,
            };


            // Act
            indexModel.OnGet();
            var result = (string)indexModel.ViewData["Title"]!;

            // Assert
            Assert.AreEqual("Page d'accueil", result);
        }
    }
}
