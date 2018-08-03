using System;
using System.Collections.Generic;

namespace CityTowerServer.DAL.Models
{
    public partial class Places
    {
        public Places()
        {
            CommentsPlaces = new HashSet<CommentsPlaces>();
        }

        public int PlacesId { get; set; }
        public string PlacesTema { get; set; }
        public string PlacesBody { get; set; }
        public DateTime PlacesDate { get; set; }
        public DateTime PlacesStartDate { get; set; }
        public double? PlacesRating { get; set; }
        public int Uid { get; set; }
        public int CityId { get; set; }
        public int CountryId { get; set; }
        public int PlacesCategoryId { get; set; }
        public int? PlacesLike { get; set; }
        public int? PlacesDislike { get; set; }

        public CityList City { get; set; }
        public CountryList Country { get; set; }
        public PlacesCategoryList PlacesCategory { get; set; }
        public Users U { get; set; }
        public ICollection<CommentsPlaces> CommentsPlaces { get; set; }
    }
}
