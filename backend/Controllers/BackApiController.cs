using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace backend.Controllers {
	[ApiController]
	[Route ("[controller]")]
	public class BackApiController: ControllerBase {
		private static readonly string[] Summaries = new[]
		{
			"Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
		};

		private readonly ILogger<BackApiController> _logger;

		public BackApiController (ILogger<BackApiController> logger) {
			_logger = logger;
		}

		[HttpGet]
		public string Get () {
			return "the msg return from backend";
		}
	}
}
