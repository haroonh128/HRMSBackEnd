using Microsoft.EntityFrameworkCore.Migrations;

namespace Models.Migrations
{
    public partial class sfwef : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MstBranchesDetail_MstBranches_BranchId",
                table: "MstBranchesDetail");

            migrationBuilder.DropColumn(
                name: "CreatedDt",
                table: "MstBranchesDetail");

            migrationBuilder.RenameColumn(
                name: "docSeries",
                table: "MstBranchesDetail",
                newName: "DocSeries");

            migrationBuilder.RenameColumn(
                name: "BranchId",
                table: "MstBranchesDetail",
                newName: "BranchID");

            migrationBuilder.RenameIndex(
                name: "IX_MstBranchesDetail_BranchId",
                table: "MstBranchesDetail",
                newName: "IX_MstBranchesDetail_BranchID");

            migrationBuilder.RenameColumn(
                name: "BankAccount",
                table: "MstBranches",
                newName: "BankAccout");

            migrationBuilder.AddColumn<string>(
                name: "CreateDt",
                table: "MstBranchesDetail",
                type: "nvarchar(50)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "userId",
                table: "AssignRoles",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_MstBranchesDetail_MstBranches_BranchID",
                table: "MstBranchesDetail",
                column: "BranchID",
                principalTable: "MstBranches",
                principalColumn: "Code",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MstBranchesDetail_MstBranches_BranchID",
                table: "MstBranchesDetail");

            migrationBuilder.DropColumn(
                name: "CreateDt",
                table: "MstBranchesDetail");

            migrationBuilder.RenameColumn(
                name: "DocSeries",
                table: "MstBranchesDetail",
                newName: "docSeries");

            migrationBuilder.RenameColumn(
                name: "BranchID",
                table: "MstBranchesDetail",
                newName: "BranchId");

            migrationBuilder.RenameIndex(
                name: "IX_MstBranchesDetail_BranchID",
                table: "MstBranchesDetail",
                newName: "IX_MstBranchesDetail_BranchId");

            migrationBuilder.RenameColumn(
                name: "BankAccout",
                table: "MstBranches",
                newName: "BankAccount");

            migrationBuilder.AddColumn<string>(
                name: "CreatedDt",
                table: "MstBranchesDetail",
                type: "nvarchar(50)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<int>(
                name: "userId",
                table: "AssignRoles",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_MstBranchesDetail_MstBranches_BranchId",
                table: "MstBranchesDetail",
                column: "BranchId",
                principalTable: "MstBranches",
                principalColumn: "Code",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
