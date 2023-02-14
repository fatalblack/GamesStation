using System.Collections.Generic;

namespace GamesStation.SuperExampleGame.Domain.Entities
{
    public class Character : BaseEntity
    {
        public string Name { get; set; }

        //Parents
        public virtual List<CharacterMoney> MoneyList { get; set; }
        public virtual List<CharacterInventory> InventoryList { get; set; }
    }
}