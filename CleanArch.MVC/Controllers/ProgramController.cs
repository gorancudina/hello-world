using CleanArch.Application.Interfaces;
using CleanArch.Application.Services;
using CleanArch.Application.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CleanArch.MVC.Controllers
{
   [Authorize]
    public class ProgramController : Controller
    {
        private IProgramServices _programService;

        public ProgramController(IProgramServices programService)
        {
            _programService = programService;
        }

        public IActionResult Index()
        {
            ProgramViewModel model = _programService.GetPrograms();
            return View(model);
        }
    }
}