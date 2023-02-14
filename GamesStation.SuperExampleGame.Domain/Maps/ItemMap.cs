using GamesStation.SuperExampleGame.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GamesStation.SuperExampleGame.Domain.Maps
{
    public class ItemMap
    {
        public ItemMap(EntityTypeBuilder<Item> entityBuilder)
        {
            entityBuilder.HasKey(i => i.Id);
            entityBuilder.Property(i => i.ItemTypeId).IsRequired();
            entityBuilder.Property(i => i.Name)
                .HasMaxLength(40)
                .IsRequired();
            entityBuilder.Property(i => i.Description)
                .HasMaxLength(200);

            entityBuilder.HasOne(i => i.ItemType)
                .WithMany(it => it.Items);
        }
    }
}