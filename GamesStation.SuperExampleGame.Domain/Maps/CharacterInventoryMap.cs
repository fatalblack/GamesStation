using GamesStation.SuperExampleGame.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GamesStation.SuperExampleGame.Domain.Maps
{
    public class CharacterInventoryMap
    {
        public CharacterInventoryMap(EntityTypeBuilder<CharacterInventory> entityBuilder)
        {
            entityBuilder.HasKey(ci => ci.Id);
            entityBuilder.Property(ci => ci.CharacterId).IsRequired();
            entityBuilder.Property(ci => ci.ItemId).IsRequired();
            entityBuilder.Property(ci => ci.Quantity).IsRequired();
            entityBuilder.Property(ci => ci.Equipped).IsRequired();

            entityBuilder.HasOne(ci => ci.Character)
                .WithMany(c => c.InventoryList);

            entityBuilder.HasOne(ci => ci.Item)
                .WithOne(i => i.CharacterInventory);
        }
    }
}