using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CoreRoutes.Migrations
{
    public partial class AnotherReformat : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DeliveryCheckings_Weekdays_WeekdayFK",
                table: "DeliveryCheckings");

            migrationBuilder.RenameColumn(
                name: "WeekdayFK",
                table: "DeliveryCheckings",
                newName: "CompanySiteFK");

            migrationBuilder.RenameIndex(
                name: "IX_DeliveryCheckings_WeekdayFK",
                table: "DeliveryCheckings",
                newName: "IX_DeliveryCheckings_CompanySiteFK");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2021, 2, 27, 14, 46, 52, 597, DateTimeKind.Local).AddTicks(1896), new DateTime(2021, 2, 27, 14, 46, 52, 597, DateTimeKind.Local).AddTicks(9760) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2021, 2, 27, 14, 46, 52, 598, DateTimeKind.Local).AddTicks(45), new DateTime(2021, 2, 27, 14, 46, 52, 598, DateTimeKind.Local).AddTicks(49) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2021, 2, 27, 14, 46, 52, 598, DateTimeKind.Local).AddTicks(51), new DateTime(2021, 2, 27, 14, 46, 52, 598, DateTimeKind.Local).AddTicks(52) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateAt", "Password", "UpdateAt" },
                values: new object[] { new DateTime(2021, 2, 27, 14, 46, 52, 626, DateTimeKind.Local).AddTicks(6905), "$2a$06$FV8gxa87jjFAq7JhaGhr4OBzhSsi8NzxwzyU4zaNeM/td7ZDKedLe", new DateTime(2021, 2, 27, 14, 46, 52, 626, DateTimeKind.Local).AddTicks(7200) });

            migrationBuilder.AddForeignKey(
                name: "FK_DeliveryCheckings_CompanySites_CompanySiteFK",
                table: "DeliveryCheckings",
                column: "CompanySiteFK",
                principalTable: "CompanySites",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DeliveryCheckings_CompanySites_CompanySiteFK",
                table: "DeliveryCheckings");

            migrationBuilder.RenameColumn(
                name: "CompanySiteFK",
                table: "DeliveryCheckings",
                newName: "WeekdayFK");

            migrationBuilder.RenameIndex(
                name: "IX_DeliveryCheckings_CompanySiteFK",
                table: "DeliveryCheckings",
                newName: "IX_DeliveryCheckings_WeekdayFK");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2021, 2, 27, 14, 32, 56, 359, DateTimeKind.Local).AddTicks(7768), new DateTime(2021, 2, 27, 14, 32, 56, 360, DateTimeKind.Local).AddTicks(5585) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2021, 2, 27, 14, 32, 56, 360, DateTimeKind.Local).AddTicks(5874), new DateTime(2021, 2, 27, 14, 32, 56, 360, DateTimeKind.Local).AddTicks(5878) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2021, 2, 27, 14, 32, 56, 360, DateTimeKind.Local).AddTicks(5880), new DateTime(2021, 2, 27, 14, 32, 56, 360, DateTimeKind.Local).AddTicks(5881) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateAt", "Password", "UpdateAt" },
                values: new object[] { new DateTime(2021, 2, 27, 14, 32, 56, 389, DateTimeKind.Local).AddTicks(4995), "$2a$06$v67KPrD.ZAyMIN5T86/3Bes9EZB4DSVWVQ9Fj41wqaj/VIJzeIVZG", new DateTime(2021, 2, 27, 14, 32, 56, 389, DateTimeKind.Local).AddTicks(5306) });

            migrationBuilder.AddForeignKey(
                name: "FK_DeliveryCheckings_Weekdays_WeekdayFK",
                table: "DeliveryCheckings",
                column: "WeekdayFK",
                principalTable: "Weekdays",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
