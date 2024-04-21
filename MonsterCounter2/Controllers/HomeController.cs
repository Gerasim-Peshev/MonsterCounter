using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MonsterCounter2.Data.Models;
using MonsterCounter2.Models;
using MonsterCounter2.Web.Models.MonsterFan;
using System.Diagnostics;
using MonsterCounter2.Services.MonsterFans;
using System.Security.Claims;
using MonsterCounter2.Services.Contract;

namespace MonsterCounter2.Controllers
{
    public class HomeController : Controller
    {
        private UserManager<MonsterFan> userManager;

        private readonly ILogger<HomeController> _logger;

        private readonly IMonsterFanService monsterFanService;

        private string UserId()
        {
            return User.FindFirstValue(ClaimTypes.NameIdentifier);
        }

        public HomeController(ILogger<HomeController> logger, IMonsterFanService service)
        {
            _logger = logger;
            this.monsterFanService = service;
        }

        public IActionResult Index()
        {
            if (User.Identity.IsAuthenticated)
            {
                return RedirectToAction("MonsterStats", "Home");
            }

            return View();
        }

        public async Task<IActionResult> MonsterStats()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> EditMonsterStats()
        {
            var userrr = await monsterFanService.GetMonsterFanByIdAsync(UserId());

            var modelToEdit = new EditModelView
            {
                NormalGreen = userrr.NormalGreen,
                NormalBlue = userrr.NormalBlue,
                TheDoctor = userrr.TheDoctor,
                BlueHamilton = userrr.BlueHamilton,
                RedHamilton = userrr.RedHamilton,
                NoSugarGreen = userrr.NoSugarGreen,
                NoSugarMango = userrr.NoSugarMango,
                Green = userrr.Green,
                Orange = userrr.Orange,
                NormalMango = userrr.NormalMango,
                Pink = userrr.Pink,
                PacificPunch = userrr.PacificPunch,
                Khaotic = userrr.Khaotic,
                Java = userrr.Java,
                JapanStrawberry = userrr.JapanStrawberry,
                Molet = userrr.Molet,
                Assault = userrr.Assault,
                White = userrr.White,
                Watermelon = userrr.Watermelon,
                Mixxd = userrr.Mixxd,
                Pinapple = userrr.Pinapple
            };

            return View(modelToEdit);
        }

        [HttpPost]
        public async Task<IActionResult> EditMonsterStats(EditModelView model)
        {
            var userrr = userManager.GetUserAsync(User).Result;

            

            await monsterFanService.EditMonsters(model.NormalGreen, model.NormalBlue, model.TheDoctor, model.BlueHamilton,
                                                 model.RedHamilton, model.NoSugarGreen, model.NoSugarMango,
                                                 model.NoSugarGreen, model.Orange, model.NormalMango, model.Pink,
                                                 model.PacificPunch, model.Khaotic, model.Java, model.JapanStrawberry,
                                                 model.Molet, model.Assault, model.White, model.Watermelon, model.Mixxd,
                                                 model.Pinapple, UserId());

            RedirectToAction("MonsterStats", "Home");

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}