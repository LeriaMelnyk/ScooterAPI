using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Scooter.DAL.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FullName = table.Column<string>(type: "text", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    PasswordHash = table.Column<string>(type: "text", nullable: false),
                    IsVerified = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Vehicles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Type = table.Column<string>(type: "text", nullable: false),
                    Model = table.Column<string>(type: "text", nullable: false),
                    RegistrationNumber = table.Column<string>(type: "text", nullable: false),
                    IsAvailable = table.Column<bool>(type: "boolean", nullable: false),
                    CurrentLocation = table.Column<string>(type: "text", nullable: false),
                    BatteryLevel = table.Column<int>(type: "integer", nullable: false),
                    LastServiceDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehicles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Trips",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<int>(type: "integer", nullable: false),
                    VehicleId = table.Column<int>(type: "integer", nullable: false),
                    StartTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    EndTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    StartLocation = table.Column<string>(type: "text", nullable: false),
                    EndLocation = table.Column<string>(type: "text", nullable: false),
                    DistanceKm = table.Column<double>(type: "double precision", nullable: false),
                    TotalPrice = table.Column<decimal>(type: "numeric", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trips", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Trips_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Trips_Vehicles_VehicleId",
                        column: x => x.VehicleId,
                        principalTable: "Vehicles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Feedbacks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<int>(type: "integer", nullable: false),
                    TripId = table.Column<int>(type: "integer", nullable: false),
                    Rating = table.Column<int>(type: "integer", nullable: false),
                    Comment = table.Column<string>(type: "text", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Feedbacks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Feedbacks_Trips_TripId",
                        column: x => x.TripId,
                        principalTable: "Trips",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Feedbacks_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Payments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<int>(type: "integer", nullable: false),
                    TripId = table.Column<int>(type: "integer", nullable: false),
                    Amount = table.Column<decimal>(type: "numeric", nullable: false),
                    PaymentMethod = table.Column<string>(type: "text", nullable: false),
                    PaidAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Payments_Trips_TripId",
                        column: x => x.TripId,
                        principalTable: "Trips",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Payments_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "Email", "FullName", "IsVerified", "PasswordHash" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 6, 27, 22, 58, 58, 535, DateTimeKind.Utc).AddTicks(3916), "alice@example.com", "Alice Johnson", true, "hash1" },
                    { 2, new DateTime(2025, 6, 27, 22, 58, 58, 535, DateTimeKind.Utc).AddTicks(4110), "bob@example.com", "Bob Smith", false, "hash2" },
                    { 3, new DateTime(2025, 6, 27, 22, 58, 58, 535, DateTimeKind.Utc).AddTicks(4113), "charlie@example.com", "Charlie Brown", true, "hash3" },
                    { 4, new DateTime(2025, 6, 27, 22, 58, 58, 535, DateTimeKind.Utc).AddTicks(4115), "diana@example.com", "Diana Prince", true, "hash4" },
                    { 5, new DateTime(2025, 6, 27, 22, 58, 58, 535, DateTimeKind.Utc).AddTicks(4117), "ethan@example.com", "Ethan Hunt", false, "hash5" }
                });

            migrationBuilder.InsertData(
                table: "Vehicles",
                columns: new[] { "Id", "BatteryLevel", "CurrentLocation", "IsAvailable", "LastServiceDate", "Model", "RegistrationNumber", "Type" },
                values: new object[,]
                {
                    { 1, 85, "Center Park", true, new DateTime(2025, 6, 17, 22, 58, 58, 536, DateTimeKind.Utc).AddTicks(4837), "Xiaomi M365", "SC-001", "Scooter" },
                    { 2, 100, "Main Street", true, new DateTime(2025, 6, 7, 22, 58, 58, 536, DateTimeKind.Utc).AddTicks(5121), "Giant Escape", "BK-002", "Bike" },
                    { 3, 75, "Old Town", true, new DateTime(2025, 6, 22, 22, 58, 58, 536, DateTimeKind.Utc).AddTicks(5127), "Segway Ninebot", "SC-003", "Scooter" },
                    { 4, 100, "River Side", true, new DateTime(2025, 6, 12, 22, 58, 58, 536, DateTimeKind.Utc).AddTicks(5130), "Trek FX", "BK-004", "Bike" },
                    { 5, 45, "Depot", false, new DateTime(2025, 6, 25, 22, 58, 58, 536, DateTimeKind.Utc).AddTicks(5133), "E-Twow GT", "SC-005", "Scooter" }
                });

            migrationBuilder.InsertData(
                table: "Trips",
                columns: new[] { "Id", "DistanceKm", "EndLocation", "EndTime", "StartLocation", "StartTime", "TotalPrice", "UserId", "VehicleId" },
                values: new object[,]
                {
                    { 1, 2.5, "Main Square", new DateTime(2025, 6, 24, 23, 13, 58, 536, DateTimeKind.Utc).AddTicks(6384), "Center Park", new DateTime(2025, 6, 24, 22, 58, 58, 536, DateTimeKind.Utc).AddTicks(6227), 3.50m, 1, 1 },
                    { 2, 3.1000000000000001, "Old Town", new DateTime(2025, 6, 25, 23, 18, 58, 536, DateTimeKind.Utc).AddTicks(7359), "Main Street", new DateTime(2025, 6, 25, 22, 58, 58, 536, DateTimeKind.Utc).AddTicks(7357), 4.00m, 2, 2 },
                    { 3, 1.8, "River Side", new DateTime(2025, 6, 26, 23, 8, 58, 536, DateTimeKind.Utc).AddTicks(7365), "Old Town", new DateTime(2025, 6, 26, 22, 58, 58, 536, DateTimeKind.Utc).AddTicks(7364), 2.80m, 3, 3 },
                    { 4, 4.2000000000000002, "Depot", new DateTime(2025, 6, 27, 19, 28, 58, 536, DateTimeKind.Utc).AddTicks(7377), "River Side", new DateTime(2025, 6, 27, 17, 58, 58, 536, DateTimeKind.Utc).AddTicks(7369), 5.20m, 4, 4 },
                    { 5, 3.6000000000000001, "Center Park", new DateTime(2025, 6, 27, 22, 13, 58, 536, DateTimeKind.Utc).AddTicks(7381), "Depot", new DateTime(2025, 6, 27, 20, 58, 58, 536, DateTimeKind.Utc).AddTicks(7380), 4.70m, 5, 5 }
                });

            migrationBuilder.InsertData(
                table: "Feedbacks",
                columns: new[] { "Id", "Comment", "CreatedAt", "Rating", "TripId", "UserId" },
                values: new object[,]
                {
                    { 1, "Great ride!", new DateTime(2025, 6, 24, 22, 58, 58, 536, DateTimeKind.Utc).AddTicks(9600), 5, 1, 1 },
                    { 2, "Smooth and easy.", new DateTime(2025, 6, 25, 22, 58, 58, 536, DateTimeKind.Utc).AddTicks(9738), 4, 2, 2 },
                    { 3, "Loved it!", new DateTime(2025, 6, 26, 22, 58, 58, 536, DateTimeKind.Utc).AddTicks(9741), 5, 3, 3 },
                    { 4, "Okay ride.", new DateTime(2025, 6, 27, 18, 58, 58, 536, DateTimeKind.Utc).AddTicks(9743), 3, 4, 4 },
                    { 5, "Very good!", new DateTime(2025, 6, 27, 21, 58, 58, 536, DateTimeKind.Utc).AddTicks(9745), 4, 5, 5 }
                });

            migrationBuilder.InsertData(
                table: "Payments",
                columns: new[] { "Id", "Amount", "PaidAt", "PaymentMethod", "TripId", "UserId" },
                values: new object[,]
                {
                    { 1, 3.50m, new DateTime(2025, 6, 24, 22, 58, 58, 536, DateTimeKind.Utc).AddTicks(8456), "Card", 1, 1 },
                    { 2, 4.00m, new DateTime(2025, 6, 25, 22, 58, 58, 536, DateTimeKind.Utc).AddTicks(8595), "PayPal", 2, 2 },
                    { 3, 2.80m, new DateTime(2025, 6, 26, 22, 58, 58, 536, DateTimeKind.Utc).AddTicks(8598), "Card", 3, 3 },
                    { 4, 5.20m, new DateTime(2025, 6, 27, 18, 58, 58, 536, DateTimeKind.Utc).AddTicks(8600), "Card", 4, 4 },
                    { 5, 4.70m, new DateTime(2025, 6, 27, 21, 58, 58, 536, DateTimeKind.Utc).AddTicks(8698), "PayPal", 5, 5 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Feedbacks_TripId",
                table: "Feedbacks",
                column: "TripId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Feedbacks_UserId",
                table: "Feedbacks",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_TripId",
                table: "Payments",
                column: "TripId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Payments_UserId",
                table: "Payments",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Trips_UserId",
                table: "Trips",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Trips_VehicleId",
                table: "Trips",
                column: "VehicleId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Feedbacks");

            migrationBuilder.DropTable(
                name: "Payments");

            migrationBuilder.DropTable(
                name: "Trips");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Vehicles");
        }
    }
}
