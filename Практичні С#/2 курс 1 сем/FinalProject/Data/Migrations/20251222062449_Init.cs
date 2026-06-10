using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TariffPlans",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DailyStorageCostPerCubicMeter = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    HandlingFeePerUnit = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TariffPlans", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Warehouses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Warehouses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TariffPlanId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Clients_TariffPlans_TariffPlanId",
                        column: x => x.TariffPlanId,
                        principalTable: "TariffPlans",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StorageZones",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CostMultiplier = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    WarehouseId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StorageZones", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StorageZones_Warehouses_WarehouseId",
                        column: x => x.WarehouseId,
                        principalTable: "Warehouses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BillingRecords",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BillingDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PeriodStart = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PeriodEnd = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TotalAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClientId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BillingRecords", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BillingRecords_Clients_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Clients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "InboundOrders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClientId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InboundOrders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InboundOrders_Clients_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Clients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OutboundOrders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClientId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OutboundOrders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OutboundOrders_Clients_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Clients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SKU = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Length = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Width = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Height = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Weight = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ClientId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Clients_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Clients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StorageBins",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaxVolume = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MaxWeight = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    StorageZoneId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StorageBins", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StorageBins_StorageZones_StorageZoneId",
                        column: x => x.StorageZoneId,
                        principalTable: "StorageZones",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "InventoryItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    ArrivalDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    StorageBinId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InventoryItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InventoryItems_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InventoryItems_StorageBins_StorageBinId",
                        column: x => x.StorageBinId,
                        principalTable: "StorageBins",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StockMovements",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MovementDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    FromBinId = table.Column<int>(type: "int", nullable: true),
                    ToBinId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StockMovements", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StockMovements_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StockMovements_StorageBins_FromBinId",
                        column: x => x.FromBinId,
                        principalTable: "StorageBins",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_StockMovements_StorageBins_ToBinId",
                        column: x => x.ToBinId,
                        principalTable: "StorageBins",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "TariffPlans",
                columns: new[] { "Id", "DailyStorageCostPerCubicMeter", "HandlingFeePerUnit", "Name" },
                values: new object[,]
                {
                    { 1, 10.0m, 5.0m, "Standard Retail" },
                    { 2, 20.0m, 10.0m, "Premium Secure" },
                    { 3, 30.0m, 15.0m, "Cold Chain" },
                    { 4, 12.0m, 3.0m, "E-commerce Lite" },
                    { 5, 8.0m, 2.0m, "Wholesale Bulk" },
                    { 6, 50.0m, 25.0m, "Hazardous Material" },
                    { 7, 5.0m, 10.0m, "Long Term Storage" },
                    { 8, 15.0m, 20.0m, "Express Handling" },
                    { 9, 18.0m, 12.0m, "Fragile Goods" },
                    { 10, 25.0m, 0.0m, "VIP Client" }
                });

            migrationBuilder.InsertData(
                table: "Warehouses",
                columns: new[] { "Id", "Address", "Name" },
                values: new object[,]
                {
                    { 1, "Kyiv, Industrialna 1", "Kyiv Central Hub" },
                    { 2, "Lviv, Horodotska 220", "Lviv West Terminal" },
                    { 3, "Odesa, Prymorska 5", "Odesa Port Logistics" },
                    { 4, "Kharkiv, Gagarina 10", "Kharkiv East Depot" },
                    { 5, "Dnipro, Slobozhansky 15", "Dnipro Cargo Center" },
                    { 6, "Kyiv, Kilceva 4", "Kyiv Cold Storage" },
                    { 7, "Poltava, Kyivske Hwy 3", "Poltava Distribution" },
                    { 8, "Vinnytsia, Khmelnytske Hwy 7", "Vinnytsia Transit" },
                    { 9, "Zaporizhzhia, Metalurgiv 2", "Zaporizhzhia Industrial" },
                    { 10, "Uzhhorod, Sobranetska 100", "Uzhhorod Border Hub" }
                });

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "Id", "CompanyName", "Email", "Phone", "TariffPlanId" },
                values: new object[,]
                {
                    { 1, "TechNova", "contact@technova.com", "+380501112233", 1 },
                    { 2, "GreenGrocer", "supply@greengrocer.ua", "+380672223344", 3 },
                    { 3, "BuildMaster", "info@buildmaster.com", "+380633334455", 5 },
                    { 4, "Fashionista", "logistics@fashionista.com", "+380994445566", 1 },
                    { 5, "MediCare Pharm", "warehouse@medicare.com", "+380975556677", 2 },
                    { 6, "AutoParts UA", "sales@autoparts.ua", "+380506667788", 1 },
                    { 7, "ChemSolutions", "safety@chemsolutions.com", "+380637778899", 6 },
                    { 8, "ToyWonderland", "kids@toywonderland.com", "+380958889900", 4 },
                    { 9, "FrozenDelights", "ice@frozendelights.com", "+380679990011", 3 },
                    { 10, "LuxuryImports", "vip@luxuryimports.com", "+380501234567", 10 }
                });

            migrationBuilder.InsertData(
                table: "StorageZones",
                columns: new[] { "Id", "CostMultiplier", "Name", "WarehouseId" },
                values: new object[,]
                {
                    { 1, 1.0m, "Zone A (General)", 1 },
                    { 2, 1.5m, "Zone B (Secure)", 1 },
                    { 3, 2.0m, "Zone C (Cold)", 2 },
                    { 4, 0.8m, "Zone D (Bulk)", 2 },
                    { 5, 3.0m, "Zone E (Hazardous)", 3 },
                    { 6, 1.2m, "Zone F (Electronics)", 4 },
                    { 7, 1.1m, "Zone G (Food)", 5 },
                    { 8, 2.5m, "Zone H (Freezer)", 6 },
                    { 9, 1.0m, "Zone I (Textile)", 7 },
                    { 10, 0.5m, "Zone J (Returns)", 1 }
                });

            migrationBuilder.InsertData(
                table: "BillingRecords",
                columns: new[] { "Id", "BillingDate", "ClientId", "Description", "PeriodEnd", "PeriodStart", "TotalAmount" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Feb Storage", new DateTime(2024, 2, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1500.00m },
                    { 2, new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Feb Cold Chain", new DateTime(2024, 2, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3000.00m },
                    { 3, new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Feb Bulk", new DateTime(2024, 2, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 500.00m },
                    { 4, new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Feb Retail", new DateTime(2024, 2, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 200.00m },
                    { 5, new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "Feb Secure", new DateTime(2024, 2, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2500.00m },
                    { 6, new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "Feb Parts", new DateTime(2024, 2, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 450.00m },
                    { 7, new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, "Feb Hazardous", new DateTime(2024, 2, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5000.00m },
                    { 8, new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, "Feb E-comm", new DateTime(2024, 2, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 800.00m },
                    { 9, new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, "Feb Frozen", new DateTime(2024, 2, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1200.00m },
                    { 10, new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, "Feb VIP", new DateTime(2024, 2, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 10000.00m }
                });

            migrationBuilder.InsertData(
                table: "InboundOrders",
                columns: new[] { "Id", "ClientId", "Date", "Status" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" },
                    { 2, 2, new DateTime(2024, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" },
                    { 3, 3, new DateTime(2024, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" },
                    { 4, 4, new DateTime(2024, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" },
                    { 5, 5, new DateTime(2024, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "New" },
                    { 6, 6, new DateTime(2024, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" },
                    { 7, 7, new DateTime(2024, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Processing" },
                    { 8, 8, new DateTime(2024, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "New" },
                    { 9, 9, new DateTime(2024, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" },
                    { 10, 10, new DateTime(2024, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "New" }
                });

            migrationBuilder.InsertData(
                table: "OutboundOrders",
                columns: new[] { "Id", "ClientId", "Date", "Status" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Shipped" },
                    { 2, 2, new DateTime(2024, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Shipped" },
                    { 3, 3, new DateTime(2024, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pending" },
                    { 4, 4, new DateTime(2024, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Shipped" },
                    { 5, 5, new DateTime(2024, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cancelled" },
                    { 6, 6, new DateTime(2024, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pending" },
                    { 7, 7, new DateTime(2024, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Shipped" },
                    { 8, 8, new DateTime(2024, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Packing" },
                    { 9, 9, new DateTime(2024, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Shipped" },
                    { 10, 10, new DateTime(2024, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pending" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "ClientId", "Description", "Height", "Length", "Name", "SKU", "Weight", "Width" },
                values: new object[,]
                {
                    { 1, 1, "High-end laptop", 0.05m, 0.4m, "Laptop Pro 15", "TECH-001", 2.0m, 0.3m },
                    { 2, 2, "Fresh fruits", 0.3m, 0.5m, "Organic Apples", "FOOD-055", 10.0m, 0.4m },
                    { 3, 3, "50kg bags", 0.2m, 0.8m, "Cement Bags", "BLD-999", 50.0m, 0.5m },
                    { 4, 4, "Men's parka", 0.1m, 0.6m, "Winter Jacket", "CLTH-WIN-01", 1.2m, 0.4m },
                    { 5, 5, "Controlled substance", 0.1m, 0.2m, "Antibiotics X", "MED-AB-100", 0.5m, 0.1m },
                    { 6, 6, "Ceramic pads", 0.1m, 0.3m, "Brake Pads", "AUTO-BRK-22", 3.0m, 0.2m },
                    { 7, 7, "Corrosive", 0.6m, 0.4m, "Industrial Acid", "CHEM-ACD-05", 25.0m, 0.4m },
                    { 8, 8, "Construction set", 0.15m, 0.5m, "Lego Set Large", "TOY-LEG-500", 1.5m, 0.3m },
                    { 9, 9, "Keep frozen", 0.1m, 0.2m, "Vanilla Ice Cream", "FOOD-ICE-01", 0.5m, 0.15m },
                    { 10, 10, "Luxury item", 0.05m, 0.1m, "Gold Watch", "LUX-WTC-007", 0.3m, 0.1m }
                });

            migrationBuilder.InsertData(
                table: "StorageBins",
                columns: new[] { "Id", "Code", "MaxVolume", "MaxWeight", "StorageZoneId" },
                values: new object[,]
                {
                    { 1, "A-01-01", 2.0m, 500m, 1 },
                    { 2, "A-01-02", 2.0m, 500m, 1 },
                    { 3, "B-05-10", 1.0m, 200m, 2 },
                    { 4, "C-COLD-01", 1.5m, 300m, 3 },
                    { 5, "D-BULK-99", 10.0m, 5000m, 4 },
                    { 6, "E-HAZ-01", 0.5m, 100m, 5 },
                    { 7, "F-ELEC-05", 1.0m, 150m, 6 },
                    { 8, "G-FOOD-22", 2.0m, 400m, 7 },
                    { 9, "H-FRZ-01", 1.5m, 300m, 8 },
                    { 10, "I-TEX-07", 3.0m, 200m, 9 }
                });

            migrationBuilder.InsertData(
                table: "InventoryItems",
                columns: new[] { "Id", "ArrivalDate", "ProductId", "Quantity", "StorageBinId" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 50, 1 },
                    { 2, new DateTime(2024, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1000, 4 },
                    { 3, new DateTime(2024, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 200, 5 },
                    { 4, new DateTime(2024, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 150, 10 },
                    { 5, new DateTime(2024, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 500, 3 },
                    { 6, new DateTime(2024, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, 80, 2 },
                    { 7, new DateTime(2024, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, 20, 6 },
                    { 8, new DateTime(2024, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, 60, 2 },
                    { 9, new DateTime(2024, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, 300, 9 },
                    { 10, new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, 10, 3 }
                });

            migrationBuilder.InsertData(
                table: "StockMovements",
                columns: new[] { "Id", "FromBinId", "MovementDate", "ProductId", "Quantity", "ToBinId", "Type" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 50, 1, "Inbound" },
                    { 2, null, new DateTime(2024, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1000, 4, "Inbound" },
                    { 3, null, new DateTime(2024, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 200, 5, "Inbound" },
                    { 4, 1, new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 5, null, "Outbound" },
                    { 5, 4, new DateTime(2024, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 10, 8, "Relocation" },
                    { 6, null, new DateTime(2024, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 500, 3, "Inbound" },
                    { 7, 10, new DateTime(2024, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 2, null, "Outbound" },
                    { 8, null, new DateTime(2024, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, 20, 6, "Inbound" },
                    { 9, 2, new DateTime(2024, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, 5, 1, "Relocation" },
                    { 10, 3, new DateTime(2024, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, 1, null, "Outbound" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_BillingRecords_ClientId",
                table: "BillingRecords",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_Clients_TariffPlanId",
                table: "Clients",
                column: "TariffPlanId");

            migrationBuilder.CreateIndex(
                name: "IX_InboundOrders_ClientId",
                table: "InboundOrders",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_InventoryItems_ProductId",
                table: "InventoryItems",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_InventoryItems_StorageBinId",
                table: "InventoryItems",
                column: "StorageBinId");

            migrationBuilder.CreateIndex(
                name: "IX_OutboundOrders_ClientId",
                table: "OutboundOrders",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_ClientId",
                table: "Products",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_StockMovements_FromBinId",
                table: "StockMovements",
                column: "FromBinId");

            migrationBuilder.CreateIndex(
                name: "IX_StockMovements_ProductId",
                table: "StockMovements",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_StockMovements_ToBinId",
                table: "StockMovements",
                column: "ToBinId");

            migrationBuilder.CreateIndex(
                name: "IX_StorageBins_StorageZoneId",
                table: "StorageBins",
                column: "StorageZoneId");

            migrationBuilder.CreateIndex(
                name: "IX_StorageZones_WarehouseId",
                table: "StorageZones",
                column: "WarehouseId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BillingRecords");

            migrationBuilder.DropTable(
                name: "InboundOrders");

            migrationBuilder.DropTable(
                name: "InventoryItems");

            migrationBuilder.DropTable(
                name: "OutboundOrders");

            migrationBuilder.DropTable(
                name: "StockMovements");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "StorageBins");

            migrationBuilder.DropTable(
                name: "Clients");

            migrationBuilder.DropTable(
                name: "StorageZones");

            migrationBuilder.DropTable(
                name: "TariffPlans");

            migrationBuilder.DropTable(
                name: "Warehouses");
        }
    }
}
