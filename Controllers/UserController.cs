using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Pte.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace Pte.Controllers
{
    public class UserController : Controller
    {
        IWebHostEnvironment _webHostEnvironment = null;
        public UserController(IWebHostEnvironment webHostEnvironment)
        {
            _webHostEnvironment = webHostEnvironment;
        }
        // GET: User
        public IActionResult Index()
        {
            Users _user = new Users();
            return View(_user);
        }
        public async Task<IActionResult> Create(Users _user)
        {
            if(_user.UploadImageUrl != null)
            {
                _user.vImagePath= await UploadImage( _user.UploadImageUrl, "Content/Images/");

            }
            
            return View();
        }

        public ActionResult UserDetails()
        {
            Users _user = new Users();
            _user.UserList = new List<Users>();
            return View(_user);
        }
        public ActionResult UserProfile(string id)
        {
            Users _user = new Users();
            return View(_user);
        }
        [HttpPost]
        public ActionResult UpdateProfile(Users users)
        {
            if(ModelState.IsValid)
            {
                //your code here
            }

            return View();
        }
        public ActionResult ChangePassword()
        {
            return View();
        }
        //private string SaveFiles(string foldername,IFormFile item)
        //{
        //    string filepath = string.Empty;
        //    string ext = Path.GetExtension(item.FileName);
        //    if (ext == ".jpg" || ext == ".JPG")
        //    {
        //        filepath = "~/Content/Images/"+ foldername + "/"+ Guid.NewGuid().ToString() + item.FileName;
        //        var path = Path.Combine(Server.MapPath(filepath));//to save file into directory
        //        item.SaveAs(path);
        //    }

        //    return filepath;
        //}
        private async Task<string> UploadImage(IFormFile file, string folder)
        {
            folder += Guid.NewGuid().ToString() + "_" + file.FileName;
            string serverPath = Path.Combine(_webHostEnvironment.WebRootPath, folder);
            await file.CopyToAsync(new FileStream(serverPath, FileMode.Create));
            return "/" + folder;
        }
    }
}