using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VibraKimWeb.BLL.Repositories;
using VibraKimWeb.BOL.Entities;

namespace KubraKayaalp.Controllers
{
    public class AlisVerisController : Controller
    {
        Repository<Urun> RepoUrun = new Repository<Urun>();
        // GET: AlisVeris
        public ActionResult Index()
        {
            return View(RepoUrun.GetAll().ToList());
        }

        public ActionResult Detay(int c)
        {
            return View(RepoUrun.GetAll().FirstOrDefault(f => f.ID == c));
        }
    }
}