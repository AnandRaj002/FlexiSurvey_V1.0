using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FlexiSurvey_V1._0.Models;
using Microsoft.AspNetCore.Mvc;

namespace FlexiSurvey_V1._0.Controllers
{
    public class StandaloneSurveyController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ViewDetails()
        {
            StandaloneSurveyModel modelVar = new StandaloneSurveyModel() { Id = 1, SurveyName = "Test Survey", CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow, IsActive = true };
            return View(modelVar);
        }

        public IActionResult FileBasedSave(StandaloneSurveyModel model)
        {
            return View(model);
        }

        public IActionResult FormBasedSave(StandaloneSurveyModel model)
        {
            return View(model);
        }
        
        public IActionResult LoadPartial()
        {
            return PartialView("AddQuestion");
        }
    }
}
