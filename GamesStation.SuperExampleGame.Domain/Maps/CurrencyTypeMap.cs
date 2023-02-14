using GamesStation.SuperExampleGame.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GamesStation.SuperExampleGame.Domain.Maps
{
    public class CurrencyTypeMap
    {
        public CurrencyTypeMap(EntityTypeBuilder<CurrencyType> entityBuilder)
        {
            entityBuilder.HasKey(ct => ct.Id);
            entityBuilder.Property(ct => ct.Name)
                .HasMaxLength(30)
                .IsRequired();
            entityBuilder.Property(ct => ct.Description)
                .HasMaxLength(200);
        }
    }
}