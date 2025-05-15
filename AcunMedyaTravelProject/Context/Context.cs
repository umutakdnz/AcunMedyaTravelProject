﻿using AcunMedyaTravelProject.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AcunMedyaTravelProject.Context
{
    public class Context : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<Services> Services { get; set; }
        public DbSet<Destinations> Destinations { get; set; }
        public DbSet<Sponsor> Sponsors { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Booking2> Bookings2 { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Mail> Mails { get; set; }
    }
}