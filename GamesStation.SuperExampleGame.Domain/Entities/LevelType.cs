using System.Collections.Generic;

namespace GamesStation.SuperExampleGame.Domain.Entities
{
    public class LevelType : BaseEntity
    {
        public int? PreviousLevelTypeId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Range { get; set; }

        //Children
        public virtual LevelType PreviousLevelType { get; set; }

        //Parents
        public virtual List<ItemSkill> ItemSkills { get; set; }
    }
}