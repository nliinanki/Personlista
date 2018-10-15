using Personlista.Models;
using Personlista.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Personlista.Controllers
{
    public class PersonRegisterController : Controller
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public ActionResult PersonRegisterList()
        {
            return View();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public PartialViewResult PersonRegisterListResult()
        {
            var viewData = GetPersonListViewData();

            return PartialView(viewData);
        }

        private PersonRegisterListViewData GetPersonListViewData()
        {
            var viewData = new PersonRegisterListViewData();

            var list = PersonRegister.GetPersonRegisterList();

            return viewData;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public ActionResult CreateNewPerson()
        {
            var viewData = GetPersonListViewData();

            var person = PersonRegister.Create();

            return PartialView("PersonRegisterListResult", viewData);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public ActionResult SavePerson()
        {
            var viewData = GetPersonListViewData();

            PersonRegister.Save(0);

            return PartialView("PersonRegisterListResult", viewData);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public ActionResult SaveAllNewPersons()
        {
            var viewData = GetPersonListViewData();

            PersonRegister.SaveAllNew(new List<int>());

            return PartialView("PersonRegisterListResult", viewData);
        }

    }
}