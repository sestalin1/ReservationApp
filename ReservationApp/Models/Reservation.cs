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
        public string Id { get; set; }

        [Required]
        [Display(Name = "Title")]
        [Column(TypeName = "nvarchar(100)")]
        public string Title { get; set; }

        [Required]
        [Display(Name = "Creation Date")]
        [Column(TypeName = "Date")]
        public DateTime CreationDate { get; set; }

        [Required]
        [Display(Name = "Target Date")]
        [Column(TypeName = "Date")]
        public DateTime TargetDate { get; set; }

        [Required]
        [Display(Name = "Description")]
        [Column(TypeName = "nvarchar(100)")]
        public string Description { get; set; }

        [Display(Name = "Rating")]
        [Column(TypeName = "decimal(1,1)")]
        public decimal Rating { get; set; }

        [Display(Name = "Is Favorite?")]
        public bool IsFavorite {get; set;}


        [Required]
        [Display(Name = "Contact Name")]
        public string ContactId { get; set; }
        public virtual Contact Contact { get; set; }
    }
}
