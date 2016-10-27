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
        public DbSet<LearnerLogin> learners { get; set; }
        public DbSet<MentorLogin> mentors { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            
            
                modelBuilder.Entity<LearnerLogin>().ToTable("LearnersCredentials");
                modelBuilder.Entity<LearnerLogin>().HasKey(x => x.UserID);

                modelBuilder.Entity<MentorLogin>().ToTable("MentorsCredentials");
                modelBuilder.Entity <MentorLogin > ().HasKey(x => x.MentorID);
        }
        }
    }
