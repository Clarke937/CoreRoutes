using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CoreRoutes.Migrations
{
    public partial class TryAgain : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DeliveryCheckings_CompanySites_CompanySiteFK",
                table: "DeliveryCheckings");

            migrationBuilder.RenameColumn(
                name: "CompanySiteFK",
                table: "DeliveryCheckings",
                newName: "ServiceTypeFK");

            migrationBuilder.RenameIndex(
                name: "IX_DeliveryCheckings_CompanySiteFK",
                table: "DeliveryCheckings",
                newName: "IX_DeliveryCheckings_ServiceTypeFK");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2021, 2, 27, 14, 52, 45, 656, DateTimeKind.Local).AddTicks(3674), new DateTime(2021, 2, 27, 14, 52, 45, 657, DateTimeKind.Local).AddTicks(1373) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2021, 2, 27, 14, 52, 45, 657, DateTimeKind.Local).AddTicks(1656), new DateTime(2021, 2, 27, 14, 52, 45, 657, DateTimeKind.Local).AddTicks(1661) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2021, 2, 27, 14, 52, 45, 657, DateTimeKind.Local).AddTicks(1662), new DateTime(2021, 2, 27, 14, 52, 45, 657, DateTimeKind.Local).AddTicks(1663) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateAt", "Password", "UpdateAt" },
                values: new object[] { new DateTime(2021, 2, 27, 14, 52, 45, 686, DateTimeKind.Local).AddTicks(8376), "$2a$06$NgmQD14PsZpR6NacE10ix.ynDnOQ7oxJNdbOmQRflZGzbgyPfKbO2", new DateTime(2021, 2, 27, 14, 52, 45, 686, DateTimeKind.Local).AddTicks(8688) });

            migrationBuilder.AddForeignKey(
                name: "FK_DeliveryCheckings_ServiceTypes_ServiceTypeFK",
                table: "DeliveryCheckings",
                column: "ServiceTypeFK",
                principalTable: "ServiceTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DeliveryCheckings_ServiceTypes_ServiceTypeFK",
                table: "DeliveryCheckings");

            migrationBuilder.RenameColumn(
                name: "ServiceTypeFK",
                table: "DeliveryCheckings",
                newName: "CompanySiteFK");

            migrationBuilder.RenameIndex(
                name: "IX_DeliveryCheckings_ServiceTypeFK",
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
    }
}
