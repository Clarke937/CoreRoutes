using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CoreRoutes.Migrations
{
    public partial class CompanySiteDate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CompanySiteDates",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanySiteFK = table.Column<int>(type: "int", nullable: false),
                    WeekdayFK = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanySiteDates", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CompanySiteDates_CompanySites_CompanySiteFK",
                        column: x => x.CompanySiteFK,
                        principalTable: "CompanySites",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CompanySiteDates_Weekdays_WeekdayFK",
                        column: x => x.WeekdayFK,
                        principalTable: "Weekdays",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_CompanySiteDates_CompanySiteFK",
                table: "CompanySiteDates",
                column: "CompanySiteFK");

            migrationBuilder.CreateIndex(
                name: "IX_CompanySiteDates_WeekdayFK",
                table: "CompanySiteDates",
                column: "WeekdayFK");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CompanySiteDates");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2021, 2, 24, 17, 23, 12, 231, DateTimeKind.Local).AddTicks(8137), new DateTime(2021, 2, 24, 17, 23, 12, 232, DateTimeKind.Local).AddTicks(5908) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2021, 2, 24, 17, 23, 12, 232, DateTimeKind.Local).AddTicks(6204), new DateTime(2021, 2, 24, 17, 23, 12, 232, DateTimeKind.Local).AddTicks(6209) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2021, 2, 24, 17, 23, 12, 232, DateTimeKind.Local).AddTicks(6211), new DateTime(2021, 2, 24, 17, 23, 12, 232, DateTimeKind.Local).AddTicks(6212) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateAt", "Password", "UpdateAt" },
                values: new object[] { new DateTime(2021, 2, 24, 17, 23, 12, 261, DateTimeKind.Local).AddTicks(8153), "$2a$06$pE72w8/e44pwim0EQRy3cuXeivLDX4trxrEtqyyRmdmmnXPYVTdm2", new DateTime(2021, 2, 24, 17, 23, 12, 261, DateTimeKind.Local).AddTicks(8453) });
        }
    }
}
