using System.Collections.Generic;
using System.Web.Mvc;

namespace WebApp
{
    public class Employee
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Sex { get; set; }
        public string FavouriteMovie { get; set; }
        public List<SelectListItem> Movies
        {
            get
            {
                List<SelectListItem> items = new List<SelectListItem>();

                items.Add(new SelectListItem { Text = "Action", Value = "0" });

                items.Add(new SelectListItem { Text = "Drama", Value = "1" });

                items.Add(new SelectListItem { Text = "Comedy", Value = "2", Selected = true });

                items.Add(new SelectListItem { Text = "Science Fiction", Value = "3" });
                return items;
            }
            private set { }
        }

    }
}