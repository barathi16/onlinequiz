﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace classlibrary
{
    public partial class ProjectContext : DbContext
    {
        public ProjectContext()
        {
        }

        public ProjectContext(DbContextOptions<ProjectContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Contactu> Contactus { get; set; }
        public virtual DbSet<Displayquestion> Displayquestions { get; set; }
        public virtual DbSet<Feedback> Feedbacks { get; set; }
        public virtual DbSet<Java> Javas { get; set; }
        public virtual DbSet<Loginadmin> Loginadmins { get; set; }
        public virtual DbSet<Loginuser> Loginusers { get; set; }
        public virtual DbSet<Register> Registers { get; set; }
        public virtual DbSet<Report> Reports { get; set; }
        public virtual DbSet<Techincal> Techincals { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=LENOVO\\SQLEXPRESS;Initial Catalog=project;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Contactu>(entity =>
            {
                entity.ToTable("contactus");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Email)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Fullname)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Message)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Phonenumber)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("phonenumber");
            });

            modelBuilder.Entity<Displayquestion>(entity =>
            {
                entity.HasKey(e => e.Qid)
                    .HasName("PK__displayq__CAB64A037A570813");

                entity.ToTable("displayquestion");

                entity.Property(e => e.Correctans).HasMaxLength(300);

                entity.Property(e => e.Courseid).HasColumnName("courseid");

                entity.Property(e => e.Levels)
                    .HasMaxLength(50)
                    .HasColumnName("levels");

                entity.Property(e => e.Option1).HasMaxLength(300);

                entity.Property(e => e.Option2).HasMaxLength(300);

                entity.Property(e => e.Option3).HasMaxLength(300);

                entity.Property(e => e.Option4).HasMaxLength(300);

                entity.Property(e => e.Question).HasMaxLength(300);
            });

            modelBuilder.Entity<Feedback>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("feedback");

                entity.Property(e => e.Country)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Firstname)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Lastname)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Msg)
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Java>(entity =>
            {
                entity.HasKey(e => e.Qid)
                    .HasName("PK__java__CAB64A03D78BCA10");

                entity.ToTable("java");

                entity.Property(e => e.Correctans).HasMaxLength(150);

                entity.Property(e => e.Courseid).HasColumnName("courseid");

                entity.Property(e => e.Levels)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("levels");

                entity.Property(e => e.Option1).HasMaxLength(150);

                entity.Property(e => e.Option2).HasMaxLength(150);

                entity.Property(e => e.Option3).HasMaxLength(150);

                entity.Property(e => e.Option4).HasMaxLength(150);

                entity.Property(e => e.Question).HasMaxLength(150);
            });

            modelBuilder.Entity<Loginadmin>(entity =>
            {
                entity.HasKey(e => e.Adminid)
                    .HasName("PK__loginadm__AD040D7EC5758CB6");

                entity.ToTable("loginadmin");

                entity.Property(e => e.Adminid).HasColumnName("adminid");

                entity.Property(e => e.Adminname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("adminname");

                entity.Property(e => e.Adminpwd)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("adminpwd");
            });

            modelBuilder.Entity<Loginuser>(entity =>
            {
                entity.HasKey(e => e.Userid)
                    .HasName("PK__loginuse__CBA1B257873171FD");

                entity.ToTable("loginuser");

                entity.Property(e => e.Userid).HasColumnName("userid");

                entity.Property(e => e.Username)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("username");

                entity.Property(e => e.Userpwd)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("userpwd");

                entity.HasOne(d => d.UsernameNavigation)
                    .WithMany(p => p.Loginusers)
                    .HasForeignKey(d => d.Username)
                    .HasConstraintName("FK__loginuser__usern__571DF1D5");
            });

            modelBuilder.Entity<Register>(entity =>
            {
                entity.HasKey(e => e.Username)
                    .HasName("PK__register__F3DBC573D934C033");

                entity.ToTable("register");

                entity.Property(e => e.Username)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("username");

                entity.Property(e => e.Confirmpwd)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("confirmpwd");

                entity.Property(e => e.Dob)
                    .HasColumnType("date")
                    .HasColumnName("dob");

                entity.Property(e => e.Email)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.Firstname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("firstname");

                entity.Property(e => e.Gender).HasColumnName("gender");

                entity.Property(e => e.Lastname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("lastname");

                entity.Property(e => e.Nationality)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("nationality");

                entity.Property(e => e.Phone)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("phone");

                entity.Property(e => e.Pwd)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("pwd");

                entity.Property(e => e.Registerid)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("registerid");
            });

            modelBuilder.Entity<Report>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("report");

                entity.Property(e => e.Coursename)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("coursename");

                entity.Property(e => e.Levels)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("levels");

                entity.Property(e => e.Sourceid).HasColumnName("sourceid");

                entity.Property(e => e.Statuss)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("statuss");

                entity.Property(e => e.Totalmarks).HasColumnName("totalmarks");

                entity.Property(e => e.Userid).HasColumnName("userid");

                entity.Property(e => e.Username)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("username");
            });

            modelBuilder.Entity<Techincal>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("techincal");

                entity.Property(e => e.Courseid).HasColumnName("courseid");

                entity.Property(e => e.Coursename)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("coursename");

                entity.Property(e => e.Levels)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("levels");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}