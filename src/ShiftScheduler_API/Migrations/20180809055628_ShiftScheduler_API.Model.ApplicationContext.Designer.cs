using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using ShiftScheduler_API.Model;

namespace ShiftScheduler_API.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20180809055628_ShiftScheduler_API.Model.ApplicationContext")]
    partial class ShiftScheduler_APIModelApplicationContext
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.1")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ShiftScheduler_API.Model.Employee_M", b =>
                {
                    b.Property<short>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<short>("Active");

                    b.Property<string>("Emp_ID");

                    b.Property<string>("Emp_Name");

                    b.HasKey("Id");

                    b.ToTable("Employee");
                });
        }
    }
}
