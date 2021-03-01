using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CoreRoutes.Migrations
{
    public partial class DeliveryChecking : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DeliveryStates",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeliveryStates", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DeliveryCheckings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserFK = table.Column<int>(type: "int", nullable: false),
                    RouteFK = table.Column<int>(type: "int", nullable: false),
                    DeliveryStateFK = table.Column<int>(type: "int", nullable: false),
                    DeliveryDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeliveryCheckings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DeliveryCheckings_DeliveryStates_DeliveryStateFK",
                        column: x => x.DeliveryStateFK,
                        principalTable: "DeliveryStates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DeliveryCheckings_Routes_RouteFK",
                        column: x => x.RouteFK,
                        principalTable: "Routes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DeliveryCheckings_Users_UserFK",
                        column: x => x.UserFK,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "DeliveryStates",
                columns: new[] { "Id", "State" },
                values: new object[,]
                {
                    { 1, "Available" },
                    { 2, "Selected" },
                    { 3, "Working" },
                    { 4, "Delivered" },
                    { 5, "Skipped" },
                    { 6, "Undelivered" }
                });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2021, 2, 26, 21, 17, 12, 386, DateTimeKind.Local).AddTicks(2913), new DateTime(2021, 2, 26, 21, 17, 12, 387, DateTimeKind.Local).AddTicks(691) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2021, 2, 26, 21, 17, 12, 387, DateTimeKind.Local).AddTicks(989), new DateTime(2021, 2, 26, 21, 17, 12, 387, DateTimeKind.Local).AddTicks(993) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2021, 2, 26, 21, 17, 12, 387, DateTimeKind.Local).AddTicks(995), new DateTime(2021, 2, 26, 21, 17, 12, 387, DateTimeKind.Local).AddTicks(996) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateAt", "Password", "UpdateAt" },
                values: new object[] { new DateTime(2021, 2, 26, 21, 17, 12, 416, DateTimeKind.Local).AddTicks(585), "$2a$06$WwEdkxluZR1GnGjVQ8k/vexfvzhmDtdeZmt25pT70caTWYDclZrrm", new DateTime(2021, 2, 26, 21, 17, 12, 416, DateTimeKind.Local).AddTicks(893) });

            migrationBuilder.CreateIndex(
                name: "IX_DeliveryCheckings_DeliveryStateFK",
                table: "DeliveryCheckings",
                column: "DeliveryStateFK");

            migrationBuilder.CreateIndex(
                name: "IX_DeliveryCheckings_RouteFK",
                table: "DeliveryCheckings",
                column: "RouteFK");

            migrationBuilder.CreateIndex(
                name: "IX_DeliveryCheckings_UserFK",
                table: "DeliveryCheckings",
                column: "UserFK");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DeliveryCheckings");

            migrationBuilder.DropTable(
                name: "DeliveryStates");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2021, 2, 26, 8, 56, 4, 320, DateTimeKind.Local).AddTicks(7018), new DateTime(2021, 2, 26, 8, 56, 4, 321, DateTimeKind.Local).AddTicks(4754) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2021, 2, 26, 8, 56, 4, 321, DateTimeKind.Local).AddTicks(5036), new DateTime(2021, 2, 26, 8, 56, 4, 321, DateTimeKind.Local).AddTicks(5040) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2021, 2, 26, 8, 56, 4, 321, DateTimeKind.Local).AddTicks(5042), new DateTime(2021, 2, 26, 8, 56, 4, 321, DateTimeKind.Local).AddTicks(5043) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateAt", "Password", "UpdateAt" },
                values: new object[] { new DateTime(2021, 2, 26, 8, 56, 4, 350, DateTimeKind.Local).AddTicks(6533), "$2a$06$lgLHkW3AEO/rJbKhdxkyzuXkyETfQu8hqRoXoTdz2vInXbpCG97d6", new DateTime(2021, 2, 26, 8, 56, 4, 350, DateTimeKind.Local).AddTicks(6840) });
        }
    }
}
