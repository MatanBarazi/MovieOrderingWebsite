//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVC_project.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    public partial class SCHEDULE
    {
        [Required]
        [DisplayName("hall number:")]
        public int HallNumber { get; set; }
        [Required(ErrorMessage = "Date is required")]
        [DisplayName("Select Date")]
        public System.DateTime Date { get; set; }
        [DisplayName("Select hour:")]
        public System.TimeSpan FromTime { get; set; }
        public System.TimeSpan ToTime { get; set; }
        public string Movie { get; set; }
        [Required(ErrorMessage = "Time is required")]
        public int Id { get; set; }
    }
}
