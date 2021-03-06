﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ShenkinStore.Models
{
    public class Transaction
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TransactionId { get; set; }

        public bool Delivery { get; set; }

        // TODO: Lets see how we can secure this prop
        public bool Paid { get; set; }
        [Display(Name = "Transaction Date")]
        [DataType(DataType.Date)]
        public DateTime TransDate { get; set; }
        [Display(Name = "Total Price :")]
        public decimal Amount { get; set; }

        public virtual User User { get; set; }

        public virtual ShoppingCart Cart { get; set; }

        [Display(Name = "List of Products :")]
        public ICollection<Product> productslist { get; set; }
    }
}
