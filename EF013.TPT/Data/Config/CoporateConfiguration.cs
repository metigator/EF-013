using EF013.TPT.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EF013.TPT.Data.Config
{
    internal class CoporateConfiguration : IEntityTypeConfiguration<Coporate>
    {
        public void Configure(EntityTypeBuilder<Coporate> builder)
        {
            builder.ToTable("Coporates");
        }
    }
}
