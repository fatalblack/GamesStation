using System.Collections.Generic;

namespace GamesStation.SuperExampleGame.Domain.Entities
{
    public class SkillType : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }

        //Parents
        public virtual List<ItemSkill> ItemSkills { get; set; }
    }
}