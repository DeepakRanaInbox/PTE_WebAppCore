using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Pte.Models
{
    public class DocumentTypeModel
    {
        public int ID { set; get; }

        [Required(ErrorMessage = "Document Type is required")]
        public string vName { set; get; }

        public string vRemarks { set; get; }


        [Required(ErrorMessage = "Service  is required")]
        public int iServiceID { set; get; }
        public List<SelectListItem> ServiceList { set; get; }
    }
}