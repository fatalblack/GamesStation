using GamesStation.SuperExampleGame.Domain.Entities;

namespace GamesStation.SuperExampleGame.Dto.CharacterDtos
{
    public class CharacterResponseDto
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public CharacterResponseDto() { }

        public CharacterResponseDto(Character character)
        {
            this.Id = character.Id;
            this.Name = character.Name;
        }
    }
}