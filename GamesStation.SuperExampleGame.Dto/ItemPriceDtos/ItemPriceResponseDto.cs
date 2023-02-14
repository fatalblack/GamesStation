using GamesStation.SuperExampleGame.Domain.Entities;
using GamesStation.SuperExampleGame.Dto.CurrencyTypeDtos;

namespace GamesStation.SuperExampleGame.Dto.ItemPriceDtos
{
    public class ItemPriceResponseDto
    {
        public int Id { get; set; }
        public int Price { get; set; }
        public CurrencyTypeResponseDto CurrencyType { get; set; }

        public ItemPriceResponseDto() { }

        public ItemPriceResponseDto(ItemPrice itemPrice)
        {
            this.Id = itemPrice.Id;
            this.Price = itemPrice.Price;
            this.CurrencyType = itemPrice.CurrencyType != null ? new CurrencyTypeResponseDto(itemPrice.CurrencyType) : null;
        }
    }
}