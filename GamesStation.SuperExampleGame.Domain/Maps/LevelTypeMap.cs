using GamesStation.SuperExampleGame.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GamesStation.SuperExampleGame.Domain.Maps
{
    public class LevelTypeMap
    {
        public LevelTypeMap(EntityTypeBuilder<LevelType> entityBuilder)
        {
            entityBuilder.HasKey(lt => lt.Id);
            entityBuilder.Property(lt => lt.PreviousLevelTypeId);
            entityBuilder.Property(lt => lt.Name)
                .HasMaxLength(30)
                .IsRequired();
            entityBuilder.Property(lt => lt.Description)
                .HasMaxLength(200);
            entityBuilder.Property(lt => lt.Range);

            entityBuilder.HasOne(lt => lt.PreviousLevelType);
        }
    }
}