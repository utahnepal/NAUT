using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NAUT.Models;


namespace NAUT.Controllers
{
    public class MembersController : Controller
    {
       // NAUT
        NAUTEntity NAUTEntity = new NAUTEntity();

        public ActionResult Members()
        {
            var List = (from N in NAUTEntity.Lists
                        select N
                       ).ToList();

            return View(List);
        }

    }
}
