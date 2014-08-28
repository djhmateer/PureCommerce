using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace PureCommerce.Controllers {
    public class HomeController : Controller
    {
        private readonly IRepository repository;

        public HomeController()
        {
            this.repository = new Repository();
        }

        public ActionResult Index() {
            // Want to return Product data to the page in simplest way from .\SQLEXPRESS ComplexCommerce
            //List<Product> products;
            //using (var db = new CommerceContext()) {
            //    products = db.Products.ToList();
            //}

            // Demonstrate hard coded dependency
            //var repository = new Repository();
            //var products = repository.GetAllProducts();

            // Demonstrate Dependency Injection
            var products = repository.GetAllProducts();
            return View(products);
        }

        //public ActionResult About() {
        //    ViewBag.Message = "Your application description page.";

        //    return View();
        //}

        //public ActionResult Contact() {
        //    ViewBag.Message = "Your contact page.";

        //    return View();
        //}
    }

    public interface IRepository {
        IList<Product> GetAllProducts();
    }

    public class Repository : IRepository {
        public IList<Product> GetAllProducts() {
            IList<Product> products;
            using (var db = new CommerceContext()) {
                products = db.Products.ToList();
            }
            return products;
        }
    }
}