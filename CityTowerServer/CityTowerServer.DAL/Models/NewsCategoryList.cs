using System;
using System.Collections.Generic;

namespace CityTowerServer.DAL.Models
{
    [Serializable]
    public partial class NewsCategoryList
    {
        public NewsCategoryList()
        {
            News = new HashSet<News>();
        }

        public int NewsCategoryId { get; set; }
        public string Category { get; set; }

        public ICollection<News> News { get; set; }
    }
}
