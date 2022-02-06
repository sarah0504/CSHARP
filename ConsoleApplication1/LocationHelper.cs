using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

using System.Net.Http;

namespace ConsoleApplication1
{
    public class LocationHelper
    {
		private static string APIKey = "TN7sj2YJBhXWqPIa45ST~STJrrn56KcmoCaZcI2Qv0g~AjI-ZCd4XVm0TkDD6L8p-D22bA47fArrmlGUn06Gf305TOAezZ2UpQ7oEqJ4UVto";


		public static async Task<(double, double)> GetLatLong(string address)
		{
			using (var client = new HttpClient())
			{
				var response = await client.GetAsync("http://dev.virtualearth.net/REST/v1/Locations?key=" + APIKey + "&query=" + address);
				var content = response.Content;

				var result = await content.ReadAsStringAsync();
				var json = JObject.Parse(result);

				var resourceSets = json["resourceSets"] as JArray;
				var resources = resourceSets[0]["resources"];

				
				var coordinates = resources[0]["point"]["coordinates"] as JArray;
				return ((double)coordinates[0], (double)coordinates[1]); //les coordonnes 
			}
		}
	}
}
