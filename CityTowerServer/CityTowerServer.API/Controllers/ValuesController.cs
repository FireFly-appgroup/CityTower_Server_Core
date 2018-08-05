using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CityTowerServer.BLL.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CityTowerServer.API.Controllers
{
    public class ValuesController : Controller
    {
        private INewsCategoryListService NewsCategoryListService;
        private readonly ILogger _logger;

        public ValuesController(INewsCategoryListService NewsCategoryListService, ILogger<ValuesController> logger)
        {
            this.NewsCategoryListService = NewsCategoryListService;
            _logger = logger;
        }
   
        [HttpGet]
        [Route("api/[controller]/listofnews")]
        public IActionResult GetListOfNews()
        {
            var ListOfNews = NewsCategoryListService.GetListOfCategoryNews();
            _logger.LogInformation("Information", ListOfNews);
            if (ListOfNews == null)
                return NotFound();
            else
                return Ok(ListOfNews);
        }
    }
}
