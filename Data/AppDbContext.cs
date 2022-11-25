using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Task_Reminder_Api_Project_1.Data.Models;

namespace Task_Reminder_Api_Project_1.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext (DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Reminder> Reminder { get; set; } = default!;
    }
}
