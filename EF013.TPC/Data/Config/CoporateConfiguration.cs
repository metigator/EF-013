using EF013.TPC.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EF013.TPC.Data.Config
{
    internal class CoporateConfiguration : IEntityTypeConfiguration<Coporate>
    {
        public void Configure(EntityTypeBuilder<Coporate> builder)
        {
            builder.ToTable("Coporates");
        }
    }
}
