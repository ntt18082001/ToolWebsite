using App.Data.Entities;
using App.Share.Consts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Data.Configurations
{
	public class AppSourceCodeConfig : IEntityTypeConfiguration<AppSourceCode>
	{
		public void Configure(EntityTypeBuilder<AppSourceCode> builder)
		{
			builder.ToTable(DB.AppSourceCode.TABLE_NAME);

			builder.HasKey(m => m.Id);

			builder.Property(m => m.Name)
				.HasMaxLength(DB.AppSourceCode.NAME_LENGTH);

			// Khóa ngoại với AppUser
			builder.HasOne(m => m.OwnerUser)
				.WithMany(m => m.AppSourceCode)
				.HasForeignKey(m => m.OwnerUserId);
		}
	}
}
