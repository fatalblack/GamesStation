using GamesStation.SuperExampleGame.Domain.Entities;
using GamesStation.SuperExampleGame.Dto.LevelTypeDtos;
using GamesStation.SuperExampleGame.Dto.SkillTypeDtos;

namespace GamesStation.SuperExampleGame.Dto.ItemSkillDtos
{
    public class ItemSkillResponseDto
    {
        public int Id { get; set; }
        public int Grade { get; set; }
        public SkillTypeResponseDto SkillType { get; set; }
        public LevelTypeResponseDto LevelType { get; set; }

        public ItemSkillResponseDto() { }

        public ItemSkillResponseDto(ItemSkill itemSkill)
        {
            this.Id = itemSkill.Id;
            this.Grade = itemSkill.Grade;
            this.SkillType = itemSkill.SkillType != null ? new SkillTypeResponseDto(itemSkill.SkillType) : null;
            this.LevelType = itemSkill.LevelType != null ? new LevelTypeResponseDto(itemSkill.LevelType) : null;
        }
    }
}