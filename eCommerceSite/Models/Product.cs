using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eCommerceSite.Models
{
    /// <summary>
    /// A salable product
    /// </summary>
    public class Product
    {
        [Key] // Makes Primary key in database
        public int ProductId { get; set; }
        /// <summary>
        /// The consumer facing name of the product
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// The retail price as U.S. Currency
        /// </summary>
        public double Price { get; set; }
        /// <summary>
        /// Category product falls under things such as electronics, clothing, etc.
        /// </summary>
        public string Category { get; set; }
    }
}
