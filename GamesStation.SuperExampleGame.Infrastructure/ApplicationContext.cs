using GamesStation.SuperExampleGame.Domain.Entities;
using GamesStation.SuperExampleGame.Domain.Maps;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

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

            this.DataFeed(modelBuilder);
        }

        private void DataFeed(ModelBuilder modelBuilder)
        {
            var levelTypes = new List<LevelType>
            {
                new LevelType
                {
                    Id = 1,
                    Name = "Bronce",
                    Range = 0,
                    PreviousLevelTypeId = null
                },
                new LevelType
                {
                    Id = 2,
                    Name = "Plata",
                    Range = 10,
                    PreviousLevelTypeId = 1
                },
                new LevelType
                {
                    Id = 3,
                    Name = "Oro",
                    Range = 20,
                    PreviousLevelTypeId = 2
                },
                new LevelType
                {
                    Id = 4,
                    Name = "Platino",
                    Range = 30,
                    PreviousLevelTypeId = 3
                },
                new LevelType
                {
                    Id = 5,
                    Name = "Titanio",
                    Range = 40,
                    PreviousLevelTypeId = 4
                }
            };


            var skillTypes = new List<SkillType>
            {
                new SkillType
                {
                    Id = 1,
                    Name = "Velocidad"
                },
                new SkillType
                {
                    Id = 2,
                    Name = "Fuerza"
                },
                new SkillType
                {
                    Id = 3,
                    Name = "Resistencia"
                }
            };

            var currencyTypes = new List<CurrencyType>
            {
                new CurrencyType
                {
                    Id = 1,
                    Name = "Oro"
                },
                new CurrencyType
                {
                    Id = 2,
                    Name = "Diamante"
                }
            };

            var characters = new List<Character>
            {
                new Character
                {
                    Id = 1,
                    Name = "PulpoManotas",
                    InventoryList = null
                }
            };

            var characterMoneys = new List<CharacterMoney>
            {
                new CharacterMoney
                {
                    Id = 1,
                    CharacterId = 1,
                    CurrencyTypeId = 1,
                    Money = 10000
                },
                new CharacterMoney
                {
                    Id = 2,
                    CharacterId = 1,
                    CurrencyTypeId = 2,
                    Money = 10000
                }
            };

            var itemTypes = new List<ItemType>
            {
                new ItemType
                {
                    Id = 1,
                    Name = "Arma"
                },
                new ItemType
                {
                    Id = 2,
                    Name = "Armadura"
                },
                new ItemType
                {
                    Id = 3,
                    Name = "Accesorio"
                }
            };

            var items = new List<Item>
            {
                new Item
                {
                    Id = 1,
                    Name = "Espada",
                    ItemTypeId = 1
                },
                new Item
                {
                    Id = 2,
                    Name = "Pechera",
                    ItemTypeId = 2
                },
                new Item
                {
                    Id = 3,
                    Name = "Runa de Velocidad",
                    ItemTypeId = 3
                },
                new Item
                {
                    Id = 4,
                    Name = "Runa de Fuerza",
                    ItemTypeId = 3
                },
                new Item
                {
                    Id = 5,
                    Name = "Runa de Resistencia",
                    ItemTypeId = 3
                }
            };

            var itemPrices = new List<ItemPrice>
            {
                new ItemPrice //espada oro
                {
                    Id = 1,
                    ItemId = 1,
                    CurrencyTypeId = 1,
                    Price = 10
                },
                new ItemPrice //espada diamante
                {
                    Id = 2,
                    ItemId = 1,
                    CurrencyTypeId = 2,
                    Price = 10
                },
                new ItemPrice //pechera oro
                {
                    Id = 3,
                    ItemId = 2,
                    CurrencyTypeId = 1,
                    Price = 15
                },
                new ItemPrice //runa velocidad oro
                {
                    Id = 4,
                    ItemId = 3,
                    CurrencyTypeId = 1,
                    Price = 5
                },
                new ItemPrice //runa fuerza oro
                {
                    Id = 5,
                    ItemId = 4,
                    CurrencyTypeId = 1,
                    Price = 5
                },
                new ItemPrice //runa resistencia oro
                {
                    Id = 6,
                    ItemId = 5,
                    CurrencyTypeId = 1,
                    Price = 5
                }
            };

            var itemSkills = new List<ItemSkill>
            {
                new ItemSkill //espada velocidad bronce
                {
                    Id = 1,
                    ItemId = 1,
                    SkillTypeId = 1,
                    LevelTypeId = 1,
                    Grade = 3
                },
                new ItemSkill //espada fuerza bronce
                {
                    Id = 2,
                    ItemId = 1,
                    SkillTypeId = 2,
                    LevelTypeId = 1,
                    Grade = 6
                },
                new ItemSkill //pechera fuerza bronce
                {
                    Id = 3,
                    ItemId = 2,
                    SkillTypeId = 2,
                    LevelTypeId = 1,
                    Grade = 3
                },
                new ItemSkill //pechera resistencia bronce
                {
                    Id = 4,
                    ItemId = 2,
                    SkillTypeId = 3,
                    LevelTypeId = 1,
                    Grade = 6
                },
                new ItemSkill //runa velocidad bronce
                {
                    Id = 5,
                    ItemId = 3,
                    SkillTypeId = 1,
                    LevelTypeId = 1,
                    Grade = 1
                },
                new ItemSkill //runa fuerza bronce
                {
                    Id = 6,
                    ItemId = 4,
                    SkillTypeId = 2,
                    LevelTypeId = 1,
                    Grade = 1
                },
                new ItemSkill //runa resistencia bronce
                {
                    Id = 7,
                    ItemId = 5,
                    SkillTypeId = 3,
                    LevelTypeId = 1,
                    Grade = 1
                }
            };

            modelBuilder.Entity<LevelType>().HasData(levelTypes);
            modelBuilder.Entity<SkillType>().HasData(skillTypes);
            modelBuilder.Entity<CurrencyType>().HasData(currencyTypes);
            modelBuilder.Entity<Character>().HasData(characters);
            modelBuilder.Entity<CharacterMoney>().HasData(characterMoneys);
            modelBuilder.Entity<ItemType>().HasData(itemTypes);
            modelBuilder.Entity<Item>().HasData(items);
            modelBuilder.Entity<ItemPrice>().HasData(itemPrices);
            modelBuilder.Entity<ItemSkill>().HasData(itemSkills);
        }
    }
}