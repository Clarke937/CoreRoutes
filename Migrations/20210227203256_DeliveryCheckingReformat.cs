using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CoreRoutes.Migrations
{
    public partial class DeliveryCheckingReformat : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DeliveryCheckings_Routes_RouteFK",
                table: "DeliveryCheckings");

            migrationBuilder.RenameColumn(
                name: "RouteFK",
                table: "DeliveryCheckings",
                newName: "WeekdayFK");

            migrationBuilder.RenameIndex(
                name: "IX_DeliveryCheckings_RouteFK",
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DeliveryCheckings_Weekdays_WeekdayFK",
                table: "DeliveryCheckings");

            migrationBuilder.RenameColumn(
                name: "WeekdayFK",
                table: "DeliveryCheckings",
                newName: "RouteFK");

            migrationBuilder.RenameIndex(
                name: "IX_DeliveryCheckings_WeekdayFK",
                table: "DeliveryCheckings",
                newName: "IX_DeliveryCheckings_RouteFK");

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

            migrationBuilder.AddForeignKey(
                name: "FK_DeliveryCheckings_Routes_RouteFK",
                table: "DeliveryCheckings",
                column: "RouteFK",
                principalTable: "Routes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
