using CityAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityAPI.Store
{
    public class CitiesStore
    {
		public static CitiesStore Current { get; } = new CitiesStore();

		public List<CityModel> Cities { get; set; }

		public CitiesStore()
		{
			Cities = new List<CityModel>(){
				new CityModel()
				{
					Id=1,
					Name="New York City",
					Description="The one with that big park."
				},
				new CityModel()
				{
					Id=2,
					Name="Antwerp",
					Description="The one with the cathedral that was never really finished."
				},
				new CityModel()
				{
					Id=3,
					Name="Paris",
					Description="The one with that big tower."
				}
			};
		}
	}
}
