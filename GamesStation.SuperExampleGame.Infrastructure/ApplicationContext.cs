using GamesStation.SuperExampleGame.Domain.Entities;
using GamesStation.SuperExampleGame.Domain.Maps;
using Microsoft.EntityFrameworkCore;

namespace GamesStation.SuperExampleGame.Infrastructure
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            _ = new CharacterMap(modelBuilder.Entity<Character>());
            _ = new CharacterInventoryMap(modelBuilder.Entity<CharacterInventory>());
            _ = new CharacterMoneyMap(modelBuilder.Entity<CharacterMoney>());
            _ = new CurrencyTypeMap(modelBuilder.Entity<CurrencyType>());
            _ = new ItemMap(modelBuilder.Entity<Item>());
            _ = new ItemPriceMap(modelBuilder.Entity<ItemPrice>());
            _ = new ItemSkillMap(modelBuilder.Entity<ItemSkill>());
            _ = new ItemTypeMap(modelBuilder.Entity<ItemType>());
            _ = new LevelTypeMap(modelBuilder.Entity<LevelType>());
            _ = new SkillTypeMap(modelBuilder.Entity<SkillType>());
        }
    }
}