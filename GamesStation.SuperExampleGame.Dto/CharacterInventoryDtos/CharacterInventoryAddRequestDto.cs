using GamesStation.SuperExampleGame.Domain.Entities;

namespace GamesStation.SuperExampleGame.Dto.CharacterInventoryDtos
{
    public class CharacterInventoryAddRequestDto
    {
        public int CharacterId { get; set; }
        public int ItemId { get; set; }

        public CharacterInventoryAddRequestDto() { }

        public CharacterInventoryAddRequestDto(int characterId, int itemId)
        {
            this.CharacterId = characterId;
            this.ItemId = itemId;
        }

        public CharacterInventory AsEntity()
        {
            return new CharacterInventory
            {
                CharacterId = this.CharacterId,
                ItemId = this.ItemId,
                Quantity = 1,
                Equipped = true
            };
        }
    }
}