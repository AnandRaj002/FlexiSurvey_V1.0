using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace FlexiSurvey_V1._0.Controllers
{
    public class CampaignSurveyController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
