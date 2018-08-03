using System;
using CityTowerServer.DAL.Models;
using CityTowerServer.DAL.Repository;

namespace CityTowerServer.DAL.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly CityTower_bdContext _context;
        private IGenericRepository<NewsCategoryList> newsRepository;

        public UnitOfWork()
        {
            this._context = new CityTower_bdContext();
        }

        public IGenericRepository<NewsCategoryList> NewsRepository
        {
            get { return this.newsRepository ?? (this.newsRepository = new GenericRepository<NewsCategoryList>(_context)); }
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}