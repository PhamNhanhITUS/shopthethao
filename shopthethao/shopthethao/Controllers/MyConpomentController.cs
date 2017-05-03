using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace shopthethao.Controllers
{
    public class MyConpomentController : Controller
    {
        [ChildActionOnly]
        public PartialViewResult HeaderTop()
        {
            return PartialView();
        }
        
        public PartialViewResult HeaderMiddle()
        {
            return PartialView();
        }
        
        public PartialViewResult HeaderBottom()
        {
            return PartialView();
        }
    }
}