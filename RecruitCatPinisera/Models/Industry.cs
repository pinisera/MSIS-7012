using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using RecruitCatPinisera.Models;

namespace RecruitCatPinisera.Models
{
    public class Industry
    {
        public int IndustryId { get; set; }
        [DisplayName("Industry Name")]
        [Required]
        [StringLength(50)]
        public string IndustryName { get; set; }



        //Additional properties

        [DisplayName("Industry Type")]
        [Required]
        [StringLength(50)]
        public string IndustryType { get; set; }



        //Relationships

        [DisplayName("Candidates")]
        public List<Candidate> Candidates { get; set; }
        [DisplayName("Companies")]
        public List<Company> Companies { get; set; }
    }
}