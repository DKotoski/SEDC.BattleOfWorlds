using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using N2.Web.Mvc;
using N2.Web;
using N2;
using SEDC.BattleOfWorlds.Infrastructure.WebUI.Models;

namespace SEDC.BattleOfWorlds.Infrastructure.WebUI
{
    [Controls(typeof(LanguageIntersection))]
    public class LanguageIntersectionController : ContentController<LanguageIntersection>
    {
        public override ActionResult Index()
        {
            ContentItem language = Request.SelectLanguage(CurrentItem);
            if (language != null)
            {
                if (language.Url.StartsWith("http"))
                    return Redirect(language.Url);

                //if (language.Url != CurrentPage.Url)
                //	return Redirect(language.Url);

                return ViewPage(language);
            }

            if (CurrentItem.RedirectUrl != CurrentItem.Url)
                return Redirect(CurrentItem.RedirectUrl);

            return View(CurrentItem);
        }

    }
}
