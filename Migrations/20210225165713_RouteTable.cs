using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CoreRoutes.Migrations
{
    public partial class RouteTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Routes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RouteName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeliveryDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    State = table.Column<int>(type: "int", nullable: false),
                    UserFK = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Routes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Routes_Users_UserFK",
                        column: x => x.UserFK,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2021, 2, 25, 10, 57, 12, 909, DateTimeKind.Local).AddTicks(4826), new DateTime(2021, 2, 25, 10, 57, 12, 910, DateTimeKind.Local).AddTicks(2413) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2021, 2, 25, 10, 57, 12, 910, DateTimeKind.Local).AddTicks(2692), new DateTime(2021, 2, 25, 10, 57, 12, 910, DateTimeKind.Local).AddTicks(2697) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2021, 2, 25, 10, 57, 12, 910, DateTimeKind.Local).AddTicks(2699), new DateTime(2021, 2, 25, 10, 57, 12, 910, DateTimeKind.Local).AddTicks(2700) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateAt", "Password", "UpdateAt" },
                values: new object[] { new DateTime(2021, 2, 25, 10, 57, 12, 938, DateTimeKind.Local).AddTicks(7400), "$2a$06$aTAuvdNEw1KgPtqMEjADK.BMiHmr9pQnstA6dttCZEDUAORV.dU6i", new DateTime(2021, 2, 25, 10, 57, 12, 938, DateTimeKind.Local).AddTicks(7703) });

            migrationBuilder.CreateIndex(
                name: "IX_Routes_UserFK",
                table: "Routes",
                column: "UserFK");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Routes");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2021, 2, 25, 10, 7, 34, 791, DateTimeKind.Local).AddTicks(1808), new DateTime(2021, 2, 25, 10, 7, 34, 791, DateTimeKind.Local).AddTicks(9413) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2021, 2, 25, 10, 7, 34, 791, DateTimeKind.Local).AddTicks(9699), new DateTime(2021, 2, 25, 10, 7, 34, 791, DateTimeKind.Local).AddTicks(9704) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2021, 2, 25, 10, 7, 34, 791, DateTimeKind.Local).AddTicks(9706), new DateTime(2021, 2, 25, 10, 7, 34, 791, DateTimeKind.Local).AddTicks(9706) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateAt", "Password", "UpdateAt" },
                values: new object[] { new DateTime(2021, 2, 25, 10, 7, 34, 823, DateTimeKind.Local).AddTicks(6092), "$2a$06$xyNlRISxqcF/XfeqiObWueRmBHUCGqbClyy22f/CO9V93z46VInxG", new DateTime(2021, 2, 25, 10, 7, 34, 823, DateTimeKind.Local).AddTicks(6383) });
        }
    }
}
