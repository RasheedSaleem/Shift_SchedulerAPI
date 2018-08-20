using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using ShiftScheduler_API.Model;

namespace ShiftScheduler_API.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20180810040628_SheduleDateTable")]
    partial class SheduleDateTable
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

            modelBuilder.Entity("ShiftScheduler_API.Model.EmployeeShedule", b =>
                {
                    b.Property<short>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Emp_Id");

                    b.Property<DateTime>("Schedule_Date");

                    b.Property<string>("Shift_Id");

                    b.HasKey("Id");

                    b.ToTable("EmployeeShedule");
                });

            modelBuilder.Entity("ShiftScheduler_API.Model.Shift_M", b =>
                {
                    b.Property<short>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Shift_Desc");

                    b.Property<string>("Shift_Id");

                    b.HasKey("Id");

                    b.ToTable("Shift");
                });
        }
    }
}
