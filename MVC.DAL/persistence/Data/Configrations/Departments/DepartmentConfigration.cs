using Microsoft.EntityFrameworkCore;
using MVC.DAL.Models.Departments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC.DAL.persistence.Data.Configrations.Departments
{
    internal class DepartmentConfigration : IEntityTypeConfiguration<Department>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Department> builder)
        {
            builder.Property(D => D.Id).UseIdentityColumn(10, 10);
            builder.Property(D=>D.Name).HasColumnType("nvarchar(50)").IsRequired();
            builder.Property(D=>D.Code).HasColumnType("nvarchar(50)").IsRequired();
            builder.Property(D=>D.ModifiedDate).HasComputedColumnSql("getdate()");
            builder.Property(D => D.CreatedDate).HasDefaultValueSql("getdate()");
        }
    }
}
