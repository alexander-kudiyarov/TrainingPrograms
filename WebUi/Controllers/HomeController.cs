using Core.Bll.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace WebUi.Controllers
{
    public class HomeController : Controller
    {
        private readonly ITrainingProgramLogic _logic;

        public HomeController(ITrainingProgramLogic logic)
        {
            _logic = logic;
        }

        public IActionResult Index()
        {
            var result = _logic.Get();
            return View(result);
        }

        public IActionResult Program(string type)
        {
            var result = _logic.Get(type);
            return View(result);
        }

        public IActionResult Session(string type, int session)
        {
            var result = _logic.Get(type, session);
            return View(result);
        }
    }
}