using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace App.Web.Controllers
{
	public class SourceCodeController : AppControllerBase
	{
		public SourceCodeController(IMapper mapper) : base(mapper)
		{
		}

		public IActionResult Index()
		{
			return View();
		}
	}
}
