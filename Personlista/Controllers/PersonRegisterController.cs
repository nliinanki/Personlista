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
            viewData.CreateRequest = new CreateRequest();

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
            viewData.FirstPage = list.FirstPage;
            viewData.LastPage = list.LastPage;
            viewData.SearchRequest = searchRequest;

            return viewData;
        }


        /// <summary>
        /// Save one person
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public ActionResult SavePerson(CreateRequest createRequest)
        {
            PersonRegister.SaveOneNew(createRequest);

            var viewData = GetPersonListViewData(new SearchRequest());
            return PartialView("PersonRegisterListResult", viewData);
        }

        /// <summary>
        /// Save all persons
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public ActionResult SaveAllNewPersons(CreateRequest createRequests)
        {
            //todo 

            PersonRegister.SaveAllNew(createRequests);

            var viewData = GetPersonListViewData(new SearchRequest());
            return PartialView("PersonRegisterListResult", viewData);
        }
         
    }
}