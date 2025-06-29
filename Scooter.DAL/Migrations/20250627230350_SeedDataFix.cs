using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Scooter.DAL.Migrations
{
    /// <inheritdoc />
    public partial class SeedDataFix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 25, 8, 45, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 26, 9, 45, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 27, 10, 45, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 28, 15, 50, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 29, 18, 45, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 1,
                column: "PaidAt",
                value: new DateTime(2025, 6, 25, 8, 30, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 2,
                column: "PaidAt",
                value: new DateTime(2025, 6, 26, 9, 30, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 3,
                column: "PaidAt",
                value: new DateTime(2025, 6, 27, 10, 30, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 4,
                column: "PaidAt",
                value: new DateTime(2025, 6, 28, 15, 45, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 5,
                column: "PaidAt",
                value: new DateTime(2025, 6, 29, 18, 30, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 6, 25, 8, 15, 0, 0, DateTimeKind.Utc), new DateTime(2025, 6, 25, 8, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 6, 26, 9, 20, 0, 0, DateTimeKind.Utc), new DateTime(2025, 6, 26, 9, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 6, 27, 10, 10, 0, 0, DateTimeKind.Utc), new DateTime(2025, 6, 27, 10, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 6, 28, 15, 30, 0, 0, DateTimeKind.Utc), new DateTime(2025, 6, 28, 15, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 6, 29, 18, 15, 0, 0, DateTimeKind.Utc), new DateTime(2025, 6, 29, 17, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 1, 8, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 2, 8, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 3, 8, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 4, 8, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 5, 8, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastServiceDate",
                value: new DateTime(2025, 6, 18, 10, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastServiceDate",
                value: new DateTime(2025, 6, 8, 10, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 3,
                column: "LastServiceDate",
                value: new DateTime(2025, 6, 23, 10, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 4,
                column: "LastServiceDate",
                value: new DateTime(2025, 6, 13, 10, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 5,
                column: "LastServiceDate",
                value: new DateTime(2025, 6, 26, 10, 0, 0, 0, DateTimeKind.Utc));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 24, 22, 58, 58, 536, DateTimeKind.Utc).AddTicks(9600));

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 25, 22, 58, 58, 536, DateTimeKind.Utc).AddTicks(9738));

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 26, 22, 58, 58, 536, DateTimeKind.Utc).AddTicks(9741));

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 27, 18, 58, 58, 536, DateTimeKind.Utc).AddTicks(9743));

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 27, 21, 58, 58, 536, DateTimeKind.Utc).AddTicks(9745));

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 1,
                column: "PaidAt",
                value: new DateTime(2025, 6, 24, 22, 58, 58, 536, DateTimeKind.Utc).AddTicks(8456));

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 2,
                column: "PaidAt",
                value: new DateTime(2025, 6, 25, 22, 58, 58, 536, DateTimeKind.Utc).AddTicks(8595));

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 3,
                column: "PaidAt",
                value: new DateTime(2025, 6, 26, 22, 58, 58, 536, DateTimeKind.Utc).AddTicks(8598));

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 4,
                column: "PaidAt",
                value: new DateTime(2025, 6, 27, 18, 58, 58, 536, DateTimeKind.Utc).AddTicks(8600));

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 5,
                column: "PaidAt",
                value: new DateTime(2025, 6, 27, 21, 58, 58, 536, DateTimeKind.Utc).AddTicks(8698));

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 6, 24, 23, 13, 58, 536, DateTimeKind.Utc).AddTicks(6384), new DateTime(2025, 6, 24, 22, 58, 58, 536, DateTimeKind.Utc).AddTicks(6227) });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 6, 25, 23, 18, 58, 536, DateTimeKind.Utc).AddTicks(7359), new DateTime(2025, 6, 25, 22, 58, 58, 536, DateTimeKind.Utc).AddTicks(7357) });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 6, 26, 23, 8, 58, 536, DateTimeKind.Utc).AddTicks(7365), new DateTime(2025, 6, 26, 22, 58, 58, 536, DateTimeKind.Utc).AddTicks(7364) });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 6, 27, 19, 28, 58, 536, DateTimeKind.Utc).AddTicks(7377), new DateTime(2025, 6, 27, 17, 58, 58, 536, DateTimeKind.Utc).AddTicks(7369) });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 6, 27, 22, 13, 58, 536, DateTimeKind.Utc).AddTicks(7381), new DateTime(2025, 6, 27, 20, 58, 58, 536, DateTimeKind.Utc).AddTicks(7380) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 27, 22, 58, 58, 535, DateTimeKind.Utc).AddTicks(3916));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 27, 22, 58, 58, 535, DateTimeKind.Utc).AddTicks(4110));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 27, 22, 58, 58, 535, DateTimeKind.Utc).AddTicks(4113));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 27, 22, 58, 58, 535, DateTimeKind.Utc).AddTicks(4115));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 6, 27, 22, 58, 58, 535, DateTimeKind.Utc).AddTicks(4117));

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastServiceDate",
                value: new DateTime(2025, 6, 17, 22, 58, 58, 536, DateTimeKind.Utc).AddTicks(4837));

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastServiceDate",
                value: new DateTime(2025, 6, 7, 22, 58, 58, 536, DateTimeKind.Utc).AddTicks(5121));

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 3,
                column: "LastServiceDate",
                value: new DateTime(2025, 6, 22, 22, 58, 58, 536, DateTimeKind.Utc).AddTicks(5127));

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 4,
                column: "LastServiceDate",
                value: new DateTime(2025, 6, 12, 22, 58, 58, 536, DateTimeKind.Utc).AddTicks(5130));

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 5,
                column: "LastServiceDate",
                value: new DateTime(2025, 6, 25, 22, 58, 58, 536, DateTimeKind.Utc).AddTicks(5133));
        }
    }
}
