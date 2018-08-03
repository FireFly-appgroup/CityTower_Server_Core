using System.Collections.Generic;
using CityTowerServer.DAL.Models;
using CityTowerServer.DAL.UnitOfWork;

namespace CityTowerServer.BLL.Services
{
    public class NewsCategoryListService : INewsCategoryListService
    {
        private readonly IUnitOfWork _unitOfWork;

        public NewsCategoryListService(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }

        public IEnumerable<NewsCategoryList> GetListOfCategoryNews()
        {
            return _unitOfWork.NewsRepository.GetAll();
        }

        public void Dispose()
        {
            _unitOfWork.Dispose();
        }
    }
}
