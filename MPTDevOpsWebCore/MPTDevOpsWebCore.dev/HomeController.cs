using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

//using Microsoft.Extensions.Configuration;

// 
// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860
// makke new build replace running svc
namespace MPTDevOpsWebCore
{
    public class HomeController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Upload(IFormFile file)
        {
            // Extract file name from whatever was posted by browser
            var fileName = System.IO.Path.GetFileName(file.FileName);

            // If file with same name exists delete it
            if (System.IO.File.Exists(fileName))
            {
                System.IO.File.Delete(fileName);
            }
            string mfilelocation = string.Empty;
            // Create new local file and copy contents of uploaded file
            using (var localFile = System.IO.File.OpenWrite(fileName))
            using (var uploadedFile = file.OpenReadStream())
            {
                uploadedFile.CopyTo(localFile);
                mfilelocation = localFile.ToString();
            }

            ViewBag.Message = $"File successfully uploaded at {mfilelocation}" ;

            return View();
        }
    }
}
