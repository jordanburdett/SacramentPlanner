using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SacramentPlanner.Models
{
    public class SacramentPlan
    {
        public int Id { get; set; }

        [Display(Name = "Date")]
        [Required]
        [DataType(DataType.Date)]
        public DateTime date { get; set; }

        [Display(Name = "Conducting")]
        [StringLength(15)]
        [Required]
        public string conductingLeader { get; set; }

        [Display(Name = "Opening Prayer")]
        [StringLength(30)]
        [Required]
        public string openingPrayer { get; set; }

        [Display(Name = "Opening Hymn")]
        [StringLength(30)]
        [Required]
        public string openingSong { get; set; }

        [Display(Name = "Sacrament Hymn")]
        [StringLength(30)]
        [Required]
        public string sacramentHymn { get; set; }

        [Display(Name = "Closing Hymn")]
        [StringLength(30)]
        [Required]
        public string closingSong { get; set; }

        [Display(Name = "Closing Prayer")]
        [StringLength(30)]
        [Required]
        public string closingPrayer { get; set; }

        [Display(Name = "Special Musical Number")]
        [StringLength(30)]
        public string specialMusicalNumber { get; set; }

        [Display(Name = "Special Musical Number Performer")]
        [StringLength(20)]
        public string specialMusicalNumberName { get; set; }

        [Display(Name = "First Speaker")]
        [StringLength(15)]
        [Required]
        public string firstSpeaker { get; set; }

        [Display(Name = "First Speaker Subject")]
        [StringLength(15)]
        [Required]
        public string firstSpeakerSubject { get; set; }

        [Display(Name = "Second Speaker")]
        [StringLength(15)]
        [Required]
        public string secondSpeaker { get; set; }

        [Display(Name = "Second Speaker Subject")]
        [StringLength(15)]
        [Required]
        public string secondSpeakerSubject { get; set; }

        [Display(Name = "Third Speaker")]
        [StringLength(15)]
        [Required]
        public string thirdSpeaker { get; set; }

        [Display(Name = "Third Speaker Subject")]
        [StringLength(15)]
        [Required]
        public string thirdSpeakerSubject { get; set; }
    }
}
