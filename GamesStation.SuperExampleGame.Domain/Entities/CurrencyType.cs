using System.Collections.Generic;

namespace GamesStation.SuperExampleGame.Domain.Entities
{
    public class CurrencyType : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }

        //Parents
        public virtual CharacterMoney CharacterMoney { get; set; }
        public virtual List<ItemPrice> ItemPrices { get; set; }
    }
}