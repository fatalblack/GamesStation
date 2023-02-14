using System.Collections.Generic;

namespace GamesStation.SuperExampleGame.Domain.Entities
{
    public class ItemType : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }

        //Parents
        public virtual List<Item> Items { get; set; }
    }
}