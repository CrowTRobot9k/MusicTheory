using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MusicTheory.UI.Models
{
    public class Menu
    {
        public List<MenuItem> MenuItems { get; set; }

        public Menu()
        {
            MenuItems = new List<MenuItem>
            {
                new MenuItem
                {
                    Id = 100,
                    NameOption = "Music",
                    Controller = "Music",
                    Action = "Index",
                    ImageClass = "fa fa-music fa-lg",
                    Status = true,
                    IsParent = false,
                    ParentId = 0,
                    RequiredRoles = System.Configuration.ConfigurationManager.AppSettings["OrdersAccess"],
                    SubMenu= new List<MenuItem>()
                }
            };
        }
    }
}