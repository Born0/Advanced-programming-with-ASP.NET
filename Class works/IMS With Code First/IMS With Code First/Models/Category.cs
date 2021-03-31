using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace IMS_With_Code_First.Models
{
   
    public class Category
    {
       
        public int CategoryId { get; set; }
     
        public string CategoryName { get; set; }
        
        public ICollection<Product> Products { get; set; }
    }
}