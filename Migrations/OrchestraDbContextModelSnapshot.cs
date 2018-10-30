﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OrchestraPoc.Models;

namespace OrchestraPoc.Migrations
{
    [DbContext(typeof(OrchestraDbContext))]
    partial class OrchestraDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024");

            modelBuilder.Entity("OrchestraPoc.Models.Job", b =>
                {
                    b.Property<int>("JobId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Input");

                    b.Property<int>("QueueId");

                    b.HasKey("JobId");

                    b.HasIndex("QueueId");

                    b.ToTable("Jobs");
                });

            modelBuilder.Entity("OrchestraPoc.Models.Queue", b =>
                {
                    b.Property<int>("QueueId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Workflow");

                    b.HasKey("QueueId");

                    b.ToTable("Queues");
                });

            modelBuilder.Entity("OrchestraPoc.Models.Job", b =>
                {
                    b.HasOne("OrchestraPoc.Models.Queue", "Queue")
                        .WithMany()
                        .HasForeignKey("QueueId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
