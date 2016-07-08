using GrupoADyD.Application.Interfaces;
using System.Web.Mvc;

namespace GrupoADyD.Web.Mvc.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IProductService _productAppService;

        public ProductsController(IProductService productAppService)
        {
            _productAppService = productAppService;
        }

        // GET: Products
        public ActionResult Index()
        {
            return View(_productAppService.GetAll);
        }
    }
}