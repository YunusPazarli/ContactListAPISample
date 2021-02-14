using Microsoft.EntityFrameworkCore;
using Statistics.API.Models.ORM.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Contact.API.Models.ORM.Context
{
    public class ContactsContext : DbContext
    {
       
            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
            optionsBuilder.UseNpgsql(@"Server=ec2-54-72-155-238.eu-west-1.compute.amazonaws.com;Database=d4g59udhc8oluh;
UID=snpxwqxqgyuvso;PWD=c113e62eaa0001f2688e06b7209bb02bbe8a3a517a3eee67bd5dd46fe1e4cbc1;SSL Mode= Require;TrustServerCertificate=True");
        }

            public DbSet<Stats> Stats { get; set; }
       
    }
}
