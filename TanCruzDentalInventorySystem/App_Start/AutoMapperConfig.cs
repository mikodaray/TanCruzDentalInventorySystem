﻿using AutoMapper;
using TanCruzDentalInventorySystem.Models;
using TanCruzDentalInventorySystem.ViewModels;

namespace TanCruzDentalInventorySystem
{
	public static class AutoMapperConfig
	{
		public static void RegisterComponents()
		{
			Mapper.Initialize(cfg =>
			{
				cfg.CreateMap<Item, ItemViewModel>().ReverseMap();
				cfg.CreateMap<ItemGroup, ItemGroupViewModel>().ReverseMap();
				cfg.CreateMap<ItemPrice, ItemPriceViewModel>().ReverseMap();
				cfg.CreateMap<Currency, CurrencyViewModel>().ReverseMap();
				cfg.CreateMap<UnitOfMeasure, UnitOfMeasureViewModel>().ReverseMap();
				cfg.CreateMap<BusinessPartner, BusinessPartnerViewModel>().ReverseMap();
				cfg.CreateMap<BusinessPartner, BusinessPartnerInFormViewModel>().ReverseMap();
				cfg.CreateMap<BusinessPartnerDetail, BusinessPartnerDetailViewModel>().ReverseMap();
				cfg.CreateMap<PurchasingUnitOfMeasure, PurchasingUnitOfMeasureViewModel>().ReverseMap();
				cfg.CreateMap<InventoryUnitOfMeasure, InventoryUnitOfMeasureViewModel>().ReverseMap();

				cfg.CreateMap<PurchaseOrder, PurchaseOrderViewModel>().ReverseMap();
				cfg.CreateMap<PurchaseOrderDetail, PurchaseOrderDetailViewModel>().ReverseMap();
				cfg.CreateMap<SalesOrder, SalesOrderViewModel>().ReverseMap();
				cfg.CreateMap<SalesOrderDetail, SalesOrderDetailViewModel>().ReverseMap();
			});
		}
	}
}