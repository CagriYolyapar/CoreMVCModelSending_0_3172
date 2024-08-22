using Microsoft.AspNetCore.Mvc;

namespace CoreMVCModelSending_0.Controllers
{
    public class SimulasyonController : Controller
    {
        //Eger bir View metodu bir string argüman ile cagrılıyorsa artık icinde cagrıldıgı Action isminde bir View sayfası aramaz sizin ona verdiginiz string argüman isminde bir View sayfası arar...Ancak bilmelisiniz ki bir View'in bu sekilde kullanılması standart degildir...Cünkü biz View'ların Action isimleriyle denk düsmesini isteriz ki projemiz icerisinde barındırılan kodlar temiz bir şekilde gözüksün...

        //View metodu, icerisine bir argüman verilmeden cagrıldıgı zaman hangi ACtion icerisindeyse o Action ile aynı isimde Vİew döndürme görevine sahiptir...Ancak bir View metoduna explicit bir şekilde(acıkca) string tipte bir argüman verilirse o zaman icinde bulundugu Action ismi neyse o isimde bir View'i döndürmeye calısır

        public IActionResult Index()
        {
            return View("Deneme");
        }
    }
}
