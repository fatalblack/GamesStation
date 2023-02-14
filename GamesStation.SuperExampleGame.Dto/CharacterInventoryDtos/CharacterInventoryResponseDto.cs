using GamesStation.SuperExampleGame.Domain.Entities;
using GamesStation.SuperExampleGame.Dto.ItemDtos;

namespace GamesStation.SuperExampleGame.Dto.CharacterInventoryDtos
{
    public class CharacterInventoryResponseDto
    {
        public int Id { get; set; }
        public ItemResponseDto Item { get; set; }

        public CharacterInventoryResponseDto() { }

        public CharacterInventoryResponseDto(CharacterInventory characterInventory)
        {
            this.Id = characterInventory.Id;
            this.Item = characterInventory.Item != null ? new ItemResponseDto(characterInventory.Item) : null;
        }
    }
}