using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Thrifty.Infrastructure.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Budgets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Category = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    Year = table.Column<int>(type: "INTEGER", nullable: false),
                    Month = table.Column<int>(type: "INTEGER", nullable: false),
                    Limit = table.Column<long>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Budgets", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Transactions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Date = table.Column<DateOnly>(type: "TEXT", nullable: false),
                    Merchant = table.Column<string>(type: "TEXT", maxLength: 200, nullable: false),
                    Note = table.Column<string>(type: "TEXT", maxLength: 500, nullable: true),
                    Category = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    PaymentMethod = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Amount = table.Column<long>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transactions", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Budgets",
                columns: new[] { "Id", "Category", "Limit", "Month", "Year" },
                values: new object[,]
                {
                    { 1, "Food", 75000L, 9, 2026 },
                    { 2, "Housing", 70000L, 9, 2026 },
                    { 3, "Transport", 40000L, 9, 2026 },
                    { 4, "Shopping", 30000L, 9, 2026 },
                    { 5, "Bills", 30000L, 9, 2026 },
                    { 6, "Other", 55000L, 9, 2026 }
                });

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "Id", "Amount", "Category", "Date", "Merchant", "Note", "PaymentMethod" },
                values: new object[,]
                {
                    { 1, -4620L, "Food", new DateOnly(2026, 9, 18), "Din Tai Fung", null, "Credit card" },
                    { 2, -6235L, "Food", new DateOnly(2026, 9, 18), "NTUC FairPrice", null, "PayNow" },
                    { 3, -1480L, "Transport", new DateOnly(2026, 9, 17), "Grab ride", null, "Credit card" },
                    { 4, -11840L, "Bills", new DateOnly(2026, 9, 15), "SP Services", null, "GIRO" },
                    { 5, -8990L, "Shopping", new DateOnly(2026, 9, 14), "Uniqlo", null, "Credit card" },
                    { 6, 520000L, "Income", new DateOnly(2026, 9, 1), "Salary", null, "Bank transfer" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Budgets_Category_Year_Month",
                table: "Budgets",
                columns: new[] { "Category", "Year", "Month" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_Date",
                table: "Transactions",
                column: "Date");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Budgets");

            migrationBuilder.DropTable(
                name: "Transactions");
        }
    }
}
