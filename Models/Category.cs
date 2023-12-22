using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WebMarket.Models
{
	public class Category
	{
		[Key]
		public int Id { get; set; }
		[Required]
		[DisplayName("Category Name")]
        public required string Name { get; set; }
		[DisplayName("Display Order")]
        public int DisplayOrder { get; set; }
    }
}

