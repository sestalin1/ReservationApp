using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ReservationApp.Models
{
    public class ContactType
    {
        [Key]
        public int CTId { get; set; }

        [Required]
        [Display(Name = "Contact Type")]
        [Column(TypeName = "nvarchar(20)")]
        public string CTName { get; set; }

        [Display(Name = "Description")]
        [Column(TypeName = "nvarchar(100)")]
        public string CTDescription { get; set; }

        public virtual Contact Contact { get; set; }
    }
}
