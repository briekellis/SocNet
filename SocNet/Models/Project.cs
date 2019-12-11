using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace SocNet.Models
{
    public class Project
    {
        public int ID { get; set; }
        [Required]
        [ConcurrencyCheck]
        [MaxLength(24)]
        [MinLength(5)]
        public string ProjectTitle { get; set; }
        public string Description { get; set; }
        public string Requirements { get; set; }
        [MaxLength(24)]
        [MinLength(5)]
        public string Location { get; set; }
    }
}