using System;
using System.Collections.Generic;
using CityTowerServer.DAL.Models;

namespace CityTowerServer.BLL.Services
{
    interface INewsCategoryListService : IDisposable
    {
        IEnumerable<NewsCategoryList> GetListOfCategoryNews();
    }
}
