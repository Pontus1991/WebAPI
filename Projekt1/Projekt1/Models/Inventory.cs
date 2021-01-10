using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Projekt1.Models
{
    public class Inventory
    {
        [Key]
        public int InventoryId { get; set; }

        //public int? Bookid { get; set; }

        //public Book Book { get; set; } // nav prop

        public Book Book { get; set; }
        // public List<Book> Books { get; set; }

        public int? BookId { get; set; }

        public List<Rental> Rentals { get; set; }
    }
}
