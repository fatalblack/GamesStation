using GamesStation.SuperExampleGame.Domain.Entities;

namespace GamesStation.SuperExampleGame.Dto.LevelTypeDtos
{
    public class LevelTypeResponseDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Range { get; set; }

        public LevelTypeResponseDto() { }

        public LevelTypeResponseDto(LevelType levelType)
        {
            this.Id = levelType.Id;
            this.Name = levelType.Name;
            this.Description = levelType.Description;
            this.Range = levelType.Range;
        }
    }
}