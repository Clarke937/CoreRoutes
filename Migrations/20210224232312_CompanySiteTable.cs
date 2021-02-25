using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CoreRoutes.Migrations
{
    public partial class CompanySiteTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CompanySites",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SiteName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostalCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Contact = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CompanyFK = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanySites", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CompanySites_Companies_CompanyFK",
                        column: x => x.CompanyFK,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_CompanySites_CompanyFK",
                table: "CompanySites",
                column: "CompanyFK");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CompanySites");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2021, 2, 24, 11, 21, 25, 769, DateTimeKind.Local).AddTicks(8379), new DateTime(2021, 2, 24, 11, 21, 25, 770, DateTimeKind.Local).AddTicks(6200) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2021, 2, 24, 11, 21, 25, 770, DateTimeKind.Local).AddTicks(6483), new DateTime(2021, 2, 24, 11, 21, 25, 770, DateTimeKind.Local).AddTicks(6487) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2021, 2, 24, 11, 21, 25, 770, DateTimeKind.Local).AddTicks(6489), new DateTime(2021, 2, 24, 11, 21, 25, 770, DateTimeKind.Local).AddTicks(6489) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateAt", "Password", "UpdateAt" },
                values: new object[] { new DateTime(2021, 2, 24, 11, 21, 25, 799, DateTimeKind.Local).AddTicks(792), "$2a$06$.rJnahgHjpCKUxsx7UFkZ.ugd5FiHMQ7ANQFTXsII1ap0h5jFVSey", new DateTime(2021, 2, 24, 11, 21, 25, 799, DateTimeKind.Local).AddTicks(1075) });
        }
    }
}
