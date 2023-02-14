using GamesStation.SuperExampleGame.Domain.Entities;

namespace GamesStation.SuperExampleGame.Dto.ItemTypeDtos
{
    public class ItemTypeResponseDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public ItemTypeResponseDto() { }

        public ItemTypeResponseDto(ItemType itemType)
        {
            this.Id = itemType.Id;
            this.Name = itemType.Name;
            this.Description = itemType.Description;
        }
    }
}