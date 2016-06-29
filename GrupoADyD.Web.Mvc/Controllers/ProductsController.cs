using GrupoADyD.Application.Interfaces;
using System.Web.Mvc;

namespace GrupoADyD.Web.Mvc.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IProductAppService _productAppService;

        public ProductsController(IProductAppService productAppService)
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