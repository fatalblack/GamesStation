using Microsoft.EntityFrameworkCore.Migrations;

namespace GamesStation.SuperExampleGame.Infrastructure.Migrations
{
    public partial class FirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Character",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Character", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CurrencyType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CurrencyType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ItemType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LevelType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PreviousLevelTypeId = table.Column<int>(type: "int", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Range = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LevelType", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LevelType_LevelType_PreviousLevelTypeId",
                        column: x => x.PreviousLevelTypeId,
                        principalTable: "LevelType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SkillType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SkillType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CharacterMoney",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CharacterId = table.Column<int>(type: "int", nullable: false),
                    CurrencyTypeId = table.Column<int>(type: "int", nullable: false),
                    Money = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharacterMoney", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CharacterMoney_Character_CharacterId",
                        column: x => x.CharacterId,
                        principalTable: "Character",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CharacterMoney_CurrencyType_CurrencyTypeId",
                        column: x => x.CurrencyTypeId,
                        principalTable: "CurrencyType",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Item",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ItemTypeId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Item", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Item_ItemType_ItemTypeId",
                        column: x => x.ItemTypeId,
                        principalTable: "ItemType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CharacterInventory",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CharacterId = table.Column<int>(type: "int", nullable: false),
                    ItemId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Equipped = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharacterInventory", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CharacterInventory_Character_CharacterId",
                        column: x => x.CharacterId,
                        principalTable: "Character",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CharacterInventory_Item_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Item",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ItemPrice",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ItemId = table.Column<int>(type: "int", nullable: false),
                    CurrencyTypeId = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemPrice", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ItemPrice_CurrencyType_CurrencyTypeId",
                        column: x => x.CurrencyTypeId,
                        principalTable: "CurrencyType",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ItemPrice_Item_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Item",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ItemSkill",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ItemId = table.Column<int>(type: "int", nullable: false),
                    SkillTypeId = table.Column<int>(type: "int", nullable: false),
                    LevelTypeId = table.Column<int>(type: "int", nullable: false),
                    Grade = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemSkill", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ItemSkill_Item_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Item",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ItemSkill_LevelType_LevelTypeId",
                        column: x => x.LevelTypeId,
                        principalTable: "LevelType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ItemSkill_SkillType_SkillTypeId",
                        column: x => x.SkillTypeId,
                        principalTable: "SkillType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "PulpoManotas" });

            migrationBuilder.InsertData(
                table: "CurrencyType",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, null, "Oro" },
                    { 2, null, "Diamante" }
                });

            migrationBuilder.InsertData(
                table: "ItemType",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, null, "Arma" },
                    { 2, null, "Armadura" },
                    { 3, null, "Accesorio" }
                });

            migrationBuilder.InsertData(
                table: "LevelType",
                columns: new[] { "Id", "Description", "Name", "PreviousLevelTypeId", "Range" },
                values: new object[] { 1, null, "Bronce", null, 0 });

            migrationBuilder.InsertData(
                table: "SkillType",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, null, "Velocidad" },
                    { 2, null, "Fuerza" },
                    { 3, null, "Resistencia" }
                });

            migrationBuilder.InsertData(
                table: "CharacterMoney",
                columns: new[] { "Id", "CharacterId", "CurrencyTypeId", "Money" },
                values: new object[,]
                {
                    { 1, 1, 1, 10000 },
                    { 2, 1, 2, 10000 }
                });

            migrationBuilder.InsertData(
                table: "Item",
                columns: new[] { "Id", "Description", "ItemTypeId", "Name" },
                values: new object[,]
                {
                    { 1, null, 1, "Espada" },
                    { 2, null, 2, "Pechera" },
                    { 3, null, 3, "Runa de Velocidad" },
                    { 4, null, 3, "Runa de Fuerza" },
                    { 5, null, 3, "Runa de Resistencia" }
                });

            migrationBuilder.InsertData(
                table: "LevelType",
                columns: new[] { "Id", "Description", "Name", "PreviousLevelTypeId", "Range" },
                values: new object[] { 2, null, "Plata", 1, 10 });

            migrationBuilder.InsertData(
                table: "ItemPrice",
                columns: new[] { "Id", "CurrencyTypeId", "ItemId", "Price" },
                values: new object[,]
                {
                    { 1, 1, 1, 10 },
                    { 2, 2, 1, 10 },
                    { 3, 1, 2, 15 },
                    { 4, 1, 3, 5 },
                    { 5, 1, 4, 5 },
                    { 6, 1, 5, 5 }
                });

            migrationBuilder.InsertData(
                table: "ItemSkill",
                columns: new[] { "Id", "Grade", "ItemId", "LevelTypeId", "SkillTypeId" },
                values: new object[,]
                {
                    { 1, 3, 1, 1, 1 },
                    { 2, 6, 1, 1, 2 },
                    { 3, 3, 2, 1, 2 },
                    { 4, 6, 2, 1, 3 },
                    { 5, 1, 3, 1, 1 },
                    { 6, 1, 4, 1, 2 },
                    { 7, 1, 5, 1, 3 }
                });

            migrationBuilder.InsertData(
                table: "LevelType",
                columns: new[] { "Id", "Description", "Name", "PreviousLevelTypeId", "Range" },
                values: new object[] { 3, null, "Oro", 2, 20 });

            migrationBuilder.InsertData(
                table: "LevelType",
                columns: new[] { "Id", "Description", "Name", "PreviousLevelTypeId", "Range" },
                values: new object[] { 4, null, "Platino", 3, 30 });

            migrationBuilder.InsertData(
                table: "LevelType",
                columns: new[] { "Id", "Description", "Name", "PreviousLevelTypeId", "Range" },
                values: new object[] { 5, null, "Titanio", 4, 40 });

            migrationBuilder.CreateIndex(
                name: "IX_CharacterInventory_CharacterId",
                table: "CharacterInventory",
                column: "CharacterId");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterInventory_ItemId",
                table: "CharacterInventory",
                column: "ItemId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CharacterMoney_CharacterId",
                table: "CharacterMoney",
                column: "CharacterId");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterMoney_CurrencyTypeId",
                table: "CharacterMoney",
                column: "CurrencyTypeId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Item_ItemTypeId",
                table: "Item",
                column: "ItemTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemPrice_CurrencyTypeId",
                table: "ItemPrice",
                column: "CurrencyTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemPrice_ItemId",
                table: "ItemPrice",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemSkill_ItemId",
                table: "ItemSkill",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemSkill_LevelTypeId",
                table: "ItemSkill",
                column: "LevelTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemSkill_SkillTypeId",
                table: "ItemSkill",
                column: "SkillTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_LevelType_PreviousLevelTypeId",
                table: "LevelType",
                column: "PreviousLevelTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CharacterInventory");

            migrationBuilder.DropTable(
                name: "CharacterMoney");

            migrationBuilder.DropTable(
                name: "ItemPrice");

            migrationBuilder.DropTable(
                name: "ItemSkill");

            migrationBuilder.DropTable(
                name: "Character");

            migrationBuilder.DropTable(
                name: "CurrencyType");

            migrationBuilder.DropTable(
                name: "Item");

            migrationBuilder.DropTable(
                name: "LevelType");

            migrationBuilder.DropTable(
                name: "SkillType");

            migrationBuilder.DropTable(
                name: "ItemType");
        }
    }
}
