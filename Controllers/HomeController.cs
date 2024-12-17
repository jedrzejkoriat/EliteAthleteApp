using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using EliteAthleteApp.Models;
using Microsoft.AspNetCore.Identity.UI.Services;
using EliteAthleteApp.Contracts;
using Microsoft.AspNetCore.Identity;
using EliteAthleteApp.Data;
using EliteAthleteApp.Models.Home;
using AutoMapper;
using EliteAthleteApp.Models.User;

namespace EliteAthleteApp.Controllers
{
	public class HomeController : Controller
	{
		private readonly IUserChartService userChartService;
		private readonly UserManager<User> userManager;
		private readonly IHttpContextAccessor httpContextAccessor;
		private readonly IMapper mapper;
		private readonly ITrainingPlanRepository trainingPlanRepository;
		private readonly IUserRepository userRepository;

		public HomeController(IUserRepository userRepository)
		{
			this.userRepository = userRepository;
		}

		public async Task<IActionResult> Index()
		{
			return View(await userRepository.GetHomeIndexVMAsync());
		}

		public IActionResult Privacy()
		{
			return View();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}
