using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using RecruitCatPinisera.Models;

namespace RecruitCatPinisera.Models
{
    public class JobTitle
    {
        public int JobTitleId { get; set; }
        [DisplayName("Job Title")]
        [Required]
        [StringLength(50)]
        public string Title { get; set; }
        [DisplayName("Minimum Salary")]
        [Range(0, 100000000)]
        [DataType(DataType.Currency)]
        public decimal MinSalary { get; set; }
        [DisplayName("Maximum Salary")]
        [Range(0, 100000000)]
        [DataType(DataType.Currency)]
        public decimal MaxSalary { get; set; }



        //Additional properties

        [DisplayName("Job Type")]
        [Required]
        [StringLength(20)]
        public string JobType { get; set; }
        [DisplayName("Job Detail")]
        public string JobDetail
        {
            get { return $"{Title} {JobType}"; }
        }



        //Relationships

        [DisplayName("Candidates")]
        public List<Candidate>? Candidates { get; set; }
        [DisplayName("Companies")]
        public List<Company>? Companies { get; set; }
    }
}