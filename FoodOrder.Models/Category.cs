using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodOrder.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        public DateTime CreateDate { get; set; } = DateTime.Now;
    }
}
