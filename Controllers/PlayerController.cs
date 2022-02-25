using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication29.Models;

namespace WebApplication29.Controllers
{
    public class PlayerController : Controller
    {
        // GET: Player
        public ActionResult Index()
        {
            List<Player> list = new List<Player>
            {
                new Player{PID =1,PName="Ram",PTeam="KKR"},
                 new Player{PID =2,PName="Sam",PTeam="KKR"},
            };
            return View();
        }
    }
}