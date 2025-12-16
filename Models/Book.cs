using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Models
{
    public class Book
    {
        public int BookID { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public int CategoryID { get; set; } 
        public int Quantity { get; set; }
        public decimal Price { get; set; }
    }

    public class CategoryItem
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }
}