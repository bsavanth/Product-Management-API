using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ProductManagement.Models
{
	public class Product
	{
		[Key]
		public int ID { get; set; }

		public string Name { get; set; }

		public int CID { get; set; }

		public DateTime ExpiryDate {get; set; }

		public int Quantity { get; set; }

		public decimal Price { get; set; }
    }
}
