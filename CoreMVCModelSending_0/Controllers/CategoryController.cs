using CoreMVCModelSending_0.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoreMVCModelSending_0.Controllers
{
    public class CategoryController : Controller
    {
        //Bir Category Class'i yaratın (İcinde CategoryName ve Description Property'leri olsun). Sonra GetCategory action'inda instance'i alınmıs bir Category'i ilgili View'da kullanıcıya ismi ve Acıklamasıyla gösterin (table seklinde)
        public IActionResult GetCategory()
        {
            Category c = new()
            {
                CategoryName = "Tatlılar",
                Description = "Test verisidir"
            };
            return View(c);
        }

        //Asagıdaki Action'da parametremiz program.cs'deki URL patternimizin parametre kısmına uymadıgı icin parametreye degeri slash ile degil querystring yöntemiyle (?a=2 seklinde) gönderebiliriz... 


        public IActionResult Index(int a)
        {
            return View();
        }


       
        public IActionResult CreateCategory()
        {
            //Biz eger BackEnd'den Front End'e bir model göndermiyorsak..Ama buna ragmen Front End sanki bir model karsılıyormus gibi bir ifade kullandıysa anlayın ki bu sefer bu demektir ki Front End Back End'e bir model gönderiyor
            return View();
        }


        [HttpPost]
        public IActionResult CreateCategory(Category category)
        {
            
            return View();
        }


    }
}
