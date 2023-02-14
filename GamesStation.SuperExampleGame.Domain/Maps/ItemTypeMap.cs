using GamesStation.SuperExampleGame.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GamesStation.SuperExampleGame.Domain.Maps
{
    public class ItemTypeMap
    {
        public ItemTypeMap(EntityTypeBuilder<ItemType> entityBuilder)
        {
            entityBuilder.HasKey(it => it.Id);
            entityBuilder.Property(it => it.Name)
                .HasMaxLength(30)
                .IsRequired();
            entityBuilder.Property(it => it.Description)
                .HasMaxLength(200);
        }
    }
}