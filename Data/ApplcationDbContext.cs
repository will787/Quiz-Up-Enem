using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using QuizUpEnem.Models;

    public class ApplcationDbContext : DbContext
    {
        public ApplcationDbContext (DbContextOptions<ApplcationDbContext> options)
            : base(options)
        {
        }

        public DbSet<QuizUpEnem.Models.AppQuizEnem> AppQuizEnem { get; set; } = default!;
    }
