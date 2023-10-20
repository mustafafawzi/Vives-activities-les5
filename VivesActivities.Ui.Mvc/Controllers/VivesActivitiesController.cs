using Microsoft.AspNetCore.Mvc;
using VivesActivities.Ui.Mvc.Core;

namespace VivesActivities.Ui.Mvc.Controllers
{
    public class VivesActivitiesController : Controller
    {
        private readonly Database _database;
        public VivesActivitiesController(Database database)
        {
            _database = database;
        }
        public IActionResult Index()
        {
            var activities = _database.Activities;
            return View(activities);
        }
    }
}
