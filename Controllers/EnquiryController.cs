using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Pte.Models;
using System.Collections.Generic;

namespace Pte.Controllers
{
    public class EnquiryController : Controller
    {
        // GET: Enquiry
        public ActionResult Index()
        {
            InquiryModel _inquiryModel = new InquiryModel();
            _inquiryModel.ReferenceList = new List<SelectListItem>();
            _inquiryModel.ServiceList = new List<SelectListItem>();
            _inquiryModel.StatusList = getStatus();
            _inquiryModel.CountryList = new List<SelectListItem>();
            return View(_inquiryModel);
        }

        public ActionResult Create(InquiryModel model)
        {
           
            if (!string.IsNullOrEmpty(model.iCountryId))
            {
                string[] countryid = model.iCountryId.Split(',');
                foreach (var item in countryid)
                {

                }
            }
            
            if (!string.IsNullOrEmpty(model.iServiceId))
            {
                string[] serviceid = model.iServiceId.Split(',');
                foreach (var item in serviceid)
                {

                }
            }
            return View();
        }
        public ActionResult Details()
        {
            InquiryDTO _inquiryDTO = new InquiryDTO();
            _inquiryDTO.InquiryList = new List<InquiryDTO>();
            return View(_inquiryDTO);
        }
        public PartialViewResult _UserEnquiryDetails(string id)
        {
            InquiryDTO _inquiryDTO = new InquiryDTO();
            return PartialView(_inquiryDTO);
        }
        public PartialViewResult _FollowUpPartials()
        {
            FollowupHistoryModel _followupHistoryModel = new FollowupHistoryModel();
            _followupHistoryModel.StatusList = getStatus();
            _followupHistoryModel._followupHistoryModelsList = new List<FollowupHistoryModel>();
            return PartialView(_followupHistoryModel);
        }
        public List<SelectListItem> getStatus()
        {
            List<SelectListItem> ls = new List<SelectListItem>();
            ls.Add(new SelectListItem { Text = "Inprocess", Value = "Inprocess" });
            ls.Add(new SelectListItem { Text = "Awaiting", Value = "Awaiting" });
            ls.Add(new SelectListItem { Text = "Register", Value = "Register" });
            ls.Add(new SelectListItem { Text = "Convert", Value = "Convert" });
            return ls;
        }
    }
}