using Microsoft.AspNetCore.Mvc;
using SMS.Data;
using SMS.Models;

namespace SMS.Controllers
{
    public class ReportController : Controller
    {
        private readonly ApplicationDbContext applicationDbContext;

        public IList<Item> items;
        public IList<Service> services;
        public IList<Delivery> deliveries;

        public ReportController(ApplicationDbContext cc)
        {
            applicationDbContext = cc;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult AllitemData()
        {
            return new Rotativa.AspNetCore.ViewAsPdf(applicationDbContext.items.OrderBy(x => x.item_id).ToList());
        }

        public IActionResult ItemData()
        {
            var items = applicationDbContext.items.OrderBy(x => x.item_id).ToList();
            return View(items);
        }
        [HttpPost]
        public IActionResult SearchItem(String Data)
        {
            DataClass data = new DataClass(applicationDbContext);
            var Items = data.getitemdata(Data);
            TempData["Data"] = Data;
            return View(Items);
        }
        [HttpGet]
        public IActionResult ItemReport()
        {
            DataClass data = new DataClass(applicationDbContext);
            var mydata = TempData["Data"];
            var seachitems = data.getitemdata(mydata.ToString());
            return new Rotativa.AspNetCore.ViewAsPdf(seachitems);
        }
        [HttpGet]
        public IActionResult AllServiceData()
        {

            return new Rotativa.AspNetCore.ViewAsPdf(applicationDbContext.services.OrderBy(x => x.service_id).ToList());
        }
        [HttpGet]
        public IActionResult ServiceData()
        {
            services = applicationDbContext.services.OrderBy(x => x.service_id).ToList();
            return View(services);
        }
        [HttpPost]
        public IActionResult searchservicedata(String Data)
        {
            DataClass dataClass = new DataClass(applicationDbContext);
            services = dataClass.getservicedata(Data);
            TempData["Data"] = Data;
            return View(services);
        }
        [HttpGet]
        public IActionResult ServiceReport()
        {
            DataClass dataClass = new DataClass(applicationDbContext);
            var mylist = TempData["Data"];
            IList<Service> servicelist = dataClass.getservicedata(mylist.ToString());
            return new Rotativa.AspNetCore.ViewAsPdf(servicelist);
        }

        [HttpGet]
        public IActionResult AllDelivaryReport()
        {
            return new Rotativa.AspNetCore.ViewAsPdf(applicationDbContext.deliveries.OrderBy(x => x.delivery_id).ToList());
        }
        [HttpGet]
        public IActionResult DelivaryData()
        {
            IList<Delivery> list = applicationDbContext.deliveries.OrderBy(x => x.delivery_id).ToList();
            return View(list);
        }
        [HttpPost]
        public IActionResult ShowDelivary(String Data)
        {
            DataClass data = new DataClass(applicationDbContext);
            deliveries = data.getdelivarydata(Data);
            TempData["data"] = Data;
            return View(deliveries);
        }
        [HttpGet]
        public IActionResult DelivaryReport()
        {
            DataClass data = new DataClass(applicationDbContext);
            var name = TempData["Data"];
            IList<Delivery> mydata = data.getdelivarydata(name.ToString());
            return new Rotativa.AspNetCore.ViewAsPdf(mydata);

        }

    }

}
