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
                name: "Departments",
                columns: table => new
                {
                    DepartmentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartmentName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.DepartmentId);
                });

            migrationBuilder.CreateTable(
                name: "IncidentSeverities",
                columns: table => new
                {
                    SeverityId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SeverityName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    ExpectedResolutionTimeMinutes = table.Column<int>(type: "int", nullable: false),
                    NotifyManagement = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IncidentSeverities", x => x.SeverityId);
                });

            migrationBuilder.CreateTable(
                name: "ServiceCategories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceCategories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Specializations",
                columns: table => new
                {
                    SpecializationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SpecializationName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Specializations", x => x.SpecializationId);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Position = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    DepartmentId = table.Column<int>(type: "int", nullable: true),
                    SpecializationId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.EmployeeId);
                    table.ForeignKey(
                        name: "FK_Employees_Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "DepartmentId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Employees_Specializations_SpecializationId",
                        column: x => x.SpecializationId,
                        principalTable: "Specializations",
                        principalColumn: "SpecializationId",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateTable(
                name: "SpecializationCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SpecializationId = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpecializationCategories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SpecializationCategories_ServiceCategories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "ServiceCategories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SpecializationCategories_Specializations_SpecializationId",
                        column: x => x.SpecializationId,
                        principalTable: "Specializations",
                        principalColumn: "SpecializationId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AuditLogs",
                columns: table => new
                {
                    LogId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<int>(type: "int", nullable: true),
                    Action = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    EntityType = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    EntityId = table.Column<int>(type: "int", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Timestamp = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuditLogs", x => x.LogId);
                    table.ForeignKey(
                        name: "FK_AuditLogs_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateTable(
                name: "Services",
                columns: table => new
                {
                    ServiceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ServiceName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    ServiceType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Url = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    NetworkAddress = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Port = table.Column<int>(type: "int", nullable: true),
                    Criticality = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ResponsibleEmployeeId = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CheckMethod = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CheckInterval = table.Column<int>(type: "int", nullable: false),
                    Timeout = table.Column<int>(type: "int", nullable: false),
                    RetryCount = table.Column<int>(type: "int", nullable: false),
                    ExpectedStatusCode = table.Column<int>(type: "int", nullable: true),
                    ExpectedResponseContains = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    WarningResponseTime = table.Column<int>(type: "int", nullable: false),
                    CriticalResponseTime = table.Column<int>(type: "int", nullable: false),
                    MaxConsecutiveFailures = table.Column<int>(type: "int", nullable: false),
                    MinUptimePercent = table.Column<decimal>(type: "decimal(5,2)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Services", x => x.ServiceId);
                    table.ForeignKey(
                        name: "FK_Services_Employees_ResponsibleEmployeeId",
                        column: x => x.ResponsibleEmployeeId,
                        principalTable: "Employees",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_Services_ServiceCategories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "ServiceCategories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Login = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Role = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    EmployeeId = table.Column<int>(type: "int", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                    table.ForeignKey(
                        name: "FK_Users_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateTable(
                name: "MaintenanceWindows",
                columns: table => new
                {
                    MaintenanceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ServiceId = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    ScheduledByEmployeeId = table.Column<int>(type: "int", nullable: false),
                    StartDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ActualStartDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ActualEndDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Reason = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ImpactDescription = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    NotifyUsers = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaintenanceWindows", x => x.MaintenanceId);
                    table.ForeignKey(
                        name: "FK_MaintenanceWindows_Employees_ScheduledByEmployeeId",
                        column: x => x.ScheduledByEmployeeId,
                        principalTable: "Employees",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MaintenanceWindows_Services_ServiceId",
                        column: x => x.ServiceId,
                        principalTable: "Services",
                        principalColumn: "ServiceId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MonitoringChecks",
                columns: table => new
                {
                    CheckId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ServiceId = table.Column<int>(type: "int", nullable: false),
                    CheckDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ResponseTime = table.Column<int>(type: "int", nullable: true),
                    StatusCode = table.Column<int>(type: "int", nullable: true),
                    ErrorMessage = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    Details = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MonitoringChecks", x => x.CheckId);
                    table.ForeignKey(
                        name: "FK_MonitoringChecks_Services_ServiceId",
                        column: x => x.ServiceId,
                        principalTable: "Services",
                        principalColumn: "ServiceId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ServiceDependencies",
                columns: table => new
                {
                    DependencyId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ServiceId = table.Column<int>(type: "int", nullable: false),
                    DependsOnServiceId = table.Column<int>(type: "int", nullable: false),
                    DependencyType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceDependencies", x => x.DependencyId);
                    table.ForeignKey(
                        name: "FK_ServiceDependencies_Services_DependsOnServiceId",
                        column: x => x.DependsOnServiceId,
                        principalTable: "Services",
                        principalColumn: "ServiceId");
                    table.ForeignKey(
                        name: "FK_ServiceDependencies_Services_ServiceId",
                        column: x => x.ServiceId,
                        principalTable: "Services",
                        principalColumn: "ServiceId");
                });

            migrationBuilder.CreateTable(
                name: "Triggers",
                columns: table => new
                {
                    TriggerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ServiceId = table.Column<int>(type: "int", nullable: false),
                    TriggerName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    TriggerType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Condition = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    ThresholdValue = table.Column<int>(type: "int", nullable: true),
                    ConsecutiveChecks = table.Column<int>(type: "int", nullable: false),
                    IncidentSeverityId = table.Column<int>(type: "int", nullable: false),
                    IncidentPriority = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    IsEnabled = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastTriggeredAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Triggers", x => x.TriggerId);
                    table.ForeignKey(
                        name: "FK_Triggers_IncidentSeverities_IncidentSeverityId",
                        column: x => x.IncidentSeverityId,
                        principalTable: "IncidentSeverities",
                        principalColumn: "SeverityId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Triggers_Services_ServiceId",
                        column: x => x.ServiceId,
                        principalTable: "Services",
                        principalColumn: "ServiceId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Incidents",
                columns: table => new
                {
                    IncidentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ServiceId = table.Column<int>(type: "int", nullable: false),
                    SeverityId = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: false),
                    Status = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Priority = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DetectedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AssignedToEmployeeId = table.Column<int>(type: "int", nullable: true),
                    ResolvedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ClosedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DowntimeMinutes = table.Column<int>(type: "int", nullable: true),
                    RootCause = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    Solution = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    Recommendations = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    TriggeredByTriggerId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Incidents", x => x.IncidentId);
                    table.ForeignKey(
                        name: "FK_Incidents_Employees_AssignedToEmployeeId",
                        column: x => x.AssignedToEmployeeId,
                        principalTable: "Employees",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_Incidents_IncidentSeverities_SeverityId",
                        column: x => x.SeverityId,
                        principalTable: "IncidentSeverities",
                        principalColumn: "SeverityId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Incidents_Services_ServiceId",
                        column: x => x.ServiceId,
                        principalTable: "Services",
                        principalColumn: "ServiceId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Incidents_Triggers_TriggeredByTriggerId",
                        column: x => x.TriggeredByTriggerId,
                        principalTable: "Triggers",
                        principalColumn: "TriggerId",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateTable(
                name: "IncidentComments",
                columns: table => new
                {
                    CommentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IncidentId = table.Column<int>(type: "int", nullable: false),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    CommentText = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsInternal = table.Column<bool>(type: "bit", nullable: false),
                    AttachmentPath = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IncidentComments", x => x.CommentId);
                    table.ForeignKey(
                        name: "FK_IncidentComments_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_IncidentComments_Incidents_IncidentId",
                        column: x => x.IncidentId,
                        principalTable: "Incidents",
                        principalColumn: "IncidentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AuditLogs",
                columns: new[] { "LogId", "Action", "Description", "EmployeeId", "EntityId", "EntityType", "Timestamp" },
                values: new object[,]
                {
                    { 1, "ServiceCheck", "Автоматична перевірка сервісу 'Корпоративний портал': Success (245 мс)", null, 1, "Service", new DateTime(2026, 1, 31, 12, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, "IncidentCreated", "Автоматично створено інцидент 'Повільна робота порталу' (тригер: High Response Time)", null, 1, "Incident", new DateTime(2026, 1, 20, 10, 30, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "DepartmentId", "CreatedAt", "DepartmentName", "Description" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "IT Department", "Загальний IT відділ" },
                    { 2, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "DevOps Team", "Команда DevOps інженерів" },
                    { 3, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Infrastructure", "Інфраструктурний відділ" },
                    { 4, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Security", "Відділ безпеки" },
                    { 5, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Database Administration", "Адміністратори баз даних" }
                });

            migrationBuilder.InsertData(
                table: "IncidentSeverities",
                columns: new[] { "SeverityId", "Description", "ExpectedResolutionTimeMinutes", "NotifyManagement", "SeverityName" },
                values: new object[,]
                {
                    { 1, "Незначний вплив на роботу", 240, false, "Minor" },
                    { 2, "Помірний вплив на функціонал", 120, false, "Moderate" },
                    { 3, "Значний вплив на бізнес-процеси", 60, true, "Major" },
                    { 4, "Критичний збій, повна зупинка сервісу", 30, true, "Critical" }
                });

            migrationBuilder.InsertData(
                table: "ServiceCategories",
                columns: new[] { "CategoryId", "CategoryName", "Description" },
                values: new object[,]
                {
                    { 1, "Web Services", "Веб-додатки та портали" },
                    { 2, "Databases", "Системи управління базами даних" },
                    { 3, "File Systems", "Файлові сервери та сховища" },
                    { 4, "Network Services", "DNS, VPN, DHCP тощо" },
                    { 5, "APIs", "REST/SOAP API сервіси" }
                });

            migrationBuilder.InsertData(
                table: "Specializations",
                columns: new[] { "SpecializationId", "Description", "SpecializationName" },
                values: new object[,]
                {
                    { 1, "Спеціалізація на веб-сервісах та HTTP", "Web Services" },
                    { 2, "Експерти по базам даних", "Databases" },
                    { 3, "Мережеві спеціалісти", "Network Infrastructure" },
                    { 4, "Спеціалісти з безпеки", "Security" },
                    { 5, "Універсальні DevOps інженери", "DevOps" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "CreatedAt", "EmployeeId", "IsActive", "Login", "Password", "Role" },
                values: new object[] { 1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, "1", "1", "Administrator" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "DepartmentId", "Email", "FullName", "Phone", "Position", "SpecializationId" },
                values: new object[,]
                {
                    { 1, 1, "i.petrenko@company.local", "Петренко Іван Михайлович", "+380501234567", "System Administrator", 1 },
                    { 2, 5, "o.kovalenko@company.local", "Коваленко Олена Петрівна", "+380502345678", "Database Administrator", 2 },
                    { 3, 2, "a.shevchenko@company.local", "Шевченко Андрій Сергійович", "+380503456789", "Senior DevOps Engineer", 5 },
                    { 4, 3, "m.bondarenko@company.local", "Бондаренко Марія Олександрівна", "+380504567890", "Network Engineer", 3 },
                    { 5, 4, "s.lysenko@company.local", "Лисенко Сергій Васильович", "+380505678901", "Security Specialist", 4 }
                });

            migrationBuilder.InsertData(
                table: "SpecializationCategories",
                columns: new[] { "Id", "CategoryId", "SpecializationId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 5, 1 },
                    { 3, 2, 2 },
                    { 4, 4, 3 },
                    { 5, 3, 3 },
                    { 6, 1, 4 },
                    { 7, 4, 4 },
                    { 8, 5, 4 },
                    { 9, 1, 5 },
                    { 10, 2, 5 },
                    { 11, 3, 5 },
                    { 12, 4, 5 },
                    { 13, 5, 5 }
                });

            migrationBuilder.InsertData(
                table: "AuditLogs",
                columns: new[] { "LogId", "Action", "Description", "EmployeeId", "EntityId", "EntityType", "Timestamp" },
                values: new object[,]
                {
                    { 3, "IncidentResolved", "Вирішено інцидент 'Повільна робота порталу'. Причина: Високе навантаження. Рішення: Оптимізовано SQL запити.", 1, 1, "Incident", new DateTime(2026, 1, 20, 11, 15, 0, 0, DateTimeKind.Unspecified) },
                    { 4, "ServiceCreated", "Створено новий сервіс 'Backup Server' (категорія: File Systems, критичність: High)", 1, 9, "Service", new DateTime(2026, 1, 25, 10, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, "ServiceUpdated", "Оновлено сервіс 'Корпоративний портал': Змінено CheckInterval з 5 на 10 хвилин", 1, 1, "Service", new DateTime(2026, 1, 26, 14, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 6, "ServiceDeleted", "Видалено сервіс 'Old API Server' (був неактивний понад 6 місяців)", 1, 15, "Service", new DateTime(2026, 1, 28, 16, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, "MaintenanceScheduled", "Заплановано обслуговування 'Оновлення PostgreSQL до версії 15' на 15.01.2026 02:00-03:00", 2, 1, "MaintenanceWindow", new DateTime(2026, 1, 10, 14, 30, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "ServiceId", "CategoryId", "CheckInterval", "CheckMethod", "CreatedAt", "CriticalResponseTime", "Criticality", "Description", "ExpectedResponseContains", "ExpectedStatusCode", "IsActive", "MaxConsecutiveFailures", "MinUptimePercent", "NetworkAddress", "Port", "ResponsibleEmployeeId", "RetryCount", "ServiceName", "ServiceType", "Timeout", "Url", "WarningResponseTime" },
                values: new object[,]
                {
                    { 1, 1, 5, "HTTP_GET", new DateTime(2024, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 10000, "High", "Внутрішній веб-портал для співробітників", null, 200, true, 3, 99.5m, "192.168.1.100", 443, 1, 3, "Корпоративний портал", "HTTP", 10, "https://intranet.company.local", 3000 },
                    { 2, 2, 5, "TCP_Connect", new DateTime(2024, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 5000, "Critical", "PostgreSQL база даних для бухгалтерської системи", null, 200, true, 2, 99.9m, "192.168.1.101", 5432, 2, 3, "База даних бухгалтерії", "Database", 10, null, 2000 },
                    { 3, 1, 5, "HTTP_GET", new DateTime(2024, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 10000, "High", "Система управління взаємовідносинами з клієнтами", null, 200, true, 3, 99.5m, "192.168.1.102", 443, 3, 3, "CRM система", "HTTP", 10, "https://crm.company.local", 3000 },
                    { 4, 3, 15, "TCP_Connect", new DateTime(2024, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 5000, "High", "Корпоративне сховище файлів", null, 200, true, 3, 99.0m, "192.168.1.103", 445, 4, 3, "Файловий сервер", "FileSystem", 10, null, 2000 },
                    { 5, 4, 5, "TCP_Connect", new DateTime(2024, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 5000, "Critical", "Корпоративна поштова система", null, 200, true, 2, 99.9m, "mail.company.local", 25, 4, 3, "Поштовий сервер", "TCP", 10, null, 2000 },
                    { 6, 4, 10, "TCP_Connect", new DateTime(2024, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 5000, "High", "VPN для віддаленого доступу", null, 200, true, 3, 99.0m, "vpn.company.local", 1194, 5, 3, "VPN сервер", "TCP", 10, null, 2000 },
                    { 7, 4, 5, "TCP_Connect", new DateTime(2024, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 3000, "Critical", "Внутрішній DNS", null, 200, true, 2, 99.9m, "dns.company.local", 53, 4, 3, "DNS сервер", "TCP", 5, null, 1000 },
                    { 8, 5, 5, "HTTP_GET", new DateTime(2024, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 5000, "Critical", "REST API для обробки онлайн-платежів", "{\"status\":\"ok\"}", 200, true, 2, 99.9m, "192.168.1.104", 443, 3, 3, "API платежів", "HTTP", 10, "https://payment-api.company.local/health", 2000 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "CreatedAt", "EmployeeId", "IsActive", "Login", "Password", "Role" },
                values: new object[,]
                {
                    { 2, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, true, "3", "3", "TechnicalSpecialist" },
                    { 3, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, true, "2", "2", "TechnicalSpecialist" }
                });

            migrationBuilder.InsertData(
                table: "Incidents",
                columns: new[] { "IncidentId", "AssignedToEmployeeId", "ClosedAt", "Description", "DetectedAt", "DowntimeMinutes", "Priority", "Recommendations", "ResolvedAt", "RootCause", "ServiceId", "SeverityId", "Solution", "Status", "Title", "TriggeredByTriggerId" },
                values: new object[,]
                {
                    { 2, 2, null, "Періодичні втрати з'єднання з базою даних PostgreSQL. Транзакції не завершуються.", new DateTime(2026, 1, 25, 14, 20, 0, 0, DateTimeKind.Unspecified), 15, "High", "Впровадити моніторинг пулу з'єднань через pg_stat_activity. Оптимізувати довгі транзакції у додатках.", new DateTime(2026, 1, 25, 15, 45, 0, 0, DateTimeKind.Unspecified), "Переповнення пулу з'єднань через некоректну конфігурацію max_connections=100. Під час пікового навантаження всі з'єднання були зайняті.", 2, 3, "Збільшено max_connections з 100 до 200, збільшено shared_buffers до 4GB, перезапущено PostgreSQL", "Resolved", "Перебої у роботі бази даних", null },
                    { 4, null, null, "API платежів відповідає повільно, час обробки транзакцій збільшився до 6 секунд замість звичних 200мс", new DateTime(2024, 1, 20, 10, 15, 48, 0, DateTimeKind.Unspecified), null, "High", null, null, null, 8, 3, null, "New", "Підвищений час відповіді API платежів", null },
                    { 5, 4, new DateTime(2026, 1, 22, 16, 30, 0, 0, DateTimeKind.Unspecified), "DNS сервер припинив обробку запитів. Всі сервіси втратили можливість резолвити доменні імена.", new DateTime(2026, 1, 22, 16, 10, 0, 0, DateTimeKind.Unspecified), 15, "Critical", "Оновити BIND9 до останньої версії. Додати моніторинг процесу BIND9 з автоматичним перезапуском.", new DateTime(2026, 1, 22, 16, 25, 0, 0, DateTimeKind.Unspecified), "Процес BIND9 завершився через помилку сегментації (segmentation fault). Виявлено в /var/log/syslog.", 7, 3, "Перезапущено BIND9 через systemctl restart bind9. Виконано перевірку конфігурації named-checkconf.", "Closed", "DNS сервер не відповідав", null }
                });

            migrationBuilder.InsertData(
                table: "MaintenanceWindows",
                columns: new[] { "MaintenanceId", "ActualEndDateTime", "ActualStartDateTime", "Description", "EndDateTime", "ImpactDescription", "NotifyUsers", "Reason", "ScheduledByEmployeeId", "ServiceId", "StartDateTime", "Status", "Title" },
                values: new object[,]
                {
                    { 1, new DateTime(2026, 1, 15, 2, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 1, 15, 2, 0, 0, 0, DateTimeKind.Unspecified), "Планове оновлення СУБД для покращення продуктивності та безпеки", new DateTime(2026, 1, 15, 3, 0, 0, 0, DateTimeKind.Unspecified), "База даних буде повністю недоступна протягом 1 години. Всі додатки, що використовують БД, не працюватимуть.", true, "Software Update", 2, 2, new DateTime(2026, 1, 15, 2, 0, 0, 0, DateTimeKind.Unspecified), "Completed", "Оновлення PostgreSQL до версії 15" },
                    { 2, null, null, "Критичні патчі безпеки для Apache веб-сервера (CVE-2024-XXXX)", new DateTime(2024, 1, 22, 3, 0, 0, 0, DateTimeKind.Unspecified), "Корпоративний портал буде недоступний близько 1 години", true, "Security Patch", 1, 1, new DateTime(2024, 1, 22, 2, 0, 0, 0, DateTimeKind.Unspecified), "Scheduled", "Встановлення security патчів" },
                    { 3, null, null, "Превентивна заміна диску D: через виявлені помилки SMART", new DateTime(2024, 1, 25, 22, 0, 0, 0, DateTimeKind.Unspecified), "Файловий сервер буде недоступний 2 години. Робота з файлами неможлива.", true, "Hardware Replacement", 3, 4, new DateTime(2024, 1, 25, 20, 0, 0, 0, DateTimeKind.Unspecified), "Scheduled", "Заміна жорсткого диску" }
                });

            migrationBuilder.InsertData(
                table: "MonitoringChecks",
                columns: new[] { "CheckId", "CheckDateTime", "Details", "ErrorMessage", "ResponseTime", "ServiceId", "Status", "StatusCode" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 1, 20, 9, 20, 48, 0, DateTimeKind.Unspecified), null, null, 245, 1, "Success", 200 },
                    { 2, new DateTime(2024, 1, 20, 9, 25, 48, 0, DateTimeKind.Unspecified), null, null, 280, 1, "Success", 200 },
                    { 3, new DateTime(2024, 1, 20, 9, 30, 48, 0, DateTimeKind.Unspecified), null, null, 310, 1, "Success", 200 },
                    { 4, new DateTime(2024, 1, 20, 9, 35, 48, 0, DateTimeKind.Unspecified), "Response time exceeds warning threshold", null, 4500, 1, "Warning", 200 },
                    { 5, new DateTime(2024, 1, 20, 9, 40, 48, 0, DateTimeKind.Unspecified), null, "Connection timeout after 10 seconds", null, 1, "Error", null },
                    { 6, new DateTime(2024, 1, 20, 9, 45, 48, 0, DateTimeKind.Unspecified), "Service recovered", null, 280, 1, "Success", 200 },
                    { 7, new DateTime(2024, 1, 20, 9, 20, 48, 0, DateTimeKind.Unspecified), null, null, 50, 2, "Success", null },
                    { 8, new DateTime(2024, 1, 20, 9, 25, 48, 0, DateTimeKind.Unspecified), null, null, 45, 2, "Success", null },
                    { 9, new DateTime(2024, 1, 20, 9, 20, 48, 0, DateTimeKind.Unspecified), null, null, 120, 8, "Success", 200 },
                    { 10, new DateTime(2024, 1, 20, 9, 25, 48, 0, DateTimeKind.Unspecified), null, null, 135, 8, "Success", 200 },
                    { 11, new DateTime(2024, 1, 20, 9, 20, 48, 0, DateTimeKind.Unspecified), null, null, 100, 4, "Success", null },
                    { 12, new DateTime(2024, 1, 20, 9, 35, 48, 0, DateTimeKind.Unspecified), null, null, 95, 4, "Success", null },
                    { 13, new DateTime(2024, 1, 20, 9, 20, 48, 0, DateTimeKind.Unspecified), null, null, 80, 5, "Success", null },
                    { 14, new DateTime(2024, 1, 20, 9, 25, 48, 0, DateTimeKind.Unspecified), null, null, 75, 5, "Success", null },
                    { 15, new DateTime(2024, 1, 20, 9, 20, 48, 0, DateTimeKind.Unspecified), null, null, 15, 7, "Success", null },
                    { 16, new DateTime(2024, 1, 20, 9, 25, 48, 0, DateTimeKind.Unspecified), null, null, 12, 7, "Success", null }
                });

            migrationBuilder.InsertData(
                table: "ServiceDependencies",
                columns: new[] { "DependencyId", "DependencyType", "DependsOnServiceId", "Description", "ServiceId" },
                values: new object[,]
                {
                    { 1, "Required", 2, "CRM не може працювати без бази даних", 3 },
                    { 2, "Optional", 4, "Портал працює, але не можна завантажити файли", 1 },
                    { 3, "Required", 7, "API потребує DNS для роботи", 8 },
                    { 4, "Optional", 8, "Портал працює, але онлайн-оплата недоступна", 1 }
                });

            migrationBuilder.InsertData(
                table: "Triggers",
                columns: new[] { "TriggerId", "Condition", "ConsecutiveChecks", "CreatedAt", "IncidentPriority", "IncidentSeverityId", "IsEnabled", "LastTriggeredAt", "ServiceId", "ThresholdValue", "TriggerName", "TriggerType" },
                values: new object[,]
                {
                    { 1, ">", 3, new DateTime(2024, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Medium", 2, true, null, 1, 3000, "High Response Time", "ResponseTime" },
                    { 2, "== Offline", 2, new DateTime(2024, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Critical", 4, true, null, 2, null, "Database Unavailable", "Availability" },
                    { 3, ">=", 1, new DateTime(2024, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "High", 3, true, null, 5, 3, "Multiple Connection Failures", "ConsecutiveFailures" },
                    { 4, ">", 2, new DateTime(2024, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Critical", 4, true, null, 8, 5000, "Critical API Response Time", "ResponseTime" }
                });

            migrationBuilder.InsertData(
                table: "IncidentComments",
                columns: new[] { "CommentId", "AttachmentPath", "CommentText", "CreatedAt", "EmployeeId", "IncidentId", "IsInternal" },
                values: new object[,]
                {
                    { 4, null, "Перевіряю логи PostgreSQL. Виявлено помилки: 'FATAL: sorry, too many clients already'", new DateTime(2026, 1, 25, 14, 35, 0, 0, DateTimeKind.Unspecified), 2, 2, true },
                    { 5, null, "Збільшено max_connections та shared_buffers. Перезапуск PostgreSQL запланований на 15:30.", new DateTime(2026, 1, 25, 15, 20, 0, 0, DateTimeKind.Unspecified), 2, 2, true },
                    { 6, null, "PostgreSQL перезапущено успішно. З'єднання стабільні. Моніторю ситуацію.", new DateTime(2026, 1, 25, 15, 45, 0, 0, DateTimeKind.Unspecified), 2, 2, false }
                });

            migrationBuilder.InsertData(
                table: "Incidents",
                columns: new[] { "IncidentId", "AssignedToEmployeeId", "ClosedAt", "Description", "DetectedAt", "DowntimeMinutes", "Priority", "Recommendations", "ResolvedAt", "RootCause", "ServiceId", "SeverityId", "Solution", "Status", "Title", "TriggeredByTriggerId" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2026, 1, 20, 12, 0, 0, 0, DateTimeKind.Unspecified), "Користувачі скаржаться на повільне завантаження сторінок. Час відповіді перевищує 4 секунди.", new DateTime(2026, 1, 20, 10, 30, 0, 0, DateTimeKind.Unspecified), 0, "Medium", "Розглянути масштабування сервера або впровадження load balancer. Провести аудит всіх SQL запитів.", new DateTime(2026, 1, 20, 11, 15, 0, 0, DateTimeKind.Unspecified), "Високе навантаження через велику кількість користувачів одночасно. SQL запити виконувались без індексів.", 1, 2, "Оптимізовано SQL запити до бази даних, додано індекси на таблиці users та sessions, впроваджено кешування для статичних ресурсів", "Closed", "Повільна робота порталу", 1 },
                    { 3, 4, null, "Неможливо надіслати або отримати електронну пошту. SMTP порт 25 не відповідає на з'єднання.", new DateTime(2024, 1, 30, 10, 20, 48, 0, DateTimeKind.Unspecified), 25, "Critical", null, null, null, 5, 4, null, "InProgress", "Поштовий сервер недоступний", 3 }
                });

            migrationBuilder.InsertData(
                table: "IncidentComments",
                columns: new[] { "CommentId", "AttachmentPath", "CommentText", "CreatedAt", "EmployeeId", "IncidentId", "IsInternal" },
                values: new object[,]
                {
                    { 1, null, "Виявлено проблему зі SQL запитами. Розпочинаю оптимізацію.", new DateTime(2026, 1, 20, 10, 45, 0, 0, DateTimeKind.Unspecified), 1, 1, true },
                    { 2, null, "Оптимізацію завершено. Тестую продуктивність на тестовому середовищі.", new DateTime(2026, 1, 20, 11, 10, 0, 0, DateTimeKind.Unspecified), 1, 1, true },
                    { 3, null, "Зміни застосовано на продакшні. Час відповіді знизився до 300мс. Проблема вирішена.", new DateTime(2026, 1, 20, 11, 15, 0, 0, DateTimeKind.Unspecified), 1, 1, false },
                    { 7, null, "Підключаюсь до поштового серверу для діагностики. Перевіряю статус служби Postfix.", new DateTime(2024, 1, 20, 10, 0, 48, 0, DateTimeKind.Unspecified), 4, 3, true },
                    { 8, "/uploads/incidents/3/postfix_status_screenshot.png", "Служба Postfix зупинена. Додаю скріншот помилки з systemctl status.", new DateTime(2024, 1, 20, 10, 5, 48, 0, DateTimeKind.Unspecified), 4, 3, true },
                    { 9, "/uploads/incidents/3/mailq_output.txt", "Перевіряю логи mail queue. Виявлено переповнення черги (50000+ листів).", new DateTime(2024, 1, 20, 10, 10, 48, 0, DateTimeKind.Unspecified), 4, 3, true }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AuditLogs_EmployeeId",
                table: "AuditLogs",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_AuditLogs_EntityType_EntityId_Timestamp",
                table: "AuditLogs",
                columns: new[] { "EntityType", "EntityId", "Timestamp" });

            migrationBuilder.CreateIndex(
                name: "IX_Employees_DepartmentId",
                table: "Employees",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_SpecializationId",
                table: "Employees",
                column: "SpecializationId");

            migrationBuilder.CreateIndex(
                name: "IX_IncidentComments_EmployeeId",
                table: "IncidentComments",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_IncidentComments_IncidentId",
                table: "IncidentComments",
                column: "IncidentId");

            migrationBuilder.CreateIndex(
                name: "IX_Incidents_AssignedToEmployeeId",
                table: "Incidents",
                column: "AssignedToEmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Incidents_ServiceId_Status",
                table: "Incidents",
                columns: new[] { "ServiceId", "Status" });

            migrationBuilder.CreateIndex(
                name: "IX_Incidents_SeverityId",
                table: "Incidents",
                column: "SeverityId");

            migrationBuilder.CreateIndex(
                name: "IX_Incidents_TriggeredByTriggerId",
                table: "Incidents",
                column: "TriggeredByTriggerId");

            migrationBuilder.CreateIndex(
                name: "IX_MaintenanceWindows_ScheduledByEmployeeId",
                table: "MaintenanceWindows",
                column: "ScheduledByEmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_MaintenanceWindows_ServiceId_StartDateTime_EndDateTime",
                table: "MaintenanceWindows",
                columns: new[] { "ServiceId", "StartDateTime", "EndDateTime" });

            migrationBuilder.CreateIndex(
                name: "IX_MonitoringChecks_ServiceId",
                table: "MonitoringChecks",
                column: "ServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceDependencies_DependsOnServiceId",
                table: "ServiceDependencies",
                column: "DependsOnServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceDependencies_ServiceId",
                table: "ServiceDependencies",
                column: "ServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_Services_CategoryId",
                table: "Services",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Services_ResponsibleEmployeeId",
                table: "Services",
                column: "ResponsibleEmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_SpecializationCategories_CategoryId",
                table: "SpecializationCategories",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_SpecializationCategories_SpecializationId",
                table: "SpecializationCategories",
                column: "SpecializationId");

            migrationBuilder.CreateIndex(
                name: "IX_Triggers_IncidentSeverityId",
                table: "Triggers",
                column: "IncidentSeverityId");

            migrationBuilder.CreateIndex(
                name: "IX_Triggers_ServiceId",
                table: "Triggers",
                column: "ServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_EmployeeId",
                table: "Users",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_Login",
                table: "Users",
                column: "Login",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AuditLogs");

            migrationBuilder.DropTable(
                name: "IncidentComments");

            migrationBuilder.DropTable(
                name: "MaintenanceWindows");

            migrationBuilder.DropTable(
                name: "MonitoringChecks");

            migrationBuilder.DropTable(
                name: "ServiceDependencies");

            migrationBuilder.DropTable(
                name: "SpecializationCategories");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Incidents");

            migrationBuilder.DropTable(
                name: "Triggers");

            migrationBuilder.DropTable(
                name: "IncidentSeverities");

            migrationBuilder.DropTable(
                name: "Services");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "ServiceCategories");

            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropTable(
                name: "Specializations");
        }
    }
}
