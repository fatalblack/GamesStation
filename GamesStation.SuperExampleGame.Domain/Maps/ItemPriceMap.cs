using GamesStation.SuperExampleGame.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GamesStation.SuperExampleGame.Domain.Maps
{
    public class ItemPriceMap
    {
        public ItemPriceMap(EntityTypeBuilder<ItemPrice> entityBuilder)
        {
            entityBuilder.HasKey(ip => ip.Id);
            entityBuilder.Property(ip => ip.ItemId).IsRequired();
            entityBuilder.Property(ip => ip.CurrencyTypeId).IsRequired();
            entityBuilder.Property(ip => ip.Price).IsRequired();

            entityBuilder.HasOne(ip => ip.Item)
                .WithMany(i => i.PriceList);

            entityBuilder.HasOne(ip => ip.CurrencyType)
                .WithMany(ct => ct.ItemPrices)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}