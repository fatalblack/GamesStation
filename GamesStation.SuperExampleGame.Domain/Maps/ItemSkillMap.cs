using GamesStation.SuperExampleGame.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GamesStation.SuperExampleGame.Domain.Maps
{
    public class ItemSkillMap
    {
        public ItemSkillMap(EntityTypeBuilder<ItemSkill> entityBuilder)
        {
            entityBuilder.HasKey(isk => isk.Id);
            entityBuilder.Property(isk => isk.ItemId).IsRequired();
            entityBuilder.Property(isk => isk.SkillTypeId).IsRequired();
            entityBuilder.Property(isk => isk.LevelTypeId).IsRequired();
            entityBuilder.Property(isk => isk.Grade).IsRequired();

            entityBuilder.HasOne(isk => isk.Item)
                .WithMany(i => i.SkillList);

            entityBuilder.HasOne(isk => isk.SkillType)
                .WithMany(st => st.ItemSkills);

            entityBuilder.HasOne(isk => isk.LevelType)
                .WithMany(lt => lt.ItemSkills);
        }
    }
}