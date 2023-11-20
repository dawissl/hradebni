using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _03_DemoWeb.Models
{

    [Table("Account")]
    public class Account
    {
       [Key]
       public int ID { get; set; }
       public string Name { get; set; }
       public int Money { get; set; }
       public string? Email { get; set; }

            

    }
}
