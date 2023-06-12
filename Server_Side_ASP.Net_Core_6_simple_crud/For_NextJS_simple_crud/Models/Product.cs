using System.ComponentModel.DataAnnotations;

namespace For_NextJS_simple_crud.Models
{
    public class Product
    {
        [Key]
        public int ID { get; set; }
        public string? Title { get; set; }

        public int? Price { get; set; }
    }
}
