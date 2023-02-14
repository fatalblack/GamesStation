using GamesStation.SuperExampleGame.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GamesStation.SuperExampleGame.Domain.Maps
{
    public class SkillTypeMap
    {
        public SkillTypeMap(EntityTypeBuilder<SkillType> entityBuilder)
        {
            entityBuilder.HasKey(st => st.Id);
            entityBuilder.Property(st => st.Name)
                .HasMaxLength(30)
                .IsRequired();
            entityBuilder.Property(st => st.Description)
                .HasMaxLength(200);
        }
    }
}