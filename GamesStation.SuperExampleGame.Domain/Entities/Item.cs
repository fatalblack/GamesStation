using System.Collections.Generic;

namespace GamesStation.SuperExampleGame.Domain.Entities
{
    public class Item : BaseEntity
    {
        public int ItemTypeId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        //Children
        public virtual ItemType ItemType { get; set; }

        //Parents
        public virtual List<ItemPrice> PriceList { get; set; }
        public virtual List<ItemSkill> SkillList { get; set; }
        public virtual CharacterInventory CharacterInventory { get; set; }
    }
}