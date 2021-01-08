﻿using Projekt1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projekt1.Models
{
    public class Rental
    {
        public int RentalId { get; set; }

        public DateTime? RentalDate { get; set; } //Även fast det är nullable här, så sköter controllern inmatningen automatiskt

        public DateTime? ReturnDate { get; set; } // Om denna INTE är null så har filmen lämnats tillbaks. 

        public bool Rented { get; set; } = false;

        // Nav prop
        public Inventory Inventory { get; set; }
        public int? InventoryId { get; set; }


        public bool Returned
        {
            get
            {
                return ReturnDate == null ? false : true;
            }
        }
    }
}
