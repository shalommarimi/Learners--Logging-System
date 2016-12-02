using Learn.BL;
using Logging_System.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Logging_System.EFramework
{
    public class Dal:DbContext
    {
        public DbSet<LearnersDetails> learners { get; set; }
        public DbSet<MentorLogin> mentors { get; set; }
        public DbSet<Administrator> admin { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            
            
                modelBuilder.Entity<LearnersDetails>().ToTable("Learners_Information");
                modelBuilder.Entity <LearnersDetails> ().HasKey(x => x.LearnerID);

                modelBuilder.Entity<MentorLogin>().ToTable("MentorsCredentials");
                modelBuilder.Entity <MentorLogin > ().HasKey(x => x.MentorID);

                modelBuilder.Entity<Administrator>().ToTable("Administrator");
                modelBuilder.Entity<Administrator>().HasKey(x => x.AdminID);
        }
        }
    }
