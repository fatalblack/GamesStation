namespace GamesStation.SuperExampleGame.Domain.Entities
{
    public class CharacterInventory : BaseEntity
    {
        public int CharacterId { get; set; }
        public int ItemId { get; set; }
        public int Quantity { get; set; }
        public bool Equipped { get; set; }

        //Children
        public virtual Character Character { get; set; }
        public virtual Item Item { get; set; }
    }
}