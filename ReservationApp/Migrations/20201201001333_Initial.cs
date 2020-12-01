using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ReservationApp.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ContactTypes",
                columns: table => new
                {
                    CTId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CTName = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    CTDescription = table.Column<string>(type: "nvarchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactTypes", x => x.CTId);
                });

            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    ContactId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContactName = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    ContactPhoneNumber = table.Column<string>(type: "varchar(12)", nullable: false),
                    ContactBirthday = table.Column<DateTime>(type: "Date", nullable: false),
                    ContactTypeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.ContactId);
                    table.ForeignKey(
                        name: "FK_Contacts_ContactTypes_ContactTypeId",
                        column: x => x.ContactTypeId,
                        principalTable: "ContactTypes",
                        principalColumn: "CTId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Reservations",
                columns: table => new
                {
                    ReservationId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ReservationDate = table.Column<DateTime>(type: "Date", nullable: false),
                    ReservationDescription = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    ContactId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactId1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservations", x => x.ReservationId);
                    table.ForeignKey(
                        name: "FK_Reservations_Contacts_ContactId1",
                        column: x => x.ContactId1,
                        principalTable: "Contacts",
                        principalColumn: "ContactId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Contacts_ContactTypeId",
                table: "Contacts",
                column: "ContactTypeId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_ContactId1",
                table: "Reservations",
                column: "ContactId1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reservations");

            migrationBuilder.DropTable(
                name: "Contacts");

            migrationBuilder.DropTable(
                name: "ContactTypes");
        }
    }
}
