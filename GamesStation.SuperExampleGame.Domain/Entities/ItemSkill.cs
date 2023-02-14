namespace GamesStation.SuperExampleGame.Domain.Entities
{
    public class ItemSkill : BaseEntity
    {
        public int ItemId { get; set; }
        public int SkillTypeId { get; set; }
        public int LevelTypeId { get; set; }
        public int Grade { get; set; }

        //Children
        public virtual Item Item { get; set; }
        public virtual SkillType SkillType { get; set; }
        public virtual LevelType LevelType { get; set; }
    }
}