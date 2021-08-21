using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;
namespace Pte.Models
{
    public class QuestionType
    {

        public int ID { set; get; }

        [Required(ErrorMessage = "Question Type is required")]
        public string vName { set; get; }

        public string vInstructions { set; get; }

        [Required(ErrorMessage = "Section Type is required")]
        public int iSectionTypeID { set; get; }
        public List<SelectListItem> SectionTypeList { set; get; }

        [Required(ErrorMessage = "Question Format is required")]
        public string iQuestionFormat { set; get; }
        public List<SelectListItem> QuestionFormatList { set; get; }


        [Required(ErrorMessage = "Answer Format is required")]
        public string iAnswerFormat { set; get; }
        public List<SelectListItem> AnswerFormatList { set; get; }
        public string iMarks { set; get; }

        public string vQuestionFormat { set; get; }
        public string vAnswerFormat { set; get; }
        public string vSectionType { set; get; }
        public string TotalQuestions { get; set; }

    }
}