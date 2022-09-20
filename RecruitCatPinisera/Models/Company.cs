using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using RecruitCatPinisera.Models;

namespace RecruitCatPinisera.Models

{

    public class Company
    {
        public int CompanyId { get; set; }
        [DisplayName("Company Name")]
        [Required]
        [StringLength(100)]
        public string CompanyName { get; set; }
        [DisplayName("Position Name")]
        [Required]
        [StringLength(100)]
        public string PositionName { get; set; }
        [DisplayName("Minimum Salary")]
        [Range(0, 1000000)]
        [DataType(DataType.Currency)]
        public decimal MinSalary { get; set; }
        [DisplayName("Maximum Salary")]
        [Range(0, 1000000000)]
        [DataType(DataType.Currency)]
        public decimal MaxSalary { get; set; }
        [DisplayName("Start Date")]
        [DataType(DataType.Date)]
        public DateTime? StartDate { get; set; }
        [DisplayName("PreferredLocation")]
        [Required]
        [StringLength(100)]
        public string Location { get; set; }



        //Relationships

        [DisplayName("Candidates")]
        public List<Candidate> Candidates { get; set; }
        [DisplayName("Industry")]
        public Industry Industry { get; set; }
        [DisplayName("Industry")]
        public int IndustryId { get; set; }
        [DisplayName("Job Title")]
        public JobTitle JobTitle { get; set; }
        [DisplayName("Job Title")]
        public int JobTitleId { get; set; }
    }
}