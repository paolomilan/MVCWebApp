// New class created to create this Model
using System.ComponentModel.DataAnnotations;

namespace MVCWebApp.Models
{
    public class Events
    {
        //ID for database primary key
        public int Id { get; set; }
        public string? Event { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime EventDate { get; set; }
        public string? Guest { get; set; }
        public decimal Price { get; set; }
    }
}