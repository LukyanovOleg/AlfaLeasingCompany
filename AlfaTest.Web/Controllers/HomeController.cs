using System;

using System.Web.Mvc;
using AlfaTest.Services;

namespace AlfaTest.Web.Controllers
{
	public class HomeController : Controller
	{
		private CourseService _service;
		public HomeController()
		{
			_service = new CourseService();
		}

		public ActionResult Index()
		{
			return View();
		}

		[HttpPost]
		public string LoadData()
		{
			var json = _service.LoadJson();

			return json;
		}
	}
}