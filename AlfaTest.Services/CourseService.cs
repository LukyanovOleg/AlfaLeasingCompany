using System;
using System.Net;
using System.Text;

namespace AlfaTest.Services
{
    public class CourseService
	{
		private const string _url = @"https://www.cbr-xml-daily.ru/daily_json.js";

		public string LoadJson()
		{
			using (WebClient webClient = new WebClient())
			{
				webClient.Encoding = Encoding.UTF8;
				var json = webClient.DownloadString(_url);


				return json;
			}
		}
	}
}
