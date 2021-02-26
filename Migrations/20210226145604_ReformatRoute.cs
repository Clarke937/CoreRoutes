using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CoreRoutes.Migrations
{
    public partial class ReformatRoute : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Routes_Users_UserFK",
                table: "Routes");

            migrationBuilder.DropTable(
                name: "CompanySiteDates");

            migrationBuilder.DropIndex(
                name: "IX_Routes_UserFK",
                table: "Routes");

            migrationBuilder.DropColumn(
                name: "DeliveryDate",
                table: "Routes");

            migrationBuilder.DropColumn(
                name: "RouteName",
                table: "Routes");

            migrationBuilder.DropColumn(
                name: "UserFK",
                table: "Routes");

            migrationBuilder.RenameColumn(
                name: "State",
                table: "Routes",
                newName: "WeekdayFK");

            migrationBuilder.AddColumn<int>(
                name: "CompanySiteFK",
                table: "Routes",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

            migrationBuilder.CreateIndex(
                name: "IX_Routes_CompanySiteFK",
                table: "Routes",
                column: "CompanySiteFK");

            migrationBuilder.CreateIndex(
                name: "IX_Routes_WeekdayFK",
                table: "Routes",
                column: "WeekdayFK");

            migrationBuilder.AddForeignKey(
                name: "FK_Routes_CompanySites_CompanySiteFK",
                table: "Routes",
                column: "CompanySiteFK",
                principalTable: "CompanySites",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Routes_Weekdays_WeekdayFK",
                table: "Routes",
                column: "WeekdayFK",
                principalTable: "Weekdays",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Routes_CompanySites_CompanySiteFK",
                table: "Routes");

            migrationBuilder.DropForeignKey(
                name: "FK_Routes_Weekdays_WeekdayFK",
                table: "Routes");

            migrationBuilder.DropIndex(
                name: "IX_Routes_CompanySiteFK",
                table: "Routes");

            migrationBuilder.DropIndex(
                name: "IX_Routes_WeekdayFK",
                table: "Routes");

            migrationBuilder.DropColumn(
                name: "CompanySiteFK",
                table: "Routes");

            migrationBuilder.RenameColumn(
                name: "WeekdayFK",
                table: "Routes",
                newName: "State");

            migrationBuilder.AddColumn<DateTime>(
                name: "DeliveryDate",
                table: "Routes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "RouteName",
                table: "Routes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserFK",
                table: "Routes",
                type: "int",
                nullable: true);

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
                values: new object[] { new DateTime(2021, 2, 25, 17, 26, 33, 716, DateTimeKind.Local).AddTicks(8519), new DateTime(2021, 2, 25, 17, 26, 33, 717, DateTimeKind.Local).AddTicks(6277) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2021, 2, 25, 17, 26, 33, 717, DateTimeKind.Local).AddTicks(6558), new DateTime(2021, 2, 25, 17, 26, 33, 717, DateTimeKind.Local).AddTicks(6563) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2021, 2, 25, 17, 26, 33, 717, DateTimeKind.Local).AddTicks(6564), new DateTime(2021, 2, 25, 17, 26, 33, 717, DateTimeKind.Local).AddTicks(6565) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateAt", "Password", "UpdateAt" },
                values: new object[] { new DateTime(2021, 2, 25, 17, 26, 33, 746, DateTimeKind.Local).AddTicks(9356), "$2a$06$BhfdMo5jiVmG2k7NfadrYertAvS.nQbcmRn6KzfjOK9xoormBIZvO", new DateTime(2021, 2, 25, 17, 26, 33, 746, DateTimeKind.Local).AddTicks(9679) });

            migrationBuilder.CreateIndex(
                name: "IX_Routes_UserFK",
                table: "Routes",
                column: "UserFK");

            migrationBuilder.CreateIndex(
                name: "IX_CompanySiteDates_CompanySiteFK",
                table: "CompanySiteDates",
                column: "CompanySiteFK");

            migrationBuilder.CreateIndex(
                name: "IX_CompanySiteDates_WeekdayFK",
                table: "CompanySiteDates",
                column: "WeekdayFK");

            migrationBuilder.AddForeignKey(
                name: "FK_Routes_Users_UserFK",
                table: "Routes",
                column: "UserFK",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
