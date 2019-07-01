﻿using System.Web.Mvc;
using TanCruzDentalInventorySystem.BusinessService.BusinessServiceInterface;


namespace TanCruzDentalInventorySystem.Controllers
{
	public class SalesOrderController : Controller
	{
		private ISalesOrderService _salesOrderService;

		public SalesOrderController(ISalesOrderService salesOrderService)
		{
			_salesOrderService = salesOrderService;
		}

		// GET: Sales
		public ActionResult Index()
		{
			return View();
		}

		public ActionResult CreateSales()
		{
			return View();
		}

		public ActionResult GetHomeData()
		{
			var salesOrderList = _salesOrderService.GetSalesOrderList();
			return Json(new { data = salesOrderList }, JsonRequestBehavior.AllowGet);

		}
	}
}