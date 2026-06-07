using Microsoft.AspNetCore.Mvc;
using MVCTrain.Models;

namespace MVCTrain.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult All()
        {
            List<Product> products = new List<Product>()
            {
                new Product(id:1, name:"Playstation 5", description:"Plays Games", imageUrl:"https://encrypted-tbn2.gstatic.com/shopping?q=tbn:ANd9GcQf7X82Znj2TSsafwkULn2VezYOTOUupyjsLcTZ3VitVOGwVhT8F_nkqPcHTPYm4NCxHJj77ob0-dy9PH14n7n_Tuo03hxMnFe7-F92AMfNIEue0epKGYs85wpzOpXNOBGpeQHmVQ&usqp=CAc"),
                new Product(id:2, name:"Playstation 4", description:"Plays Games last gen", imageUrl:"https://encrypted-tbn1.gstatic.com/shopping?q=tbn:ANd9GcQDLOUQvbt2-i5RYueK2Zy21ib3rrKmge5uCV8o1reAvIG-lffFpGgRUSstX1c-zA-5iUqUHeCH2eYSjIMiwnuCsNTpMlRzv7bxStzY0UDFsLt1gsdsFOxZvn1_stq-TbYzLRTOvA&usqp=CAc"),
                new Product(id:3, name:"Playstation 3", description:"Plays Games during my childhood days", imageUrl:"https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcS38BgQAuMfJh9MdleCgd19by-JfvNvoa-GD0dBg_uqeg&s=10")
            };
            ProductBL bl = new ProductBL(products);
            return View("something", bl.Products);
        }
    }
}
