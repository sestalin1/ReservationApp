using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ReservationApp.Models
{
    public class Reservation
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string ReservationId { get; set; }

        [Required]
        [Display(Name = "Date")]
        [Column(TypeName = "Date")]
        public DateTime ReservationDate { get; set; }

        [Required]
        [Display(Name = "Description")]
        [Column(TypeName = "nvarchar(100)")]
        public string ReservationDescription { get; set; }

        [Required]
        [Display(Name = "Contact Name")]
        public string ContactId { get; set; }
        public virtual Contact Contact { get; set; }
    }
}
