﻿using System.Text;
using System.Web.Mvc;
using MaterialCMS.Settings;

namespace MaterialCMS.Website.Controllers
{
    public class SEOController : MaterialCMSUIController
    {
        private readonly SEOSettings _seoSettings;

        public SEOController(SEOSettings seoSettings)
        {
            _seoSettings = seoSettings;
        }

        public ActionResult Robots()
        {
            if (CurrentRequestData.CurrentContext.Request.Url != null &&
                CurrentRequestData.CurrentContext.Request.Url.Host == CurrentRequestData.CurrentSite.StagingUrl)
            {
                return Content(_seoSettings.RobotsTextStaging, "text/plain", Encoding.UTF8);
            }
            return Content(_seoSettings.RobotsText, "text/plain", Encoding.UTF8);
        }
    }
}