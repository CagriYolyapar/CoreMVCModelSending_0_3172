using CoreMVCModelSending_0.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoreMVCModelSending_0.Controllers
{
    public class EgitmenController : Controller
    {


        //Bir EgitmenListesi yaratarak EgitmenEkleme sistemi olusturmanızı istiyorum...Oncelikle kişi get yontemiyle EgitmenEkleme sayfasına girecek...Sonra post ile yazdıgı bilgilerin servera gönderilmesini saglayarak yaratılmak istenen egitmeni Egitmen listesine ekleyecek...Sonra bir de EgitmenleriGetir Action'i olacak...EgitmenleriGetir Action'inina girildiginde eklenmiş olan bütün egitmenlerin table'da listelenmesini istiyorum...

        static List<Egitmen> egitmenler = new();

      

        public IActionResult EgitmenEkle()
        {

            return View();
        }

        [HttpPost]
        public IActionResult EgitmenEkle(Egitmen egitmen)
        {
            egitmenler.Add(egitmen);
            return View();
        }

        public IActionResult EgitmenleriGetir()
        {
            return View(egitmenler);
        }
    }



}
