using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CoreRoutes.Migrations
{
    public partial class ServiceTypeToRoute : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ServiceTypeFK",
                table: "Routes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2021, 2, 25, 11, 30, 5, 161, DateTimeKind.Local).AddTicks(6843), new DateTime(2021, 2, 25, 11, 30, 5, 162, DateTimeKind.Local).AddTicks(5342) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2021, 2, 25, 11, 30, 5, 162, DateTimeKind.Local).AddTicks(5640), new DateTime(2021, 2, 25, 11, 30, 5, 162, DateTimeKind.Local).AddTicks(5645) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2021, 2, 25, 11, 30, 5, 162, DateTimeKind.Local).AddTicks(5647), new DateTime(2021, 2, 25, 11, 30, 5, 162, DateTimeKind.Local).AddTicks(5648) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateAt", "Password", "UpdateAt" },
                values: new object[] { new DateTime(2021, 2, 25, 11, 30, 5, 193, DateTimeKind.Local).AddTicks(3529), "$2a$06$gO.fQcaLR56.QivmaazFFe8LHjH1fkt/p8r4R4J6DH8V2rfhgnTky", new DateTime(2021, 2, 25, 11, 30, 5, 193, DateTimeKind.Local).AddTicks(3843) });

            migrationBuilder.CreateIndex(
                name: "IX_Routes_ServiceTypeFK",
                table: "Routes",
                column: "ServiceTypeFK");

            migrationBuilder.AddForeignKey(
                name: "FK_Routes_ServiceTypes_ServiceTypeFK",
                table: "Routes",
                column: "ServiceTypeFK",
                principalTable: "ServiceTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Routes_ServiceTypes_ServiceTypeFK",
                table: "Routes");

            migrationBuilder.DropIndex(
                name: "IX_Routes_ServiceTypeFK",
                table: "Routes");

            migrationBuilder.DropColumn(
                name: "ServiceTypeFK",
                table: "Routes");

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
        }
    }
}
