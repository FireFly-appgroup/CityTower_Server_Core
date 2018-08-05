using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CityTowerServer.BLL.Services;
using Microsoft.AspNetCore.Mvc;

namespace CityTowerServer.API.Controllers
{
    public class ValuesController : Controller
    {
        private INewsCategoryListService NewsCategoryListService;

        public ValuesController(INewsCategoryListService NewsCategoryListService)
        {
            this.NewsCategoryListService = NewsCategoryListService;
        }
   
        [HttpGet]
        [Route("api/[controller]/listofnews")]
        public IActionResult GetListOfNews()
        {
            var ListOfNews = NewsCategoryListService.GetListOfCategoryNews();
            if (ListOfNews == null)
                return NotFound();
            else
                return Ok(ListOfNews);
        }
    }
}
