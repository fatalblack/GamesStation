namespace GamesStation.SuperExampleGame.Domain.Entities
{
    public class ItemPrice : BaseEntity
    {
        public int ItemId { get; set; }
        public int CurrencyTypeId { get; set; }
        public int Price { get; set; }

        //Children
        public virtual Item Item { get; set; }
        public virtual CurrencyType CurrencyType { get; set; }
    }
}