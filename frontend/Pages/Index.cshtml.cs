using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace frontend.Pages {
	public class IndexModel: PageModel {
		private readonly ILogger<IndexModel> _logger;
		public string BackendData { get; set; }

		public IndexModel (ILogger<IndexModel> logger) {
			_logger = logger;
		}

		public async Task OnGet () {
			try {
				var _uri = Startup.Configuration.GetServiceUri ("backend");
				using var _serviceProvider = new ServiceCollection().AddHttpClient().BuildServiceProvider();
				var _httpClientFactory = _serviceProvider.GetService<IHttpClientFactory>();
				using var _client = _httpClientFactory.CreateClient();
				using var responseMessage = await _client.GetAsync($"{_uri.Scheme}://{_uri.Host}:{_uri.Port}/BackApi");
				BackendData = await responseMessage.Content.ReadAsStringAsync ();
			} catch (Exception) {
				BackendData = "（未读取到数据）";
			}
		}
	}
}
