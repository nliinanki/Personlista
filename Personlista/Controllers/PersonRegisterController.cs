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
        /// Get person register view
        /// </summary>
        /// <returns></returns>
        public ActionResult PersonRegisterList()
        {
            var viewData = new PersonRegisterListViewData();
            viewData.SearchRequest = new SearchRequest { DisplayNumber = DisplayNumber.Display10 };

            return View(viewData);
        }

        /// <summary>
        /// Get person register list in partial view
        /// </summary>
        /// <returns></returns>
        public PartialViewResult PersonRegisterListResult(SearchRequest searchRequest)
        {
            var viewData = GetPersonListViewData(searchRequest);

            return PartialView(viewData);
        }

        private PersonRegisterListResultViewData GetPersonListViewData(SearchRequest searchRequest)
        {
            var viewData = new PersonRegisterListResultViewData();

            var list = PersonRegister.GetPersonRegisterList(searchRequest);

            viewData.PersonList = list.Persons;
            viewData.ListCount = list.ListCount;
            viewData.PageCount = list.PageCount;
            viewData.CurrentPage = list.CurrentPage;
            viewData.PageNumbers = list.PageNumbers;

            return viewData;
        }

        /// <summary>
        /// Create a new person in view
        /// </summary>
        /// <returns></returns>
        public ActionResult CreateNewPerson()
        {
            var viewData = GetPersonListViewData(new SearchRequest());

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
            var viewData = GetPersonListViewData(new SearchRequest());

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
            var viewData = GetPersonListViewData(new SearchRequest());

            PersonRegister.SaveAllNew(new List<int>());

            return PartialView("PersonRegisterListResult", viewData);
        }

    }
}