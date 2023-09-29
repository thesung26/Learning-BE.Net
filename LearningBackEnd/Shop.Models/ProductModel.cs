using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shop.Models
{
	[Table("Products")]
	public class ProductModel
	{
		[Key]
		public int ID { get; set; }

		[Required]
		[StringLength(50)]
		public string Name { get; set; }

		[StringLength(50)]
		public string Description { get; set; }
	}
}
