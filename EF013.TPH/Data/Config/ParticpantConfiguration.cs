using EF013.TPH.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EF013.TPH.Data.Config
{
    public class ParticpantConfiguration : IEntityTypeConfiguration<Participant>
    {
        public void Configure(EntityTypeBuilder<Participant> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedNever();

            builder.Property(x => x.FName)
                .HasColumnType("VARCHAR")
                .HasMaxLength(50).IsRequired();

            builder.Property(x => x.LName)
            .HasColumnType("VARCHAR")
            .HasMaxLength(50).IsRequired();

            builder.HasDiscriminator<string>("ParticipantType")
                .HasValue<Individual>("INDV")
                .HasValue<Coporate>("COPR");

            builder.Property("ParticipantType").HasColumnType("VARCHAR")
                .HasMaxLength(4);


            builder.ToTable("Particpants");
        }
    }
}
