using CoreMVCModelSending_0.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoreMVCModelSending_0.Controllers
{
    public class ProductController : Controller
    {
        #region OnemliNotlar

        //Bir View metodunun farklı bir View döndürmesi ile Model göndermesi arasında fark vardır. Bu metodun overloadlarinden birinde acık bir şekilde bir string parametre tanımlaması yapıldıgından dolayı metodun object parametre alan bir overload'i olmasına ragmen ilgili Metot bir string argüman ile cagrılırsa string parametreli overload'i calısır...Onun object overload'ini calıstırmak icin string argümanı object'e acıkca cast etmeniz gerekir...Yani siz, nasıl olsa her şey object'e gidiyor diye o ilgili object parametreli overload'in calısacagını düsünmemelisiniz(Cünkü acıkca string parametresi olan bir overload daha vardır) Siz bu bilgiyi gözden kacırırsanız verdiginiz string argümanın veri göndermek oldugunu(ModelSending yöntemiyle) zannedersiniz ama aslında o isimde bir sayfa döndürme görevi yapılır...

        //Model Göndermek Front End'e göstermek istediginiz bilgileri Back End'den Front End'e yollamak veya Front End'den almak istediginiz verileri Front End'den Back End'e göndermenin bir yoludur...Eger bu bilgi string bir tipte yollanacak ise o zaman verisinin object'e cast edilerek argüman olarak verilmesi gerekir (Cünkü View metodunda acıkca string parametre alan bir overload vardır)


        //Bir Model gönderiliyorsa karsılanmak zorundadır...

        //Model'in karsılanması View sayfasında @model(buradaki kücük harfli m'ye dikkat ediniz) diyerek gönderdiginiz verinin orijinal tipini yazmanız sayesinde olur...Model karsılandıktan sonra o ilgili verinin gösterilmesini istiyorsanız ise karsıladıgınız Model'i artık cagırmanız gerekir...Bu da @Model(büyük M harfina dikkat ediniz) sayesinde olur...

        //Aslında bir ModelSending yöntemini ilkel tipler veya ilkel tip gibi davranan verilerde tercih etmeyiniz..Onlar daha cok hafif bir veri gönderme yontemi ile gonderilebilir
        #endregion
        public IActionResult Index()
        {
            return View(12);
        }

        public IActionResult Contact()
        {
            return View("Hello World" as object);
        }

        public IActionResult GetProducts()
        {

            List<Product> products = new List<Product>()
            {
               new(){ProductName ="Tadelle",UnitPrice = 20},
               new(){ProductName = "Cizi",UnitPrice = 30},
               new(){ProductName = "Biskrem",UnitPrice = 40},
            };

            return View(products);
        }
    }
}
