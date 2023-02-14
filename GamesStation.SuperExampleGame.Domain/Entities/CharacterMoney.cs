namespace GamesStation.SuperExampleGame.Domain.Entities
{
    public class CharacterMoney : BaseEntity
    {
        public int CharacterId { get; set; }
        public int CurrencyTypeId { get; set; }
        public int Money { get; set; }

        //Children
        public virtual Character Character { get; set; }
        public virtual CurrencyType CurrencyType { get; set; }
    }
}