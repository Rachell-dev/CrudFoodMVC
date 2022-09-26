using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CrudFood.Models
{
    public partial class Food
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }

        [Range(1,5)]
        public int? Rating { get; set; }
    }
}
