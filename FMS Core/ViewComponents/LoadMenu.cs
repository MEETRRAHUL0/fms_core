using FMS_Core.Helper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FMS_Core.ViewComponents
{
    public class MenuBar : ViewComponent
    {
        

        public IViewComponentResult Invoke()
        {
            MenuHelper _articleService = new MenuHelper();

            var articles = _articleService.LoadMenu();
            return View(articles.menuItems);
        }
    }
}
