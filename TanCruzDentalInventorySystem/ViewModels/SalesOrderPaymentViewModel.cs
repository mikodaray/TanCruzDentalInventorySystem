﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TanCruzDentalInventorySystem.ViewModels
{
	public class SalesOrderPaymentViewModel
    {
		[Display(Name = "Sales Order Payment Id")]
		public string SOPaymentId { get; set; }
        [Display(Name = "Sales Order Id")]
        public string SalesOrder_SalesOrderId { get; set; }
        [Display(Name = "Sales Order Payment Control Number")]
		public long SOPaymentControlNumber { get; set; }
        [Display(Name = "Sales Order")]
        public SalesOrderViewModel SalesOrder { get; set; }
        [Display(Name = "Business Partner")]
		public BusinessPartnerViewModel BusinessPartner { get; set; }
		[Display(Name = "Currency")]
		public CurrencyViewModel Currency { get; set; }
		[Display(Name = "Status")]
		public string PaymentStatus { get; set; }
		[Display(Name = "Payment Date")]
		public DateTime? PaymentDate { get; set; }
		[Display(Name = "Document Date")]
		public DateTime? DocumentDate { get; set; }
        [Display(Name = "Reference Document Number")]
        public string RefDocNumber { get; set; }
        [Display(Name = "Payment Total")]
        public decimal PaymentTotal { get; set; }
        [Display(Name = "Remarks")]
		public string Remarks { get; set; }
		public string UserId { get; set; }
		public DateTime? ChangedDate { get; set; }
		public long VersionTimeStamp { get; set; }

        [Required(ErrorMessage = "You have not selected any Item.")]
		public List<SalesOrderPaymentDetailViewModel> SalesOrderPaymentDetails { get; set; }
	}

	public class SalesOrderPaymentFormViewModel
	{
        public string ViewMode { get; set; }
        public SalesOrderPaymentViewModel SalesOrderPayment { get; set; }
		public IEnumerable<CurrencyViewModel> Currencies { get; set; }
		public IEnumerable<BusinessPartnerViewModel> BusinessPartners { get; set; }
	}
}