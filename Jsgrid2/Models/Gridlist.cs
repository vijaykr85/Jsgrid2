using System.ComponentModel.DataAnnotations;

namespace Jsgrid2.Models
{
    public class Gridlist
    {      
            [Key]
            public int Id { get; set; }
            public string Name { get; set; }
            public decimal Price { get; set; }
        
    }
}
