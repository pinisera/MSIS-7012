using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;



namespace RecruitCatPinisera.Models
{
    public class Candidate
    {
        public int CandidateId { get; set; }



        [DisplayName("First Name")]
        [Required]
        [StringLength(20)]
        public string FirstName { get; set; }



        [DisplayName("Last Name")]
        [Required]
        [StringLength(20)]
        public string LastName { get; set; }



        [DisplayName("Full Name")]
        public string FullName
        {
            get { return $"{FirstName} {LastName}"; }
        }



        [DisplayName("Annual Income")]
        [Range(0, 100000000)]
        [DataType(DataType.Currency)]
        public decimal? TargetSalary { get; set; }



        [DisplayName("Start Date")]
        [DataType(DataType.Date)]
        public DateTime? OptStartDate { get; set; }


        //Additional properties

        [DisplayName("D.O.B")]
        [DataType(DataType.Date)]
        public DateTime DOB { get; set; }



        [DisplayName("Email Id")]
        [Required]
        [StringLength(50)]
        public string EmailId { get; set; }



        [DisplayName("Phone Number")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression("\\(?\\d{3}\\)?-? *\\d{3}-? *-?\\d{4}", ErrorMessage = "Please enter valid phone number")]
        public long? ContactNo { get; set; }



        [DisplayName("Skills")]
        [StringLength(20)]
        public string? Skills { get; set; }



        [DisplayName("Work Ex")]

        public decimal WorkExp { get; set; }





        //Relationships

        [DisplayName("Company")]
        public Company Company { get; set; }
        [DisplayName("Job Title")]
        public JobTitle JobTitle { get; set; }
        [DisplayName("Industry")]
        public Industry Industry { get; set; }
        [DisplayName("Company")]
        public int CompanyId { get; set; }
        [DisplayName("Job Title")]
        public int JobTitleId { get; set; }
        [DisplayName("Industry")]
        public int IndustryId { get; set; }

    }
}