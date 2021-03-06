using System;
using TanCruzDentalInventorySystem.BusinessService;
using TanCruzDentalInventorySystem.BusinessService.BusinessServiceInterface;
using TanCruzDentalInventorySystem.Repository;
using TanCruzDentalInventorySystem.Repository.DataServiceInterface;
using Unity;

namespace TanCruzDentalInventorySystem
{
    /// <summary>
    /// Specifies the Unity configuration for the main container.
    /// </summary>
    public static class UnityConfig
    {
        #region Unity Container
        private static Lazy<IUnityContainer> container =
          new Lazy<IUnityContainer>(() =>
          {
              var container = new UnityContainer();
              RegisterTypes(container);
              return container;
          });

        /// <summary>
        /// Configured Unity Container.
        /// </summary>
        public static IUnityContainer Container => container.Value;
        #endregion

        /// <summary>
        /// Registers the type mappings with the Unity container.
        /// </summary>
        /// <param name="container">The unity container to configure.</param>
        /// <remarks>
        /// There is no need to register concrete types such as controllers or
        /// API controllers (unless you want to change the defaults), as Unity
        /// allows resolving a concrete type even if it was not previously
        /// registered.
        /// </remarks>
        public static void RegisterTypes(IUnityContainer container)
        {
            // NOTE: To load from web.config uncomment the line below.
            // Make sure to add a Unity.Configuration to the using statements.
            // container.LoadConfiguration();

            // TODO: Register your type's mappings here.
            // container.RegisterType<IProductRepository, ProductRepository>();

            container.RegisterType<IBusinessPartnerService, BusinessPartnerService>();
            container.RegisterType<IItemService, ItemService>();
            container.RegisterType<IPurchaseOrderService, PurchaseOrderService>();
            container.RegisterType<ISalesOrderService, SalesOrderService>();
            container.RegisterType<IItemGroupService, ItemGroupService>();
            container.RegisterType<IPaymentService, PaymentService>();
            container.RegisterType<IReportService, ReportService>();
            container.RegisterType<IItemPriceService, ItemPriceService>();

            container.RegisterType<ICurrencyRepository, CurrencyRepository>();
            container.RegisterType<IBusinessPartnerRepository, BusinessPartnerRepository>();
            container.RegisterType<IItemRepository, ItemRepository>();
            container.RegisterType<IPurchaseOrderRepository, PurchaseOrderRepository>();
            container.RegisterType<ISalesOrderRepository, SalesOrderRepository>();
            container.RegisterType<IItemGroupRepository, ItemGroupRepository>();
            container.RegisterType<IPaymentRepository, PaymentRepository>();
            container.RegisterType<IReportRepository, ReportRepository>();
            container.RegisterType<IItemPriceRepository, ItemPriceRepository>();

            container.RegisterType<IUnitOfWork, UnitOfWork>();
        }
    }
}