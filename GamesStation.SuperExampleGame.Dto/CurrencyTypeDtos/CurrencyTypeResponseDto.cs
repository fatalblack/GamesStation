using GamesStation.SuperExampleGame.Domain.Entities;

namespace GamesStation.SuperExampleGame.Dto.CurrencyTypeDtos
{
    public class CurrencyTypeResponseDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public CurrencyTypeResponseDto() { }

        public CurrencyTypeResponseDto(CurrencyType currencyType)
        {
            this.Id = currencyType.Id;
            this.Name = currencyType.Name;
            this.Description = currencyType.Description;
        }
    }
}