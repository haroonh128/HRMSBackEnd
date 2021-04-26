using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Models.Migrations
{
    public partial class BranchTablesAddition : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MstBranches",
                columns: table => new
                {
                    Code = table.Column<string>(type: "nvarchar(10)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    SeriesId = table.Column<string>(type: "nvarchar(10)", nullable: true),
                    BankAccount = table.Column<string>(type: "nvarchar(15)", nullable: true),
                    CashInHandAccount = table.Column<string>(type: "nvarchar(15)", nullable: true),
                    PettyCash = table.Column<string>(type: "nvarchar(15)", nullable: true),
                    ExpenseAccount = table.Column<string>(type: "nvarchar(15)", nullable: true),
                    BranchWhs = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    InTransitWhs = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    HeadInTransitWhs = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    CreateDt = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    UpdateDt = table.Column<DateTime>(type: "datetime", nullable: false),
                    CostCenter = table.Column<string>(type: "varchar(50)", nullable: true),
                    CustomerGroupCode = table.Column<string>(type: "varchar(50)", nullable: true),
                    ItemGroupCode = table.Column<string>(type: "varchar(50)", nullable: true),
                    BlockAfterDueDays = table.Column<int>(type: "int", nullable: false),
                    NCControl = table.Column<int>(type: "int", nullable: false),
                    SalaryAccount = table.Column<string>(type: "varchar(15)", nullable: true),
                    AdvToEmpAcc = table.Column<string>(type: "varchar(15)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MstBranches", x => x.Code);
                });

            migrationBuilder.CreateTable(
                name: "MstBranchesDetail",
                columns: table => new
                {
                    DetailKey = table.Column<string>(type: "nvarchar(30)", nullable: false),
                    BranchId = table.Column<string>(type: "nvarchar(10)", nullable: true),
                    LineID = table.Column<int>(type: "int", nullable: false),
                    DocName = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    docSeries = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    StartingNumber = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    CreatedDt = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    UpdateDt = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    LastNumber = table.Column<int>(type: "int", nullable: false),
                    SeriesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MstBranchesDetail", x => x.DetailKey);
                    table.ForeignKey(
                        name: "FK_MstBranchesDetail_MstBranches_BranchId",
                        column: x => x.BranchId,
                        principalTable: "MstBranches",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MstBranchesDetail_BranchId",
                table: "MstBranchesDetail",
                column: "BranchId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MstBranchesDetail");

            migrationBuilder.DropTable(
                name: "MstBranches");
        }
    }
}
