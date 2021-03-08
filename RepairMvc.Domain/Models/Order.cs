using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RepairMvc.Domain.Models
{
    public enum Status
    {
        On_Hold,
        Under_Repair,
        Waiting_for_parts,
        Done
    }

    public class Order
    {
        public int OrderId { get; set; }
        public string OrderRef { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Postcode { get; set; }

        [Required]
        [Display(Name = "Status")]
        public Status? Status { get; set; }

        [Required(ErrorMessage = "Hours worked input is required")]
        [Display(Name = "Hours Worked")]
        public int HoursWorked { get; set; }

        [Required(ErrorMessage = "Begin date is required")]
        [Display(Name = "Begin Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime BeginDate { get; set; }

        [Required(ErrorMessage = "End date is required")]
        [Display(Name = "End Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime EndDate { get; set; }

        [Required(ErrorMessage = "Repair order description is required")]
        [DataType(DataType.MultilineText)]
        [MaxLength(500)]
        [Display(Name = "Description")]
        public string Description { get; set; }

        [DataType(DataType.MultilineText)]
        [MaxLength(500)]
        [Display(Name = "Work Report")]
        public string WorkReport { get; set; }
        public ICollection<OrderProduct> OrderProducts { get; set; }
    }
}
