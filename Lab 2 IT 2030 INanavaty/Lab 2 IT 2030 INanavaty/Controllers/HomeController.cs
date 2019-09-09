using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab_2_IT_2030_INanavaty.Controllers
{
    public class ProductsController : Controller
    {
        public ModelandView Index()
        {
                 String message = "Products/Index Displayed";
            return new ModelandView("products","message",message);
        }

        public ModelandView Browse(){
        {
                string message = ProductsController/Browse
                    String message = "Browse Dispalyed";

            return new ModelandView("products","message",message);
        }

        public ModelandView Details() { }
        {
                String message = ProductsController / Details / 105;
                String message = "Details Displayed for Id=105";

            return new ModelandView("products", "message",message);
        }
            public string Location();
    {
                string message = ProductsController / Location ? zip = 44124:
                    string message = "Location displayed for zip=44124";
                    return new ModelandView("products", "message", message);



    }
}