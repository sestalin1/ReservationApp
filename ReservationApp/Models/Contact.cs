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
        [Display(Name = "Entity")]
        public string Entity { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(50)")]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "You must insert a phone number")]
        [Display(Name = "Phone Number")]
        [DataType(DataType.PhoneNumber)]
        [Column(TypeName = "varchar(12)")]
        public string PhoneNumber { get; set; }
        
        [Required]
        [Column(TypeName = "Date")]
        [Display(Name = "Birthday")]
        public DateTime Birthday { get; set; }

        [Required]
        [Display(Name = "Contact Type")]
        [ForeignKey("ContactType")]
        public int ContactTypeId { get; set; }
        public virtual ContactType ContactType { get; set; }

        public virtual ICollection<Reservation> Reservations { get; set; }
  
    }
}
