using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Models.Migrations
{
    public partial class fadfd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "updatedDate",
                table: "AssignRoles",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "createdDate",
                table: "AssignRoles",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.CreateIndex(
                name: "IX_AssignRoles_roleId",
                table: "AssignRoles",
                column: "roleId");

            migrationBuilder.AddForeignKey(
                name: "FK_AssignRoles_sec_UserRoles_roleId",
                table: "AssignRoles",
                column: "roleId",
                principalTable: "sec_UserRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AssignRoles_sec_UserRoles_roleId",
                table: "AssignRoles");

            migrationBuilder.DropIndex(
                name: "IX_AssignRoles_roleId",
                table: "AssignRoles");

            migrationBuilder.AlterColumn<DateTime>(
                name: "updatedDate",
                table: "AssignRoles",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdDate",
                table: "AssignRoles",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
