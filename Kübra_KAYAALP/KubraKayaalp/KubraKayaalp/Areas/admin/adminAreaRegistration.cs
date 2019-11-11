﻿using System.Web.Mvc;

namespace KubraKayaalp.Areas.admin
{
    public class adminAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "admin";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "admin_default",
                "admin/{controller}/{action}/{id}",
                new { Controller="Home",action = "Index", id = UrlParameter.Optional },
                     new[] { "KubraKayaalp.Areas.admin.Controllers" }
            );
        }
    }
}