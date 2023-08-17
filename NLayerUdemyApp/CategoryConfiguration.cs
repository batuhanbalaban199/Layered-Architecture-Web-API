using System;
using System.Collection.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class CategoryConfiguration
{
	public CategoryConfiguration : IEntityTypeConfiguration<Category>
	{
		builder.HasKey(x=> x.Id)
		builder.Property(x=> x.Id).UseIdentityColumn();
		builder.Property(x=> x.Name).IsRequired().HasMaxLength(50);
		builder.ToTable("Categories");
	}
}
