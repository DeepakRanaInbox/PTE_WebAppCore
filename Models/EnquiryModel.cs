using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;
namespace Pte.Models
{
    public class InquiryModel
    {
        public int ID { set; get; }
        [Required(ErrorMessage = "Name is required")]
        public string vName { set; get; }
        public string vFather_Name { set; get; }
        [Required(ErrorMessage = "Email is required")]

        public string vEmail { set; get; }
        [Required(ErrorMessage = "Phone is required")]
        public string vPhoneNo { set; get; }

        public string vAddress { set; get; }


        public string vDOB { set; get; }

        public string Gender { set; get; }

        public string dFollowupDate { set; get; }
        public string vRemarks { set; get; }

        public string bisMaritalStatus { set; get; }

        public string iReferenceID { set; get; }
        public List<SelectListItem> ReferenceList { set; get; }

        [Required(ErrorMessage = "Status is required")]
        public string iStatusID { set; get; }
        public List<SelectListItem> StatusList { set; get; }
        public string iCountryId { set; get; }

        public List<SelectListItem> CountryList { set; get; }
        public string iServiceId { set; get; }

        public List<SelectListItem> ServiceList { set; get; }

    }
    public class InquiryDTO
    {
        public int ID { set; get; }

        public string vName { set; get; }
        public string vFather_Name { set; get; }


        public string vEmail { set; get; }

        public string vPhoneNo { set; get; }

        public string vAddress { set; get; }


        public string vDOB { set; get; }

        public string Gender { set; get; }

        public string dFollowupDate { set; get; }
        public string vRemarks { set; get; }
        public string InquiryOn { set; get; }
        public string InquiryBy { set; get; }
        public string MaritalStatus { set; get; }

        public string Reference { set; get; }

        public string vStatus { set; get; }
        public List<InquiryDTO> InquiryList { get; set; }

    }
    public class FollowupHistoryModel
    {
        public int ID { set; get; }
        public string iInquiryID { set; get; }
        public string vRemarks { set; get; }
        [Required(ErrorMessage = "Status is required")]
        public int iStatusID { set; get; }
        public List<SelectListItem> StatusList { set; get; }
        public string vStatus { set; get; }
         [Required(ErrorMessage = "Select FollowUp Date")]
        public string dFollowupOn { set; get; }
        public string FollowupBy { set; get; }
        public List<FollowupHistoryModel> _followupHistoryModelsList { get; set; }
    }
    public class FollowupHistoryDTO
    {
        public int ID { set; get; }
        public string iInquiryID { set; get; }
        public string vRemarks { set; get; }
        public string vStatus { set; get; }
        public string dFollowupOn { set; get; }
        public string FollowupBy { set; get; }
    }
}