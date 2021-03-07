using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProntMed.UI.AppTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace ProntMed.UI.AppTest.Data.Configuration
{
    public class TodoConfiguration : IEntityTypeConfiguration<TodoModel>
    {
        public void Configure(EntityTypeBuilder<TodoModel> builder)
        {
            builder.ToTable("tbTodos");
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Name).HasColumnType("VARCHAR(100)").IsRequired();
            builder.Property(p => p.Completed).HasColumnType("BIT").IsRequired();
        }
    }
}
