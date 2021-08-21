using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Pte.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pte.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            string Name = "This is Demo";

            return View();             
        }
        public IActionResult Login()
        {
            LoginModel _loginModel = new LoginModel();

            return View(_loginModel);
        }
        public IActionResult Auth()
        {
            LoginModel _loginModel = new LoginModel();

            return View(_loginModel);
        }
        public IActionResult ForgotPassword()
        {
            ForgotPasswordModel _forgotPassword = new ForgotPasswordModel();
            return View(_forgotPassword);
        }
        public PartialViewResult _DocumentTypeModelParials()
        {
            DocumentTypeModel _documentTypeModel = new DocumentTypeModel();
            _documentTypeModel.ServiceList = new List<SelectListItem>();
            return PartialView(_documentTypeModel);
        }
        public PartialViewResult _QuestionType()
        {
            QuestionType _questionType = new QuestionType();
            _questionType.SectionTypeList = new List<SelectListItem>();
            _questionType.QuestionFormatList = new List<SelectListItem>();
            _questionType.AnswerFormatList = new List<SelectListItem>();
            return PartialView(_questionType);
        }
    }
}
