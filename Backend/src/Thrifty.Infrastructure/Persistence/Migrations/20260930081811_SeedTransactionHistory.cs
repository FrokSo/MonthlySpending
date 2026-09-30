using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Thrifty.Infrastructure.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class SeedTransactionHistory : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "Id", "Amount", "Category", "Date", "Merchant", "Note", "PaymentMethod" },
                values: new object[,]
                {
                    { 7, 520000L, "Income", new DateOnly(2026, 4, 1), "Salary", null, "Bank transfer" },
                    { 8, -7800L, "Housing", new DateOnly(2026, 4, 2), "Town Council S&CC", null, "GIRO" },
                    { 9, -4800L, "Bills", new DateOnly(2026, 4, 3), "Singtel", null, "GIRO" },
                    { 10, -10000L, "Transport", new DateOnly(2026, 4, 5), "SimplyGo", null, "Credit card" },
                    { 11, -17650L, "Food", new DateOnly(2026, 4, 6), "NTUC FairPrice", null, "PayNow" },
                    { 12, -5160L, "Bills", new DateOnly(2026, 4, 8), "StarHub", null, "GIRO" },
                    { 13, -4260L, "Food", new DateOnly(2026, 4, 9), "Kopitiam", null, "PayNow" },
                    { 14, -7180L, "Food", new DateOnly(2026, 4, 11), "Din Tai Fung", null, "Credit card" },
                    { 15, -12000L, "Housing", new DateOnly(2026, 4, 12), "Helpling", null, "Credit card" },
                    { 16, -18650L, "Housing", new DateOnly(2026, 4, 14), "IKEA", null, "Credit card" },
                    { 17, -10820L, "Bills", new DateOnly(2026, 4, 15), "SP Services", null, "GIRO" },
                    { 18, -6440L, "Transport", new DateOnly(2026, 4, 18), "Grab ride", null, "Credit card" },
                    { 19, -8000L, "Transport", new DateOnly(2026, 4, 19), "SimplyGo", null, "Credit card" },
                    { 20, -8490L, "Shopping", new DateOnly(2026, 4, 19), "Uniqlo", null, "Credit card" },
                    { 21, -9230L, "Food", new DateOnly(2026, 4, 20), "NTUC FairPrice", null, "PayNow" },
                    { 22, -8860L, "Food", new DateOnly(2026, 4, 24), "Sheng Siong", null, "PayNow" },
                    { 23, -4870L, "Shopping", new DateOnly(2026, 4, 25), "Watsons", null, "Credit card" },
                    { 24, -9600L, "Housing", new DateOnly(2026, 4, 26), "Helpling", null, "Credit card" },
                    { 25, -13200L, "Food", new DateOnly(2026, 4, 26), "Hai Di Lao", null, "Credit card" },
                    { 26, -67870L, "Housing", new DateOnly(2026, 4, 27), "Fortytwo", null, "Credit card" },
                    { 27, -6120L, "Transport", new DateOnly(2026, 4, 28), "Grab ride", null, "Credit card" },
                    { 28, 520000L, "Income", new DateOnly(2026, 5, 1), "Salary", null, "Bank transfer" },
                    { 29, -7800L, "Housing", new DateOnly(2026, 5, 2), "Town Council S&CC", null, "GIRO" },
                    { 30, -4800L, "Bills", new DateOnly(2026, 5, 3), "Singtel", null, "GIRO" },
                    { 31, -15820L, "Food", new DateOnly(2026, 5, 4), "NTUC FairPrice", null, "PayNow" },
                    { 32, -10000L, "Transport", new DateOnly(2026, 5, 5), "SimplyGo", null, "Credit card" },
                    { 33, -5160L, "Bills", new DateOnly(2026, 5, 8), "StarHub", null, "GIRO" },
                    { 34, -4260L, "Food", new DateOnly(2026, 5, 9), "Kopitiam", null, "PayNow" },
                    { 35, -7230L, "Transport", new DateOnly(2026, 5, 9), "Grab ride", null, "Credit card" },
                    { 36, -18600L, "Food", new DateOnly(2026, 5, 11), "Jumbo Seafood", null, "Credit card" },
                    { 37, -12000L, "Housing", new DateOnly(2026, 5, 12), "Helpling", null, "Credit card" },
                    { 38, -18650L, "Housing", new DateOnly(2026, 5, 14), "IKEA", null, "Credit card" },
                    { 39, -11260L, "Bills", new DateOnly(2026, 5, 15), "SP Services", null, "GIRO" },
                    { 40, -6340L, "Shopping", new DateOnly(2026, 5, 16), "Shopee", null, "Credit card" },
                    { 41, -10470L, "Food", new DateOnly(2026, 5, 18), "NTUC FairPrice", null, "PayNow" },
                    { 42, -8000L, "Transport", new DateOnly(2026, 5, 19), "SimplyGo", null, "Credit card" },
                    { 43, -7690L, "Food", new DateOnly(2026, 5, 23), "Sheng Siong", null, "PayNow" },
                    { 44, -92480L, "Shopping", new DateOnly(2026, 5, 24), "Courts", null, "Credit card" },
                    { 45, -4870L, "Shopping", new DateOnly(2026, 5, 25), "Watsons", null, "Credit card" },
                    { 46, -9600L, "Housing", new DateOnly(2026, 5, 26), "Helpling", null, "Credit card" },
                    { 47, -6120L, "Transport", new DateOnly(2026, 5, 28), "Grab ride", null, "Credit card" },
                    { 48, -3850L, "Food", new DateOnly(2026, 5, 29), "Kopitiam", null, "PayNow" },
                    { 49, 520000L, "Income", new DateOnly(2026, 6, 1), "Salary", null, "Bank transfer" },
                    { 50, -7800L, "Housing", new DateOnly(2026, 6, 2), "Town Council S&CC", null, "GIRO" },
                    { 51, -4800L, "Bills", new DateOnly(2026, 6, 3), "Singtel", null, "GIRO" },
                    { 52, -10000L, "Transport", new DateOnly(2026, 6, 5), "SimplyGo", null, "Credit card" },
                    { 53, -16890L, "Food", new DateOnly(2026, 6, 7), "NTUC FairPrice", null, "PayNow" },
                    { 54, -5160L, "Bills", new DateOnly(2026, 6, 8), "StarHub", null, "GIRO" },
                    { 55, -4260L, "Food", new DateOnly(2026, 6, 9), "Kopitiam", null, "PayNow" },
                    { 56, -12000L, "Housing", new DateOnly(2026, 6, 12), "Helpling", null, "Credit card" },
                    { 57, -5860L, "Transport", new DateOnly(2026, 6, 13), "Grab ride", null, "Credit card" },
                    { 58, -18650L, "Housing", new DateOnly(2026, 6, 14), "IKEA", null, "Credit card" },
                    { 59, -4630L, "Food", new DateOnly(2026, 6, 14), "Tim Ho Wan", null, "Credit card" },
                    { 60, -13180L, "Bills", new DateOnly(2026, 6, 15), "SP Services", null, "GIRO" },
                    { 61, -8000L, "Transport", new DateOnly(2026, 6, 19), "SimplyGo", null, "Credit card" },
                    { 62, -73710L, "Shopping", new DateOnly(2026, 6, 20), "Takashimaya", null, "Credit card" },
                    { 63, -8840L, "Food", new DateOnly(2026, 6, 21), "NTUC FairPrice", null, "PayNow" },
                    { 64, -9210L, "Food", new DateOnly(2026, 6, 22), "Sheng Siong", null, "PayNow" },
                    { 65, -4870L, "Shopping", new DateOnly(2026, 6, 25), "Watsons", null, "Credit card" },
                    { 66, -9600L, "Housing", new DateOnly(2026, 6, 26), "Helpling", null, "Credit card" },
                    { 67, -5420L, "Food", new DateOnly(2026, 6, 27), "GrabFood", null, "Credit card" },
                    { 68, -6120L, "Transport", new DateOnly(2026, 6, 28), "Grab ride", null, "Credit card" },
                    { 69, 520000L, "Income", new DateOnly(2026, 7, 1), "Salary", null, "Bank transfer" },
                    { 70, -7800L, "Housing", new DateOnly(2026, 7, 2), "Town Council S&CC", null, "GIRO" },
                    { 71, -4800L, "Bills", new DateOnly(2026, 7, 3), "Singtel", null, "GIRO" },
                    { 72, -10000L, "Transport", new DateOnly(2026, 7, 5), "SimplyGo", null, "Credit card" },
                    { 73, -18160L, "Food", new DateOnly(2026, 7, 5), "NTUC FairPrice", null, "PayNow" },
                    { 74, -5160L, "Bills", new DateOnly(2026, 7, 8), "StarHub", null, "GIRO" },
                    { 75, -4260L, "Food", new DateOnly(2026, 7, 9), "Kopitiam", null, "PayNow" },
                    { 76, -8270L, "Transport", new DateOnly(2026, 7, 10), "Grab ride", null, "Credit card" },
                    { 77, -12000L, "Housing", new DateOnly(2026, 7, 12), "Helpling", null, "Credit card" },
                    { 78, -6490L, "Food", new DateOnly(2026, 7, 12), "Din Tai Fung", null, "Credit card" },
                    { 79, -18650L, "Housing", new DateOnly(2026, 7, 14), "IKEA", null, "Credit card" },
                    { 80, -13850L, "Bills", new DateOnly(2026, 7, 15), "SP Services", null, "GIRO" },
                    { 81, -9280L, "Shopping", new DateOnly(2026, 7, 17), "Lazada", null, "Credit card" },
                    { 82, -8000L, "Transport", new DateOnly(2026, 7, 19), "SimplyGo", null, "Credit card" },
                    { 83, -9740L, "Food", new DateOnly(2026, 7, 19), "NTUC FairPrice", null, "PayNow" },
                    { 84, -8320L, "Food", new DateOnly(2026, 7, 24), "Sheng Siong", null, "PayNow" },
                    { 85, -4870L, "Shopping", new DateOnly(2026, 7, 25), "Watsons", null, "Credit card" },
                    { 86, -9600L, "Housing", new DateOnly(2026, 7, 26), "Helpling", null, "Credit card" },
                    { 87, -4130L, "Food", new DateOnly(2026, 7, 26), "Swee Choon", null, "PayNow" },
                    { 88, -6120L, "Transport", new DateOnly(2026, 7, 28), "Grab ride", null, "Credit card" },
                    { 89, -103500L, "Other", new DateOnly(2026, 7, 30), "Scoot", null, "Credit card" },
                    { 90, 520000L, "Income", new DateOnly(2026, 8, 1), "Salary", null, "Bank transfer" },
                    { 91, -7800L, "Housing", new DateOnly(2026, 8, 2), "Town Council S&CC", null, "GIRO" },
                    { 92, -4800L, "Bills", new DateOnly(2026, 8, 3), "Singtel", null, "GIRO" },
                    { 93, -18640L, "Food", new DateOnly(2026, 8, 3), "NTUC FairPrice", null, "PayNow" },
                    { 94, -12000L, "Transport", new DateOnly(2026, 8, 5), "SimplyGo", null, "Credit card" },
                    { 95, -5160L, "Bills", new DateOnly(2026, 8, 8), "StarHub", null, "GIRO" },
                    { 96, -11980L, "Shopping", new DateOnly(2026, 8, 8), "Uniqlo", null, "Credit card" },
                    { 97, -5830L, "Food", new DateOnly(2026, 8, 9), "Din Tai Fung", null, "Credit card" },
                    { 98, -9560L, "Food", new DateOnly(2026, 8, 10), "Sheng Siong", null, "PayNow" },
                    { 99, -12000L, "Housing", new DateOnly(2026, 8, 12), "Helpling", null, "Credit card" },
                    { 100, -8840L, "Transport", new DateOnly(2026, 8, 13), "Grab ride", null, "Credit card" },
                    { 101, -12540L, "Bills", new DateOnly(2026, 8, 15), "SP Services", null, "GIRO" },
                    { 102, -14200L, "Food", new DateOnly(2026, 8, 16), "Jumbo Seafood", null, "Credit card" },
                    { 103, -21400L, "Housing", new DateOnly(2026, 8, 17), "IKEA", null, "Credit card" },
                    { 104, -7830L, "Shopping", new DateOnly(2026, 8, 18), "Shopee", null, "Credit card" },
                    { 105, -8000L, "Transport", new DateOnly(2026, 8, 19), "SimplyGo", null, "Credit card" },
                    { 106, -10400L, "Housing", new DateOnly(2026, 8, 20), "Mr DIY", null, "Credit card" },
                    { 107, -6470L, "Food", new DateOnly(2026, 8, 22), "GrabFood", null, "Credit card" },
                    { 108, -20000L, "Other", new DateOnly(2026, 8, 23), "Wedding ang bao", null, "PayNow" },
                    { 109, -8000L, "Food", new DateOnly(2026, 8, 24), "NTUC FairPrice", null, "PayNow" },
                    { 110, -5490L, "Shopping", new DateOnly(2026, 8, 25), "Watsons", null, "Credit card" },
                    { 111, -9600L, "Housing", new DateOnly(2026, 8, 26), "Helpling", null, "Credit card" },
                    { 112, -4500L, "Food", new DateOnly(2026, 8, 28), "Kopitiam", null, "PayNow" },
                    { 113, -5960L, "Transport", new DateOnly(2026, 8, 29), "Grab ride", null, "Credit card" },
                    { 114, -1300L, "Other", new DateOnly(2026, 8, 30), "SPCA donation", null, "PayNow" },
                    { 115, -3840L, "Food", new DateOnly(2026, 9, 1), "NTUC FairPrice", null, "PayNow" },
                    { 116, -860L, "Food", new DateOnly(2026, 9, 1), "Toast Box", null, "Credit card" },
                    { 117, -1300L, "Transport", new DateOnly(2026, 9, 1), "SimplyGo", null, "Credit card" },
                    { 118, -7800L, "Housing", new DateOnly(2026, 9, 2), "Town Council S&CC", null, "GIRO" },
                    { 119, -720L, "Food", new DateOnly(2026, 9, 2), "Ya Kun Kaya Toast", null, "PayNow" },
                    { 120, -2480L, "Transport", new DateOnly(2026, 9, 2), "Grab ride", null, "Credit card" },
                    { 121, -4800L, "Bills", new DateOnly(2026, 9, 3), "Singtel", null, "GIRO" },
                    { 122, -650L, "Food", new DateOnly(2026, 9, 3), "Koufu", null, "PayNow" },
                    { 123, -4050L, "Shopping", new DateOnly(2026, 9, 3), "Popular Bookstore", null, "Credit card" },
                    { 124, -18900L, "Housing", new DateOnly(2026, 9, 4), "Fortytwo", null, "Credit card" },
                    { 125, -3900L, "Housing", new DateOnly(2026, 9, 4), "Mr DIY", null, "Credit card" },
                    { 126, -2940L, "Food", new DateOnly(2026, 9, 4), "Sheng Siong", null, "PayNow" },
                    { 127, -1460L, "Food", new DateOnly(2026, 9, 4), "Kopitiam", null, "PayNow" },
                    { 128, -4000L, "Transport", new DateOnly(2026, 9, 4), "Grab ride", null, "Credit card" },
                    { 129, -2000L, "Transport", new DateOnly(2026, 9, 5), "SimplyGo", null, "Credit card" },
                    { 130, -1290L, "Food", new DateOnly(2026, 9, 5), "McDonald's", null, "Credit card" },
                    { 131, -1210L, "Food", new DateOnly(2026, 9, 5), "Starbucks", null, "Credit card" },
                    { 132, -4230L, "Food", new DateOnly(2026, 9, 6), "NTUC FairPrice", null, "PayNow" },
                    { 133, -1170L, "Food", new DateOnly(2026, 9, 6), "Maxwell Food Centre", null, "PayNow" },
                    { 134, -1600L, "Transport", new DateOnly(2026, 9, 6), "Grab ride", null, "Credit card" },
                    { 135, -9800L, "Food", new DateOnly(2026, 9, 7), "Jumbo Seafood", null, "Credit card" },
                    { 136, -3200L, "Transport", new DateOnly(2026, 9, 7), "Grab ride", null, "Credit card" },
                    { 137, -5160L, "Bills", new DateOnly(2026, 9, 8), "StarHub", null, "GIRO" },
                    { 138, -540L, "Food", new DateOnly(2026, 9, 8), "Old Chang Kee", null, "PayNow" },
                    { 139, -3100L, "Shopping", new DateOnly(2026, 9, 8), "Watsons", null, "Credit card" },
                    { 140, -6000L, "Housing", new DateOnly(2026, 9, 9), "Helpling", null, "Credit card" },
                    { 141, -7000L, "Food", new DateOnly(2026, 9, 9), "Hai Di Lao", null, "Credit card" },
                    { 142, -2000L, "Transport", new DateOnly(2026, 9, 9), "SimplyGo", null, "Credit card" },
                    { 143, -5490L, "Shopping", new DateOnly(2026, 9, 10), "Shopee", null, "Credit card" },
                    { 144, -710L, "Food", new DateOnly(2026, 9, 10), "Toast Box", null, "Credit card" },
                    { 145, -1000L, "Food", new DateOnly(2026, 9, 10), "GrabFood", null, "Credit card" },
                    { 146, -9600L, "Housing", new DateOnly(2026, 9, 11), "CoolTech Aircon", null, "PayNow" },
                    { 147, -2985L, "Food", new DateOnly(2026, 9, 11), "NTUC FairPrice", null, "PayNow" },
                    { 148, -1415L, "Food", new DateOnly(2026, 9, 11), "Tim Ho Wan", null, "Credit card" },
                    { 149, -2240L, "Shopping", new DateOnly(2026, 9, 12), "Guardian", null, "Credit card" },
                    { 150, -3260L, "Food", new DateOnly(2026, 9, 12), "Swee Choon", null, "PayNow" },
                    { 151, -7480L, "Shopping", new DateOnly(2026, 9, 13), "Lazada", null, "Credit card" },
                    { 152, -920L, "Food", new DateOnly(2026, 9, 13), "Koufu", null, "PayNow" },
                    { 153, -2000L, "Transport", new DateOnly(2026, 9, 13), "SimplyGo", null, "Credit card" },
                    { 154, -820L, "Food", new DateOnly(2026, 9, 14), "Kopitiam", null, "PayNow" },
                    { 155, -2000L, "Transport", new DateOnly(2026, 9, 15), "SimplyGo", null, "Credit card" },
                    { 156, -835L, "Food", new DateOnly(2026, 9, 15), "Ya Kun Kaya Toast", null, "PayNow" },
                    { 157, -6000L, "Housing", new DateOnly(2026, 9, 16), "Helpling", null, "Credit card" },
                    { 158, -2360L, "Food", new DateOnly(2026, 9, 16), "NTUC FairPrice", null, "PayNow" },
                    { 159, -4000L, "Transport", new DateOnly(2026, 9, 16), "SimplyGo", null, "Credit card" },
                    { 160, -4200L, "Food", new DateOnly(2026, 9, 17), "Ichiban Sushi", null, "Credit card" },
                    { 161, -9000L, "Housing", new DateOnly(2026, 9, 17), "IKEA", null, "Credit card" },
                    { 162, -4540L, "Transport", new DateOnly(2026, 9, 19), "Grab ride", null, "Credit card" },
                    { 163, -3550L, "Shopping", new DateOnly(2026, 9, 19), "Decathlon", null, "Credit card" },
                    { 164, -2100L, "Food", new DateOnly(2026, 9, 19), "Tim Ho Wan", null, "Credit card" },
                    { 165, -1750L, "Food", new DateOnly(2026, 9, 19), "NTUC FairPrice", null, "PayNow" },
                    { 166, -980L, "Food", new DateOnly(2026, 9, 19), "Starbucks", null, "Credit card" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 166);
        }
    }
}
