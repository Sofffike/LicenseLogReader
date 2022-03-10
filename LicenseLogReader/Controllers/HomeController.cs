using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using LicenseLogReader.Models;
using System.Threading.Tasks;
//using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore;
using System.Collections.Generic;

namespace LicenseLogReader.Controllers
{

    public class HomeController : Controller
    {

        AdmContext db;
        public HomeController(AdmContext context)
        {
            db = context;
        }


        //заполнение автокомплита
        [HttpGet("search")]
        public async Task<IActionResult> Search()
        {
            try
            {
                string term = HttpContext.Request.Query["term"].ToString();
                var names = db.TsqlLicence.Where(p => p.Inn.Contains(term)).Select(p => p.Inn).ToList();
                return Ok(names);
            }
            catch
            {
                return BadRequest();
            }
        }

        public ActionResult Index(uint? inn) 
        {

            AdmContext db = new AdmContext();
            var unification = db.TsqlLicence.Join(db.TsqlLog,
                u => u.Inn,
                c => c.Inn,
                (u, c) => new TsqlListViewModel
                {
                    Inn = u.Inn,
                    OrgName = u.OrgName,
                    ChangeTime = c.ChangeTime,
                    LogText = c.LogText

                });


            if (inn != 0 && inn != null)
            {
                var tsqlsort = unification.Where(p => p.Inn == Convert.ToString(inn) || p.Inn.Contains(Convert.ToString(inn))).OrderByDescending(p=>p.ChangeTime).ToList();
                ViewBag.Inn = inn;
                ViewBag.Mass = tsqlsort;
            }
            else
            {
                //var mas = unification.ToList();
                //ViewBag.Mass = unification.ToList();
                ViewBag.Mass = "";
            }

            return View();

        }


    }
}