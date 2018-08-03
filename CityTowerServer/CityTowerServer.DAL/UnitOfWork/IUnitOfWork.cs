using CityTowerServer.DAL.Models;
using CityTowerServer.DAL.Repository;
using System;

namespace CityTowerServer.DAL.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        IGenericRepository<NewsCategoryList> NewsRepository { get; }
        void Save();
    }
}
