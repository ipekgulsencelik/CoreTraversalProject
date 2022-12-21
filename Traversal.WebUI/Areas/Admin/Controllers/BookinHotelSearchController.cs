using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using Traversal.WebUI.Areas.Admin.Models;

namespace Traversal.WebUI.Areas.Admin.Controllers
{
	[AllowAnonymous]
	[Area("Admin")]
    public class BookinHotelSearchController : Controller
    {
        public async Task<IActionResult> Index()
        {
			var client = new HttpClient();

			var request = new HttpRequestMessage
			{
				Method = HttpMethod.Get,
				RequestUri = new Uri("https://booking-com.p.rapidapi.com/v2/hotels/search?room_number=1&dest_type=city&order_by=popularity&dest_id=-1456928&locale=en-gb&checkin_date=2023-01-27&filter_by_currency=EUR&checkout_date=2023-01-28&adults_number=2&units=metric&children_ages=5%2C0&include_adjacency=true&categories_filter_ids=class%3A%3A2%2Cclass%3A%3A4%2Cfree_cancellation%3A%3A1&children_number=2&page_number=0"),
				Headers =
	{
		{ "X-RapidAPI-Key", "c5988f023cmsha58d03937bc09b2p19f8c7jsn49ecb893dc9e" },
		{ "X-RapidAPI-Host", "booking-com.p.rapidapi.com" },
	},
			};
			using (var response = await client.SendAsync(request))
			{
				response.EnsureSuccessStatusCode();
				var body = await response.Content.ReadAsStringAsync();

				var bodyReplace = body.Replace(".", "");

				var values = JsonConvert.DeserializeObject<BookingHotelSearchViewModel>(bodyReplace);

				return View(values.result);
			}
        }

		[HttpGet]
		public IActionResult GetCityDestinationID()
        {
			return View();
        }

		[HttpPost]
		public async Task<IActionResult> GetCityDestinationID(string city)
        {
			var client = new HttpClient();

			var request = new HttpRequestMessage
			{
				Method = HttpMethod.Get,
				RequestUri = new Uri($"https://booking-com.p.rapidapi.com/v1/hotels/locations?locale=en-gb&name={city}"),
				Headers =
	{
		{ "X-RapidAPI-Key", "c5988f023cmsha58d03937bc09b2p19f8c7jsn49ecb893dc9e" },
		{ "X-RapidAPI-Host", "booking-com.p.rapidapi.com" },
	},
			};
			using (var response = await client.SendAsync(request))
			{
				response.EnsureSuccessStatusCode();
				var body = await response.Content.ReadAsStringAsync();

				return View();
			}
		}
    }
}
