using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading.Tasks;
using CityTowerServer.BLL.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using Microsoft.Extensions.Logging;

namespace CityTowerServer.API.Controllers
{
    public class ValuesController : Controller
    {
        BinaryFormatter formatter = new BinaryFormatter();
        private INewsCategoryListService NewsCategoryListService;
        private readonly ILogger _logger;
        private readonly IStringLocalizer<ValuesController> _localizer;

        public ValuesController(INewsCategoryListService NewsCategoryListService, ILogger<ValuesController> logger, IStringLocalizer<ValuesController> localizer)
        {
            this.NewsCategoryListService = NewsCategoryListService;
            _logger = logger;
            _localizer = localizer;
        }
   
        [HttpGet]
        [Route("api/[controller]/listofnews")]
        public IActionResult GetListOfNews()
        {
            var ListOfNews = NewsCategoryListService.GetListOfCategoryNews();
            using (FileStream fs = new FileStream("News.dat", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, ListOfNews);
                Debug.WriteLine("Объект сериализован");
            }

            _logger.LogInformation(_localizer["Information"].Value, ListOfNews);

            if (ListOfNews == null)
                return NotFound();
            else
                return Ok(ListOfNews);
        }
    }
}
