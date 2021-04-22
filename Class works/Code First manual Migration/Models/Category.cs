using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Code_First_manual_Migration.Models
{
   
    public class Category
    {
       
        public int CategoryId { get; set; }
     
        public string CategoryName { get; set; }
        
        public virtual ICollection<Product> Products { get; set; }
    }
}