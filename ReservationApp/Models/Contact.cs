using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ReservationApp.Models
{
    public class Contact
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(50)")]
        public string Entity { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(50)")]
        public string Name { get; set; }

        [Required]
        [Column(TypeName = "varchar(12)")]
        public string PhoneNumber { get; set; }
        
        [Required]
        [Column(TypeName = "Date")]
        public DateTime Birthday { get; set; }

        [Required]
        [ForeignKey("ContactType")]
        public int ContactTypeId { get; set; }
        public virtual ContactType ContactType { get; set; }

        public virtual ICollection<Reservation> Reservations { get; set; }
  
    }
}
