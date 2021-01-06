using Microsoft.EntityFrameworkCore.Migrations;

namespace ReservationApp.Migrations
{
    public partial class FKs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_Contacts_ContactId1",
                table: "Reservations");

            migrationBuilder.DropIndex(
                name: "IX_Reservations_ContactId1",
                table: "Reservations");

            migrationBuilder.DropColumn(
                name: "ContactId1",
                table: "Reservations");

            migrationBuilder.AlterColumn<int>(
                name: "ContactId",
                table: "Reservations",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_ContactId",
                table: "Reservations",
                column: "ContactId");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_Contacts_ContactId",
                table: "Reservations",
                column: "ContactId",
                principalTable: "Contacts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_Contacts_ContactId",
                table: "Reservations");

            migrationBuilder.DropIndex(
                name: "IX_Reservations_ContactId",
                table: "Reservations");

            migrationBuilder.AlterColumn<string>(
                name: "ContactId",
                table: "Reservations",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "ContactId1",
                table: "Reservations",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_ContactId1",
                table: "Reservations",
                column: "ContactId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_Contacts_ContactId1",
                table: "Reservations",
                column: "ContactId1",
                principalTable: "Contacts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
