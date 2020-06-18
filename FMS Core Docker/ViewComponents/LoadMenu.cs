using FMS_Core.Helper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using FMS_Core.Models;

namespace FMS_Core.ViewComponents
{
    public class MenuBar : ViewComponent
    {
        public static MenuEntity MenuEntity;

        public IViewComponentResult Invoke()
        {
            MenuHelper _articleService = new MenuHelper();

            if (MenuEntity == null)
            {
                MenuEntity = new MenuEntity();
                MenuEntity = _articleService.LoadMenu();
            }

            return View(MenuEntity.menuItems);
        }
    }
}
