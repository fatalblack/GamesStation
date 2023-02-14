using GamesStation.SuperExampleGame.Domain.Entities;
using GamesStation.SuperExampleGame.Dto.ItemPriceDtos;
using GamesStation.SuperExampleGame.Dto.ItemSkillDtos;
using GamesStation.SuperExampleGame.Dto.ItemTypeDtos;
using System.Collections.Generic;
using System.Linq;

namespace GamesStation.SuperExampleGame.Dto.ItemDtos
{
    public class ItemResponseDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public ItemTypeResponseDto ItemType { get; set; }
        public List<ItemPriceResponseDto> PriceList { get; set; }
        public List<ItemSkillResponseDto> SkillList { get; set; }

        public ItemResponseDto() { }

        public ItemResponseDto(Item item)
        {
            this.Id = item.Id;
            this.Name = item.Name;
            this.Description = item.Description;

            this.ItemType = item.ItemType != null ? new ItemTypeResponseDto(item.ItemType) : null;
            this.PriceList = item.PriceList != null ?
                item.PriceList.Select(l => new ItemPriceResponseDto(l)).ToList() :
                new List<ItemPriceResponseDto>();
            this.SkillList = item.SkillList != null ?
                item.SkillList.Select(l => new ItemSkillResponseDto(l)).ToList() :
                new List<ItemSkillResponseDto>();
        }
    }
}