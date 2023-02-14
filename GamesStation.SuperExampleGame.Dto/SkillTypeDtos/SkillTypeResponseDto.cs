using GamesStation.SuperExampleGame.Domain.Entities;

namespace GamesStation.SuperExampleGame.Dto.SkillTypeDtos
{
    public class SkillTypeResponseDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public SkillTypeResponseDto() { }

        public SkillTypeResponseDto(SkillType skillType)
        {
            this.Id = skillType.Id;
            this.Name = skillType.Name;
            this.Description = skillType.Description;
        }
    }
}