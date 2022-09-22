using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RecruitCatPinisera.Models;

    public class OrgDb : DbContext
    {
        public OrgDb (DbContextOptions<OrgDb> options)
            : base(options)
        {
        }

        public DbSet<RecruitCatPinisera.Models.Candidate> Candidate { get; set; } = default!;

        public DbSet<RecruitCatPinisera.Models.Company>? Company { get; set; }

        public DbSet<RecruitCatPinisera.Models.Industry>? Industry { get; set; }

        public DbSet<RecruitCatPinisera.Models.JobTitle>? JobTitle { get; set; }
    }
