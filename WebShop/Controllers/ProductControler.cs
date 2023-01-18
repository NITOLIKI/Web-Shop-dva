using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebShop.Controllers
{
    [Route("api")]
    [ApiController]
    public class ProductControler : ControllerBase
    {
        public readonly IProductService _productService;
        public ProductControler() { }

        [HttpPost("product")]
        public ActionResult Insert(ProizvodModel productModel) {

            var p = new Proizvod
            {
                Opis = productModel.Opis,
                Cena = productModel.Cena,
                Ime = productModel.Ime,

            };

        }
    }
}
