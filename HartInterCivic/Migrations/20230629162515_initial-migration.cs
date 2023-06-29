using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HartInterCivic.Migrations
{
    /// <inheritdoc />
    public partial class initialmigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "HartInterCivic");

            migrationBuilder.CreateTable(
                name: "Item",
                schema: "HartInterCivic",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Count = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Item", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TimerConfiguration",
                schema: "HartInterCivic",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Interval = table.Column<int>(type: "int", nullable: false),
                    AutoStart = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TimerConfiguration", x => x.Id);
                });

            migrationBuilder.InsertData(
                schema: "HartInterCivic",
                table: "Item",
                columns: new[] { "Id", "Count", "Description" },
                values: new object[,]
                {
                    { 1, 1, "Laptop" },
                    { 2, 2, "Mouse" }
                });

            migrationBuilder.InsertData(
                schema: "HartInterCivic",
                table: "TimerConfiguration",
                columns: new[] { "Id", "AutoStart", "Interval" },
                values: new object[] { 1, true, 60 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Item",
                schema: "HartInterCivic");

            migrationBuilder.DropTable(
                name: "TimerConfiguration",
                schema: "HartInterCivic");
        }
    }
}
