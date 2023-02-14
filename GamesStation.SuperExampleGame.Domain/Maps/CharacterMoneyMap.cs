using GamesStation.SuperExampleGame.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GamesStation.SuperExampleGame.Domain.Maps
{
    public class CharacterMoneyMap
    {
        public CharacterMoneyMap(EntityTypeBuilder<CharacterMoney> entityBuilder)
        {
            entityBuilder.HasKey(cm => cm.Id);
            entityBuilder.Property(cm => cm.CharacterId).IsRequired();
            entityBuilder.Property(cm => cm.CurrencyTypeId).IsRequired();
            entityBuilder.Property(cm => cm.Money).IsRequired();

            entityBuilder.HasOne(cm => cm.Character)
                .WithMany(c => c.MoneyList);

            entityBuilder.HasOne(cm => cm.CurrencyType)
                .WithOne(c => c.CharacterMoney)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}