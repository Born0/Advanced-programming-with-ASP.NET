using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace Ch24ShoppingCartMVC.Models
{
    public class CheckoutViewModel
    {
       
        public string CreditCardNumber { get; set; }
        public string CardholderName { get; set; }
        public string CardType { get; set; }
        public string CardProvider { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

    }
}