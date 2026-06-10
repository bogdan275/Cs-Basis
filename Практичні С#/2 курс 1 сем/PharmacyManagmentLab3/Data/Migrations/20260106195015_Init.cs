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
                name: "active_ingredients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_active_ingredients", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "brands",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_brands", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "refrigerators",
                columns: table => new
                {
                    Refrigerator_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Refrigerator_Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_refrigerators", x => x.Refrigerator_Id);
                });

            migrationBuilder.CreateTable(
                name: "return_policies",
                columns: table => new
                {
                    Return_Policy_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Can_Return = table.Column<bool>(type: "bit", nullable: false),
                    Reason = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Signature1 = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Signature2 = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Pasport_Data = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SaleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_return_policies", x => x.Return_Policy_Id);
                });

            migrationBuilder.CreateTable(
                name: "shelves",
                columns: table => new
                {
                    ShelfId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Zone = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ShelfNumber = table.Column<int>(type: "int", nullable: false),
                    RowNumber = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_shelves", x => x.ShelfId);
                });

            migrationBuilder.CreateTable(
                name: "suppliers",
                columns: table => new
                {
                    SupplierId = table.Column<int>(type: "int", maxLength: 50, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SupplierName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_suppliers", x => x.SupplierId);
                });

            migrationBuilder.CreateTable(
                name: "medicines",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Storage_Conditions = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Is_Child_form = table.Column<bool>(type: "bit", nullable: false),
                    Seasonal_Status = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Dosage = table.Column<int>(type: "int", nullable: false),
                    Release_Form = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Prescription_Required = table.Column<bool>(type: "bit", nullable: false),
                    BrandId = table.Column<int>(type: "int", nullable: false),
                    Active_IngredientId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_medicines", x => x.Id);
                    table.ForeignKey(
                        name: "FK_medicines_active_ingredients_Active_IngredientId",
                        column: x => x.Active_IngredientId,
                        principalTable: "active_ingredients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_medicines_brands_BrandId",
                        column: x => x.BrandId,
                        principalTable: "brands",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "refrigerator_logs",
                columns: table => new
                {
                    Log_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Min_Temp = table.Column<double>(type: "float", nullable: false),
                    Max_Temp = table.Column<double>(type: "float", nullable: false),
                    Current_Temp = table.Column<double>(type: "float", nullable: false),
                    Log_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RefrigeratorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_refrigerator_logs", x => x.Log_Id);
                    table.ForeignKey(
                        name: "FK_refrigerator_logs_refrigerators_RefrigeratorId",
                        column: x => x.RefrigeratorId,
                        principalTable: "refrigerators",
                        principalColumn: "Refrigerator_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "purchase_orders",
                columns: table => new
                {
                    Purchase_Order_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Order_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SupplierId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_purchase_orders", x => x.Purchase_Order_Id);
                    table.ForeignKey(
                        name: "FK_purchase_orders_suppliers_SupplierId",
                        column: x => x.SupplierId,
                        principalTable: "suppliers",
                        principalColumn: "SupplierId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "recipes",
                columns: table => new
                {
                    Recipe_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Doctor_Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Doctor_Phone = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Can_use_alternative = table.Column<bool>(type: "bit", nullable: false),
                    MedicineId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_recipes", x => x.Recipe_Id);
                    table.ForeignKey(
                        name: "FK_recipes_medicines_MedicineId",
                        column: x => x.MedicineId,
                        principalTable: "medicines",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "shelf_items",
                columns: table => new
                {
                    Shelf_Item_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Face_Required = table.Column<int>(type: "int", nullable: false),
                    Face_Current = table.Column<int>(type: "int", nullable: false),
                    Location_Hint = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Last_Updated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ShelfId = table.Column<int>(type: "int", nullable: false),
                    MedicineId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_shelf_items", x => x.Shelf_Item_Id);
                    table.ForeignKey(
                        name: "FK_shelf_items_medicines_MedicineId",
                        column: x => x.MedicineId,
                        principalTable: "medicines",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_shelf_items_shelves_ShelfId",
                        column: x => x.ShelfId,
                        principalTable: "shelves",
                        principalColumn: "ShelfId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "purchase_order_items",
                columns: table => new
                {
                    Purchase_Order_Item_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Purchase_orderId = table.Column<int>(type: "int", nullable: false),
                    MedicineId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_purchase_order_items", x => x.Purchase_Order_Item_Id);
                    table.ForeignKey(
                        name: "FK_purchase_order_items_medicines_MedicineId",
                        column: x => x.MedicineId,
                        principalTable: "medicines",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_purchase_order_items_purchase_orders_Purchase_orderId",
                        column: x => x.Purchase_orderId,
                        principalTable: "purchase_orders",
                        principalColumn: "Purchase_Order_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "batches",
                columns: table => new
                {
                    Batch_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Batch_Num = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Arrival_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Expiri_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Alert_Quantity = table.Column<int>(type: "int", nullable: false),
                    Stock_Quantity = table.Column<int>(type: "int", nullable: false),
                    Unit_Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Initial_Quantity = table.Column<int>(type: "int", nullable: false),
                    MedicineId = table.Column<int>(type: "int", nullable: false),
                    Purchase_OrderId = table.Column<int>(type: "int", nullable: false),
                    Purchase_Order_ItemId = table.Column<int>(type: "int", nullable: true),
                    RefrigeratorId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_batches", x => x.Batch_Id);
                    table.ForeignKey(
                        name: "FK_batches_medicines_MedicineId",
                        column: x => x.MedicineId,
                        principalTable: "medicines",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_batches_purchase_order_items_Purchase_Order_ItemId",
                        column: x => x.Purchase_Order_ItemId,
                        principalTable: "purchase_order_items",
                        principalColumn: "Purchase_Order_Item_Id");
                    table.ForeignKey(
                        name: "FK_batches_purchase_orders_Purchase_OrderId",
                        column: x => x.Purchase_OrderId,
                        principalTable: "purchase_orders",
                        principalColumn: "Purchase_Order_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_batches_refrigerators_RefrigeratorId",
                        column: x => x.RefrigeratorId,
                        principalTable: "refrigerators",
                        principalColumn: "Refrigerator_Id",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateTable(
                name: "sales",
                columns: table => new
                {
                    Sale_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date_Of_Sale = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Customer_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    MedicineId = table.Column<int>(type: "int", nullable: false),
                    BatchId = table.Column<int>(type: "int", nullable: false),
                    Return_Policy_Id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sales", x => x.Sale_Id);
                    table.ForeignKey(
                        name: "FK_sales_batches_BatchId",
                        column: x => x.BatchId,
                        principalTable: "batches",
                        principalColumn: "Batch_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_sales_medicines_MedicineId",
                        column: x => x.MedicineId,
                        principalTable: "medicines",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_sales_return_policies_Return_Policy_Id",
                        column: x => x.Return_Policy_Id,
                        principalTable: "return_policies",
                        principalColumn: "Return_Policy_Id",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.InsertData(
                table: "active_ingredients",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Paracetamol" },
                    { 2, "Ibuprofen" },
                    { 3, "Amoxicillin" },
                    { 4, "Cetirizine" },
                    { 5, "Loratadine" },
                    { 6, "Azithromycin" },
                    { 7, "Metformin" },
                    { 8, "Omeprazole" },
                    { 9, "Aspirin" },
                    { 10, "Dextromethorphan" }
                });

            migrationBuilder.InsertData(
                table: "brands",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Bayer" },
                    { 2, "Pfizer" },
                    { 3, "Novartis" },
                    { 4, "Johnson & Johnson" },
                    { 5, "GSK" },
                    { 6, "Sanofi" },
                    { 7, "Roche" },
                    { 8, "Merck" },
                    { 9, "AstraZeneca" },
                    { 10, "Teva" }
                });

            migrationBuilder.InsertData(
                table: "refrigerators",
                columns: new[] { "Refrigerator_Id", "Refrigerator_Name" },
                values: new object[,]
                {
                    { 1, "Main Storage Fridge A" },
                    { 2, "Main Storage Fridge B" },
                    { 3, "Vaccine Storage Unit" },
                    { 4, "Insulin Storage Fridge" },
                    { 5, "Backup Cooling Unit" }
                });

            migrationBuilder.InsertData(
                table: "return_policies",
                columns: new[] { "Return_Policy_Id", "Can_Return", "Pasport_Data", "Reason", "SaleId", "Signature1", "Signature2" },
                values: new object[,]
                {
                    { 1, false, "AA1234567", "Wrong medicine purchased", 1, "O. Ivanov", "Pharmacist A" },
                    { 2, false, "BB7654321", "Allergic reaction", 2, "Y. Moroz", "Pharmacist B" },
                    { 3, false, "CC1122334", "Expired product", 3, "V. Kravchenko", "Pharmacist C" },
                    { 4, false, "DD5566778", "Doctor changed prescription", 4, "I. Savchenko", "Pharmacist A" },
                    { 5, false, "EE9988776", "Duplicate purchase", 5, "D. Polishchuk", "Pharmacist D" }
                });

            migrationBuilder.InsertData(
                table: "shelves",
                columns: new[] { "ShelfId", "RowNumber", "ShelfNumber", "Zone" },
                values: new object[,]
                {
                    { 1, 1, 1, "Zone A" },
                    { 2, 2, 1, "Zone A" },
                    { 3, 1, 2, "Zone A" },
                    { 4, 1, 1, "Zone B" },
                    { 5, 2, 1, "Zone B" },
                    { 6, 1, 2, "Zone B" },
                    { 7, 1, 1, "Zone C" },
                    { 8, 2, 1, "Zone C" },
                    { 9, 1, 2, "Zone C" },
                    { 10, 1, 1, "Zone D" }
                });

            migrationBuilder.InsertData(
                table: "suppliers",
                columns: new[] { "SupplierId", "Phone", "SupplierName" },
                values: new object[,]
                {
                    { 1, "+380501234567", "MedSupply Co." },
                    { 2, "+380502345678", "PharmaDistribution Ltd." },
                    { 3, "+380503456789", "HealthCare Supplies" },
                    { 4, "+380504567890", "Global Pharma Inc." },
                    { 5, "+380505678901", "MediWorld Trading" },
                    { 6, "+380506789012", "PharmaTech Solutions" },
                    { 7, "+380507890123", "BioMed Distributors" },
                    { 8, "+380508901234", "EuroPharma Group" },
                    { 9, "+380509012345", "MedExpress Logistics" },
                    { 10, "+380500123456", "Pharmaceutical Wholesale" }
                });

            migrationBuilder.InsertData(
                table: "medicines",
                columns: new[] { "Id", "Active_IngredientId", "BrandId", "Dosage", "Is_Child_form", "Name", "Prescription_Required", "Release_Form", "Seasonal_Status", "Storage_Conditions" },
                values: new object[,]
                {
                    { 1, 1, 1, 500, false, "Panadol", false, "Tablets", "Year-round", "Room temperature" },
                    { 2, 2, 2, 400, false, "Nurofen", false, "Tablets", "Year-round", "Room temperature" },
                    { 3, 3, 3, 250, false, "Amoxil", true, "Capsules", "Year-round", "Room temperature" },
                    { 4, 4, 4, 10, false, "Zyrtec", false, "Tablets", "Spring/Fall", "Room temperature" },
                    { 5, 5, 5, 10, false, "Claritin", false, "Tablets", "Spring/Fall", "Room temperature" },
                    { 6, 6, 6, 500, false, "Zithromax", true, "Tablets", "Year-round", "Room temperature" },
                    { 7, 7, 7, 850, false, "Glucophage", true, "Tablets", "Year-round", "Room temperature" },
                    { 8, 8, 8, 20, false, "Prilosec", false, "Capsules", "Year-round", "Room temperature" },
                    { 9, 9, 1, 100, false, "Aspirin Bayer", false, "Tablets", "Year-round", "Room temperature" },
                    { 10, 10, 9, 15, true, "Robitussin", false, "Syrup", "Winter", "Room temperature" }
                });

            migrationBuilder.InsertData(
                table: "purchase_orders",
                columns: new[] { "Purchase_Order_Id", "Order_Date", "Status", "SupplierId" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed", 1 },
                    { 2, new DateTime(2024, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed", 2 },
                    { 3, new DateTime(2024, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pending", 3 },
                    { 4, new DateTime(2024, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed", 4 },
                    { 5, new DateTime(2024, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "In Transit", 5 },
                    { 6, new DateTime(2024, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed", 6 },
                    { 7, new DateTime(2024, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pending", 7 },
                    { 8, new DateTime(2024, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed", 8 },
                    { 9, new DateTime(2024, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "In Transit", 9 },
                    { 10, new DateTime(2024, 11, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pending", 10 }
                });

            migrationBuilder.InsertData(
                table: "refrigerator_logs",
                columns: new[] { "Log_Id", "Current_Temp", "Log_Date", "Max_Temp", "Min_Temp", "RefrigeratorId" },
                values: new object[,]
                {
                    { 1, 5.2000000000000002, new DateTime(2024, 11, 28, 8, 0, 0, 0, DateTimeKind.Unspecified), 8.0, 2.0, 1 },
                    { 2, 4.7999999999999998, new DateTime(2024, 11, 28, 12, 0, 0, 0, DateTimeKind.Unspecified), 8.0, 2.0, 1 },
                    { 3, 6.0999999999999996, new DateTime(2024, 11, 28, 8, 0, 0, 0, DateTimeKind.Unspecified), 8.0, 2.0, 2 },
                    { 4, 5.5, new DateTime(2024, 11, 28, 12, 0, 0, 0, DateTimeKind.Unspecified), 8.0, 2.0, 2 },
                    { 5, 3.8999999999999999, new DateTime(2024, 11, 28, 8, 0, 0, 0, DateTimeKind.Unspecified), 8.0, 2.0, 3 },
                    { 6, 4.2000000000000002, new DateTime(2024, 11, 28, 12, 0, 0, 0, DateTimeKind.Unspecified), 8.0, 2.0, 3 },
                    { 7, 5.7999999999999998, new DateTime(2024, 11, 28, 8, 0, 0, 0, DateTimeKind.Unspecified), 8.0, 2.0, 4 },
                    { 8, 6.2999999999999998, new DateTime(2024, 11, 28, 12, 0, 0, 0, DateTimeKind.Unspecified), 8.0, 2.0, 4 },
                    { 9, 4.5, new DateTime(2024, 11, 28, 8, 0, 0, 0, DateTimeKind.Unspecified), 8.0, 2.0, 5 },
                    { 10, 5.0, new DateTime(2024, 11, 28, 12, 0, 0, 0, DateTimeKind.Unspecified), 8.0, 2.0, 5 }
                });

            migrationBuilder.InsertData(
                table: "batches",
                columns: new[] { "Batch_Id", "Alert_Quantity", "Arrival_Date", "Batch_Num", "Expiri_Date", "Initial_Quantity", "MedicineId", "Purchase_OrderId", "Purchase_Order_ItemId", "RefrigeratorId", "Stock_Quantity", "Unit_Price" },
                values: new object[,]
                {
                    { 1, 0, new DateTime(2024, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "BTH-2024-001", new DateTime(2026, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 100, 1, 1, null, null, 100, 1275.00m },
                    { 2, 0, new DateTime(2024, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "BTH-2024-002", new DateTime(2026, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 150, 2, 1, null, null, 150, 2700.00m },
                    { 3, 0, new DateTime(2024, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "BTH-2024-003", new DateTime(2026, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 80, 3, 2, null, null, 80, 1200.00m },
                    { 4, 0, new DateTime(2024, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "BTH-2024-004", new DateTime(2027, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 200, 4, 2, null, null, 200, 3000.00m },
                    { 5, 0, new DateTime(2024, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "BTH-2024-005", new DateTime(2027, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 120, 5, 4, null, null, 120, 1800.00m },
                    { 6, 0, new DateTime(2024, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "BTH-2024-006", new DateTime(2026, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 90, 6, 6, null, 1, 90, 4950.00m },
                    { 7, 0, new DateTime(2024, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "BTH-2024-007", new DateTime(2027, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 180, 8, 8, null, null, 180, 5130.00m },
                    { 8, 0, new DateTime(2024, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "BTH-2024-008", new DateTime(2027, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 140, 9, 1, null, null, 140, 1680.00m },
                    { 9, 0, new DateTime(2024, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "BTH-2024-009", new DateTime(2026, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 75, 10, 8, null, 2, 75, 1125.00m },
                    { 10, 0, new DateTime(2024, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "BTH-2024-010", new DateTime(2027, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 110, 7, 2, null, null, 110, 2750.00m }
                });

            migrationBuilder.InsertData(
                table: "purchase_order_items",
                columns: new[] { "Purchase_Order_Item_Id", "MedicineId", "Purchase_orderId", "Quantity" },
                values: new object[,]
                {
                    { 1, 1, 1, 100 },
                    { 2, 2, 1, 150 },
                    { 3, 3, 2, 80 },
                    { 4, 4, 2, 200 },
                    { 5, 5, 3, 120 },
                    { 6, 6, 4, 90 },
                    { 7, 7, 5, 110 },
                    { 8, 8, 6, 180 },
                    { 9, 9, 7, 140 },
                    { 10, 10, 8, 75 }
                });

            migrationBuilder.InsertData(
                table: "recipes",
                columns: new[] { "Recipe_Id", "Can_use_alternative", "Doctor_Name", "Doctor_Phone", "MedicineId" },
                values: new object[,]
                {
                    { 1, true, "Dr. Ivan Petrov", "+380671234567", 3 },
                    { 2, false, "Dr. Olena Kovalenko", "+380672345678", 6 },
                    { 3, true, "Dr. Andriy Shevchenko", "+380673456789", 7 },
                    { 4, true, "Dr. Maria Bondarenko", "+380674567890", 3 },
                    { 5, false, "Dr. Ivan Petrov", "+380671234567", 6 },
                    { 6, true, "Dr. Serhiy Lysenko", "+380675678901", 7 },
                    { 7, false, "Dr. Olena Kovalenko", "+380672345678", 3 },
                    { 8, true, "Dr. Natalia Tkachenko", "+380676789012", 6 },
                    { 9, true, "Dr. Andriy Shevchenko", "+380673456789", 7 },
                    { 10, false, "Dr. Maria Bondarenko", "+380674567890", 3 }
                });

            migrationBuilder.InsertData(
                table: "shelf_items",
                columns: new[] { "Shelf_Item_Id", "Face_Current", "Face_Required", "Last_Updated", "Location_Hint", "MedicineId", "ShelfId" },
                values: new object[,]
                {
                    { 1, 8, 10, new DateTime(2024, 11, 13, 8, 0, 0, 0, DateTimeKind.Unspecified), "Left side", 1, 1 },
                    { 2, 12, 15, new DateTime(2024, 11, 28, 9, 0, 0, 0, DateTimeKind.Unspecified), "Center", 2, 1 },
                    { 3, 6, 8, new DateTime(2024, 11, 7, 8, 0, 0, 0, DateTimeKind.Unspecified), "Right side", 3, 2 },
                    { 4, 18, 20, new DateTime(2024, 11, 28, 8, 0, 0, 0, DateTimeKind.Unspecified), "Top shelf", 4, 3 },
                    { 5, 10, 12, new DateTime(2024, 11, 28, 8, 0, 0, 0, DateTimeKind.Unspecified), "Bottom", 5, 4 },
                    { 6, 7, 9, new DateTime(2024, 11, 28, 8, 0, 0, 0, DateTimeKind.Unspecified), "Left corner", 6, 5 },
                    { 7, 16, 18, new DateTime(2024, 11, 28, 8, 0, 0, 0, DateTimeKind.Unspecified), "Middle row", 7, 6 },
                    { 8, 11, 14, new DateTime(2024, 11, 28, 8, 0, 0, 0, DateTimeKind.Unspecified), "Right corner", 8, 7 },
                    { 9, 5, 7, new DateTime(2024, 11, 28, 8, 0, 0, 0, DateTimeKind.Unspecified), "Front facing", 9, 8 },
                    { 10, 9, 11, new DateTime(2024, 12, 28, 8, 0, 0, 0, DateTimeKind.Unspecified), "Back row", 10, 9 }
                });

            migrationBuilder.InsertData(
                table: "sales",
                columns: new[] { "Sale_Id", "BatchId", "Customer_Name", "Date_Of_Sale", "MedicineId", "Price", "Quantity", "Return_Policy_Id" },
                values: new object[,]
                {
                    { 1, 1, "Oleksandr Ivanov", new DateTime(2024, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 25.50m, 2, 1 },
                    { 2, 2, "Yulia Moroz", new DateTime(2024, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 18.00m, 1, 2 },
                    { 3, 4, "Viktor Kravchenko", new DateTime(2024, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 45.00m, 3, 3 },
                    { 4, 5, "Iryna Savchenko", new DateTime(2024, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 32.00m, 2, 4 },
                    { 5, 6, "Dmytro Polishchuk", new DateTime(2024, 11, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, 55.00m, 1, 5 },
                    { 6, 10, "Tetiana Melnyk", new DateTime(2024, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, 68.00m, 4, null },
                    { 7, 7, "Mykola Boyko", new DateTime(2024, 11, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, 28.50m, 2, null },
                    { 8, 8, "Oksana Koval", new DateTime(2024, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, 12.00m, 1, null },
                    { 9, 1, "Roman Sokolenko", new DateTime(2024, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 42.00m, 3, null },
                    { 10, 2, "Lesia Hrytsenko", new DateTime(2024, 11, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 36.00m, 2, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_batches_MedicineId",
                table: "batches",
                column: "MedicineId");

            migrationBuilder.CreateIndex(
                name: "IX_batches_Purchase_Order_ItemId",
                table: "batches",
                column: "Purchase_Order_ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_batches_Purchase_OrderId",
                table: "batches",
                column: "Purchase_OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_batches_RefrigeratorId",
                table: "batches",
                column: "RefrigeratorId");

            migrationBuilder.CreateIndex(
                name: "IX_medicines_Active_IngredientId",
                table: "medicines",
                column: "Active_IngredientId");

            migrationBuilder.CreateIndex(
                name: "IX_medicines_BrandId",
                table: "medicines",
                column: "BrandId");

            migrationBuilder.CreateIndex(
                name: "IX_purchase_order_items_MedicineId",
                table: "purchase_order_items",
                column: "MedicineId");

            migrationBuilder.CreateIndex(
                name: "IX_purchase_order_items_Purchase_orderId",
                table: "purchase_order_items",
                column: "Purchase_orderId");

            migrationBuilder.CreateIndex(
                name: "IX_purchase_orders_SupplierId",
                table: "purchase_orders",
                column: "SupplierId");

            migrationBuilder.CreateIndex(
                name: "IX_recipes_MedicineId",
                table: "recipes",
                column: "MedicineId");

            migrationBuilder.CreateIndex(
                name: "IX_refrigerator_logs_RefrigeratorId",
                table: "refrigerator_logs",
                column: "RefrigeratorId");

            migrationBuilder.CreateIndex(
                name: "IX_sales_BatchId",
                table: "sales",
                column: "BatchId");

            migrationBuilder.CreateIndex(
                name: "IX_sales_MedicineId",
                table: "sales",
                column: "MedicineId");

            migrationBuilder.CreateIndex(
                name: "IX_sales_Return_Policy_Id",
                table: "sales",
                column: "Return_Policy_Id",
                unique: true,
                filter: "[Return_Policy_Id] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_shelf_items_MedicineId",
                table: "shelf_items",
                column: "MedicineId");

            migrationBuilder.CreateIndex(
                name: "IX_shelf_items_ShelfId",
                table: "shelf_items",
                column: "ShelfId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "recipes");

            migrationBuilder.DropTable(
                name: "refrigerator_logs");

            migrationBuilder.DropTable(
                name: "sales");

            migrationBuilder.DropTable(
                name: "shelf_items");

            migrationBuilder.DropTable(
                name: "batches");

            migrationBuilder.DropTable(
                name: "return_policies");

            migrationBuilder.DropTable(
                name: "shelves");

            migrationBuilder.DropTable(
                name: "purchase_order_items");

            migrationBuilder.DropTable(
                name: "refrigerators");

            migrationBuilder.DropTable(
                name: "medicines");

            migrationBuilder.DropTable(
                name: "purchase_orders");

            migrationBuilder.DropTable(
                name: "active_ingredients");

            migrationBuilder.DropTable(
                name: "brands");

            migrationBuilder.DropTable(
                name: "suppliers");
        }
    }
}
