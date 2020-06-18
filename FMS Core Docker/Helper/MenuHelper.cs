using FMS_Core.Models;
using FMS_Core.Models.EFModels;
using System.Collections.Generic;
using System.Linq;

namespace FMS_Core.Helper
{
    public class MenuHelper
    {
        private readonly IQueryable<TblMenu> _menus;

        public MenuHelper()
        {
            FMSExpContext context = new FMSExpContext();
            _menus = context.TblMenu;
        }

        public MenuEntity LoadMenu()
        {
            MenuEntity MenuResponce = new MenuEntity();

            var _menu = _menus.Where(q => q.IsEnable != false).OrderBy(o => o.Ordinal).ToList();

            var menuItems = GenerateTree(_menu, _menu.First(q => q.ParentId == -1));

            MenuResponce.menuItems = menuItems.ToList();
            MenuResponce.associateId = "Test";

            return MenuResponce;
        }

        public static IList<MenuItem> GenerateTree(IEnumerable<TblMenu> collection, TblMenu rootItem)
        {
            IList<MenuItem> lst = new List<MenuItem>();

            var tblIEnumerable = collection as TblMenu[] ?? collection.ToArray();
            foreach (TblMenu c in tblIEnumerable.Where(c => c.ParentId == rootItem.Id))
            {
                lst.Add(new MenuItem
                {
                    displayName = c.DisplayName,
                    icon = c.Icon,
                    ordinal = c.Ordinal,
                    path = c.Path,
                    type = c.Type,
                    childItems = GenerateTree(tblIEnumerable.ToList(), c).ToList()
                });
            }
            return lst;
        }
    }
}