using GamesStation.SuperExampleGame.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GamesStation.SuperExampleGame.Domain.Maps
{
    public class CharacterMap
    {
        public CharacterMap(EntityTypeBuilder<Character> entityBuilder)
        {
            entityBuilder.HasKey(c => c.Id);
            entityBuilder.Property(c => c.Name)
                .HasMaxLength(20)
                .IsRequired();
        }
    }
}