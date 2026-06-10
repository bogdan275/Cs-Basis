using Data.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace Data
{
    public static class ModelBuilderExtension
    {
        public static void SeedMonitoringData(this ModelBuilder modelBuilder)
        {
            modelBuilder.SeedDepartments();
            modelBuilder.SeedSpecializations();
            modelBuilder.SeedServiceCategories();
            modelBuilder.SeedSpecializationCategories();
            modelBuilder.SeedEmployees();
            modelBuilder.SeedIncidentSeverities();
            modelBuilder.SeedServices();
            modelBuilder.SeedServiceDependencies();
            modelBuilder.SeedTriggers();
            modelBuilder.SeedMonitoringChecks();
            modelBuilder.SeedIncidents();
            modelBuilder.SeedIncidentComments();
            modelBuilder.SeedMaintenanceWindows();
            modelBuilder.SeedAuditLogs();
            modelBuilder.SeedUsers();
        }
        private static void SeedUsers(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User
                {
                    UserId = 1,
                    Login = "1",
                    Password = "1",
                    Role = "Administrator",
                    CreatedAt = new DateTime(2024, 1, 1),
                    IsActive = true
                },
                new User
                {
                    UserId = 2,
                    Login = "3",
                    Password = "3",
                    Role = "TechnicalSpecialist",
                    CreatedAt = new DateTime(2024, 1, 1),
                    IsActive = true
                },
                new User
                {
                    UserId = 3,
                    Login = "2",
                    Password = "2",
                    Role = "TechnicalSpecialist",
                    CreatedAt = new DateTime(2024, 1, 1),
                    IsActive = true
                }
            );
        }
        private static void SeedDepartments(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Department>().HasData(
                new Department { DepartmentId = 1, DepartmentName = "IT Department", Description = "Загальний IT відділ", CreatedAt = new DateTime(2024, 1, 1) },
                new Department { DepartmentId = 2, DepartmentName = "DevOps Team", Description = "Команда DevOps інженерів", CreatedAt = new DateTime(2024, 1, 1) },
                new Department { DepartmentId = 3, DepartmentName = "Infrastructure", Description = "Інфраструктурний відділ", CreatedAt = new DateTime(2024, 1, 1) },
                new Department { DepartmentId = 4, DepartmentName = "Security", Description = "Відділ безпеки", CreatedAt = new DateTime(2024, 1, 1) },
                new Department { DepartmentId = 5, DepartmentName = "Database Administration", Description = "Адміністратори баз даних", CreatedAt = new DateTime(2024, 1, 1) }
            );
        }

        private static void SeedSpecializations(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Specialization>().HasData(
                new Specialization { SpecializationId = 1, SpecializationName = "Web Services", Description = "Спеціалізація на веб-сервісах та HTTP" },
                new Specialization { SpecializationId = 2, SpecializationName = "Databases", Description = "Експерти по базам даних" },
                new Specialization { SpecializationId = 3, SpecializationName = "Network Infrastructure", Description = "Мережеві спеціалісти" },
                new Specialization { SpecializationId = 4, SpecializationName = "Security", Description = "Спеціалісти з безпеки" },
                new Specialization { SpecializationId = 5, SpecializationName = "DevOps", Description = "Універсальні DevOps інженери" }
            );
        }

        private static void SeedServiceCategories(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ServiceCategory>().HasData(
                new ServiceCategory { CategoryId = 1, CategoryName = "Web Services", Description = "Веб-додатки та портали" },
                new ServiceCategory { CategoryId = 2, CategoryName = "Databases", Description = "Системи управління базами даних" },
                new ServiceCategory { CategoryId = 3, CategoryName = "File Systems", Description = "Файлові сервери та сховища" },
                new ServiceCategory { CategoryId = 4, CategoryName = "Network Services", Description = "DNS, VPN, DHCP тощо" },
                new ServiceCategory { CategoryId = 5, CategoryName = "APIs", Description = "REST/SOAP API сервіси" }
            );
        }

        private static void SeedSpecializationCategories(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SpecializationCategory>().HasData(
                new SpecializationCategory { Id = 1, SpecializationId = 1, CategoryId = 1 }, // Web Services
                new SpecializationCategory { Id = 2, SpecializationId = 1, CategoryId = 5 }, // APIs
                new SpecializationCategory { Id = 3, SpecializationId = 2, CategoryId = 2 }, // Databases
                new SpecializationCategory { Id = 4, SpecializationId = 3, CategoryId = 4 }, // Network Services
                new SpecializationCategory { Id = 5, SpecializationId = 3, CategoryId = 3 }, // File Systems
                new SpecializationCategory { Id = 6, SpecializationId = 4, CategoryId = 1 }, // Web Services
                new SpecializationCategory { Id = 7, SpecializationId = 4, CategoryId = 4 }, // Network Services
                new SpecializationCategory { Id = 8, SpecializationId = 4, CategoryId = 5 }, // APIs
                new SpecializationCategory { Id = 9, SpecializationId = 5, CategoryId = 1 },  // Web Services
                new SpecializationCategory { Id = 10, SpecializationId = 5, CategoryId = 2 }, // Databases
                new SpecializationCategory { Id = 11, SpecializationId = 5, CategoryId = 3 }, // File Systems
                new SpecializationCategory { Id = 12, SpecializationId = 5, CategoryId = 4 }, // Network Services
                new SpecializationCategory { Id = 13, SpecializationId = 5, CategoryId = 5 }  // APIs
            );
        }

        private static void SeedEmployees(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(
                new Employee
                {
                    EmployeeId = 1,
                    FullName = "Петренко Іван Михайлович",
                    Position = "System Administrator",
                    Email = "i.petrenko@company.local",
                    Phone = "+380501234567",
                    DepartmentId = 1,
                    SpecializationId = 1 // Web Services
                },
                new Employee
                {
                    EmployeeId = 2,
                    FullName = "Коваленко Олена Петрівна",
                    Position = "Database Administrator",
                    Email = "o.kovalenko@company.local",
                    Phone = "+380502345678",
                    DepartmentId = 5,
                    SpecializationId = 2 // Databases
                },
                new Employee
                {
                    EmployeeId = 3,
                    FullName = "Шевченко Андрій Сергійович",
                    Position = "Senior DevOps Engineer",
                    Email = "a.shevchenko@company.local",
                    Phone = "+380503456789",
                    DepartmentId = 2,
                    SpecializationId = 5 // DevOps
                },
                new Employee
                {
                    EmployeeId = 4,
                    FullName = "Бондаренко Марія Олександрівна",
                    Position = "Network Engineer",
                    Email = "m.bondarenko@company.local",
                    Phone = "+380504567890",
                    DepartmentId = 3,
                    SpecializationId = 3 // Network
                },
                new Employee
                {
                    EmployeeId = 5,
                    FullName = "Лисенко Сергій Васильович",
                    Position = "Security Specialist",
                    Email = "s.lysenko@company.local",
                    Phone = "+380505678901",
                    DepartmentId = 4,
                    SpecializationId = 4 // Security
                }
            );
        }

        private static void SeedIncidentSeverities(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<IncidentSeverity>().HasData(
                new IncidentSeverity
                {
                    SeverityId = 1,
                    SeverityName = "Minor",
                    Description = "Незначний вплив на роботу",
                    ExpectedResolutionTimeMinutes = 240, // 4 години
                    NotifyManagement = false
                },
                new IncidentSeverity
                {
                    SeverityId = 2,
                    SeverityName = "Moderate",
                    Description = "Помірний вплив на функціонал",
                    ExpectedResolutionTimeMinutes = 120, // 2 години
                    NotifyManagement = false
                },
                new IncidentSeverity
                {
                    SeverityId = 3,
                    SeverityName = "Major",
                    Description = "Значний вплив на бізнес-процеси",
                    ExpectedResolutionTimeMinutes = 60, // 1 година
                    NotifyManagement = true
                },
                new IncidentSeverity
                {
                    SeverityId = 4,
                    SeverityName = "Critical",
                    Description = "Критичний збій, повна зупинка сервісу",
                    ExpectedResolutionTimeMinutes = 30, // 30 хвилин
                    NotifyManagement = true
                }
            );
        }

        private static void SeedServices(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Service>().HasData(
                new Service
                {
                    ServiceId = 1,
                    ServiceName = "Корпоративний портал",
                    Description = "Внутрішній веб-портал для співробітників",
                    CategoryId = 1, // Web Services
                    ServiceType = "HTTP",
                    Url = "https://intranet.company.local",
                    NetworkAddress = "192.168.1.100",
                    Port = 443,
                    Criticality = "High",
                    ResponsibleEmployeeId = 1, // Петренко
                    IsActive = true,
                    CheckMethod = "HTTP_GET",
                    CheckInterval = 5,
                    Timeout = 10,
                    RetryCount = 3,
                    ExpectedStatusCode = 200,
                    WarningResponseTime = 3000,
                    CriticalResponseTime = 10000,
                    MaxConsecutiveFailures = 3,
                    MinUptimePercent = 99.5m,
                    CreatedAt = new DateTime(2024, 1, 15)
                },
                new Service
                {
                    ServiceId = 2,
                    ServiceName = "База даних бухгалтерії",
                    Description = "PostgreSQL база даних для бухгалтерської системи",
                    CategoryId = 2, // Databases
                    ServiceType = "Database",
                    NetworkAddress = "192.168.1.101",
                    Port = 5432,
                    Criticality = "Critical",
                    ResponsibleEmployeeId = 2, // Коваленко
                    IsActive = true,
                    CheckMethod = "TCP_Connect",
                    CheckInterval = 5,
                    Timeout = 10,
                    RetryCount = 3,
                    WarningResponseTime = 2000,
                    CriticalResponseTime = 5000,
                    MaxConsecutiveFailures = 2,
                    MinUptimePercent = 99.9m,
                    CreatedAt = new DateTime(2024, 1, 15)
                },
                new Service
                {
                    ServiceId = 3,
                    ServiceName = "CRM система",
                    Description = "Система управління взаємовідносинами з клієнтами",
                    CategoryId = 1, // Web Services
                    ServiceType = "HTTP",
                    Url = "https://crm.company.local",
                    NetworkAddress = "192.168.1.102",
                    Port = 443,
                    Criticality = "High",
                    ResponsibleEmployeeId = 3, // Шевченко
                    IsActive = true,
                    CheckMethod = "HTTP_GET",
                    CheckInterval = 5,
                    Timeout = 10,
                    RetryCount = 3,
                    ExpectedStatusCode = 200,
                    WarningResponseTime = 3000,
                    CriticalResponseTime = 10000,
                    MaxConsecutiveFailures = 3,
                    MinUptimePercent = 99.5m,
                    CreatedAt = new DateTime(2024, 1, 15)
                },
                new Service
                {
                    ServiceId = 4,
                    ServiceName = "Файловий сервер",
                    Description = "Корпоративне сховище файлів",
                    CategoryId = 3, // File Systems
                    ServiceType = "FileSystem",
                    NetworkAddress = "192.168.1.103",
                    Port = 445,
                    Criticality = "High",
                    ResponsibleEmployeeId = 4, // Бондаренко
                    IsActive = true,
                    CheckMethod = "TCP_Connect",
                    CheckInterval = 15,
                    Timeout = 10,
                    RetryCount = 3,
                    WarningResponseTime = 2000,
                    CriticalResponseTime = 5000,
                    MaxConsecutiveFailures = 3,
                    MinUptimePercent = 99.0m,
                    CreatedAt = new DateTime(2024, 1, 15)
                },
                new Service
                {
                    ServiceId = 5,
                    ServiceName = "Поштовий сервер",
                    Description = "Корпоративна поштова система",
                    CategoryId = 4, // Network Services
                    ServiceType = "TCP",
                    NetworkAddress = "mail.company.local",
                    Port = 25,
                    Criticality = "Critical",
                    ResponsibleEmployeeId = 4, // Бондаренко
                    IsActive = true,
                    CheckMethod = "TCP_Connect",
                    CheckInterval = 5,
                    Timeout = 10,
                    RetryCount = 3,
                    WarningResponseTime = 2000,
                    CriticalResponseTime = 5000,
                    MaxConsecutiveFailures = 2,
                    MinUptimePercent = 99.9m,
                    CreatedAt = new DateTime(2024, 1, 15)
                },
                new Service
                {
                    ServiceId = 6,
                    ServiceName = "VPN сервер",
                    Description = "VPN для віддаленого доступу",
                    CategoryId = 4, // Network Services
                    ServiceType = "TCP",
                    NetworkAddress = "vpn.company.local",
                    Port = 1194,
                    Criticality = "High",
                    ResponsibleEmployeeId = 5, // Лисенко
                    IsActive = true,
                    CheckMethod = "TCP_Connect",
                    CheckInterval = 10,
                    Timeout = 10,
                    RetryCount = 3,
                    WarningResponseTime = 2000,
                    CriticalResponseTime = 5000,
                    MaxConsecutiveFailures = 3,
                    MinUptimePercent = 99.0m,
                    CreatedAt = new DateTime(2024, 1, 15)
                },
                new Service
                {
                    ServiceId = 7,
                    ServiceName = "DNS сервер",
                    Description = "Внутрішній DNS",
                    CategoryId = 4, // Network Services
                    ServiceType = "TCP",
                    NetworkAddress = "dns.company.local",
                    Port = 53,
                    Criticality = "Critical",
                    ResponsibleEmployeeId = 4, // Бондаренко
                    IsActive = true,
                    CheckMethod = "TCP_Connect",
                    CheckInterval = 5,
                    Timeout = 5,
                    RetryCount = 3,
                    WarningResponseTime = 1000,
                    CriticalResponseTime = 3000,
                    MaxConsecutiveFailures = 2,
                    MinUptimePercent = 99.9m,
                    CreatedAt = new DateTime(2024, 1, 15)
                },
                new Service
                {
                    ServiceId = 8,
                    ServiceName = "API платежів",
                    Description = "REST API для обробки онлайн-платежів",
                    CategoryId = 5, // APIs
                    ServiceType = "HTTP",
                    Url = "https://payment-api.company.local/health",
                    NetworkAddress = "192.168.1.104",
                    Port = 443,
                    Criticality = "Critical",
                    ResponsibleEmployeeId = 3, // Шевченко
                    IsActive = true,
                    CheckMethod = "HTTP_GET",
                    CheckInterval = 5,
                    Timeout = 10,
                    RetryCount = 3,
                    ExpectedStatusCode = 200,
                    ExpectedResponseContains = "{\"status\":\"ok\"}",
                    WarningResponseTime = 2000,
                    CriticalResponseTime = 5000,
                    MaxConsecutiveFailures = 2,
                    MinUptimePercent = 99.9m,
                    CreatedAt = new DateTime(2024, 1, 15)
                }
            );
        }

        private static void SeedServiceDependencies(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ServiceDependency>().HasData(
                new ServiceDependency
                {
                    DependencyId = 1,
                    ServiceId = 3, // CRM
                    DependsOnServiceId = 2, // База даних
                    DependencyType = "Required",
                    Description = "CRM не може працювати без бази даних"
                },
                new ServiceDependency
                {
                    DependencyId = 2,
                    ServiceId = 1, // Портал
                    DependsOnServiceId = 4, // Файловий сервер
                    DependencyType = "Optional",
                    Description = "Портал працює, але не можна завантажити файли"
                },
                new ServiceDependency
                {
                    DependencyId = 3,
                    ServiceId = 8, // API платежів
                    DependsOnServiceId = 7, // DNS
                    DependencyType = "Required",
                    Description = "API потребує DNS для роботи"
                },
                new ServiceDependency
                {
                    DependencyId = 4,
                    ServiceId = 1, // Портал
                    DependsOnServiceId = 8, // API платежів
                    DependencyType = "Optional",
                    Description = "Портал працює, але онлайн-оплата недоступна"
                }
            );
        }

        private static void SeedTriggers(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Trigger>().HasData(
                new Trigger
                {
                    TriggerId = 1,
                    ServiceId = 1, // Корпоративний портал
                    TriggerName = "High Response Time",
                    TriggerType = "ResponseTime",
                    Condition = ">",
                    ThresholdValue = 3000,
                    ConsecutiveChecks = 3,
                    IncidentSeverityId = 2, // Moderate
                    IncidentPriority = "Medium",
                    IsEnabled = true,
                    CreatedAt = new DateTime(2024, 1, 20)
                },
                new Trigger
                {
                    TriggerId = 2,
                    ServiceId = 2, // База даних
                    TriggerName = "Database Unavailable",
                    TriggerType = "Availability",
                    Condition = "== Offline",
                    ConsecutiveChecks = 2,
                    IncidentSeverityId = 4, // Critical
                    IncidentPriority = "Critical",
                    IsEnabled = true,
                    CreatedAt = new DateTime(2024, 1, 20)
                },
                new Trigger
                {
                    TriggerId = 3,
                    ServiceId = 5, // Пошта
                    TriggerName = "Multiple Connection Failures",
                    TriggerType = "ConsecutiveFailures",
                    Condition = ">=",
                    ThresholdValue = 3,
                    ConsecutiveChecks = 1,
                    IncidentSeverityId = 3, // Major
                    IncidentPriority = "High",
                    IsEnabled = true,
                    CreatedAt = new DateTime(2024, 1, 20)
                },
                new Trigger
                {
                    TriggerId = 4,
                    ServiceId = 8, // API платежів
                    TriggerName = "Critical API Response Time",
                    TriggerType = "ResponseTime",
                    Condition = ">",
                    ThresholdValue = 5000,
                    ConsecutiveChecks = 2,
                    IncidentSeverityId = 4, // Critical
                    IncidentPriority = "Critical",
                    IsEnabled = true,
                    CreatedAt = new DateTime(2024, 1, 20)
                }
            );
        }
        private static void SeedMonitoringChecks(this ModelBuilder modelBuilder)
        {
            var now = new DateTime(2024, 1, 20, 10, 20, 48);

            modelBuilder.Entity<MonitoringCheck>().HasData(
                new MonitoringCheck { CheckId = 1, ServiceId = 1, CheckDateTime = now.AddHours(-1), Status = "Success", ResponseTime = 245, StatusCode = 200 },
                new MonitoringCheck { CheckId = 2, ServiceId = 1, CheckDateTime = now.AddMinutes(-55), Status = "Success", ResponseTime = 280, StatusCode = 200 },
                new MonitoringCheck { CheckId = 3, ServiceId = 1, CheckDateTime = now.AddMinutes(-50), Status = "Success", ResponseTime = 310, StatusCode = 200 },
                new MonitoringCheck { CheckId = 4, ServiceId = 1, CheckDateTime = now.AddMinutes(-45), Status = "Warning", ResponseTime = 4500, StatusCode = 200, Details = "Response time exceeds warning threshold" },
                new MonitoringCheck { CheckId = 5, ServiceId = 1, CheckDateTime = now.AddMinutes(-40), Status = "Error", ResponseTime = null, StatusCode = null, ErrorMessage = "Connection timeout after 10 seconds" },
                new MonitoringCheck { CheckId = 6, ServiceId = 1, CheckDateTime = now.AddMinutes(-35), Status = "Success", ResponseTime = 280, StatusCode = 200, Details = "Service recovered" },
                new MonitoringCheck { CheckId = 7, ServiceId = 2, CheckDateTime = now.AddHours(-1), Status = "Success", ResponseTime = 50, StatusCode = null },
                new MonitoringCheck { CheckId = 8, ServiceId = 2, CheckDateTime = now.AddMinutes(-55), Status = "Success", ResponseTime = 45, StatusCode = null },
                new MonitoringCheck { CheckId = 9, ServiceId = 8, CheckDateTime = now.AddHours(-1), Status = "Success", ResponseTime = 120, StatusCode = 200 },
                new MonitoringCheck { CheckId = 10, ServiceId = 8, CheckDateTime = now.AddMinutes(-55), Status = "Success", ResponseTime = 135, StatusCode = 200 },
                new MonitoringCheck { CheckId = 11, ServiceId = 4, CheckDateTime = now.AddHours(-1), Status = "Success", ResponseTime = 100, StatusCode = null },
                new MonitoringCheck { CheckId = 12, ServiceId = 4, CheckDateTime = now.AddMinutes(-45), Status = "Success", ResponseTime = 95, StatusCode = null },
                new MonitoringCheck { CheckId = 13, ServiceId = 5, CheckDateTime = now.AddHours(-1), Status = "Success", ResponseTime = 80, StatusCode = null },
                new MonitoringCheck { CheckId = 14, ServiceId = 5, CheckDateTime = now.AddMinutes(-55), Status = "Success", ResponseTime = 75, StatusCode = null },
                new MonitoringCheck { CheckId = 15, ServiceId = 7, CheckDateTime = now.AddHours(-1), Status = "Success", ResponseTime = 15, StatusCode = null },
                new MonitoringCheck { CheckId = 16, ServiceId = 7, CheckDateTime = now.AddMinutes(-55), Status = "Success", ResponseTime = 12, StatusCode = null }
            );
        }

        private static void SeedIncidents(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Incident>().HasData(
                new Incident
                {
                    IncidentId = 1,
                    ServiceId = 1, // Портал
                    SeverityId = 2, // Moderate
                    Title = "Повільна робота порталу",
                    Description = "Користувачі скаржаться на повільне завантаження сторінок. Час відповіді перевищує 4 секунди.",
                    Status = "Closed",
                    Priority = "Medium",
                    DetectedAt = new DateTime(2026, 1, 20, 10, 30, 0),
                    AssignedToEmployeeId = 1, // Петренко
                    ResolvedAt = new DateTime(2026, 1, 20, 11, 15, 0),
                    ClosedAt = new DateTime(2026, 1, 20, 12, 0, 0),
                    DowntimeMinutes = 0,
                    RootCause = "Високе навантаження через велику кількість користувачів одночасно. SQL запити виконувались без індексів.",
                    Solution = "Оптимізовано SQL запити до бази даних, додано індекси на таблиці users та sessions, впроваджено кешування для статичних ресурсів",
                    Recommendations = "Розглянути масштабування сервера або впровадження load balancer. Провести аудит всіх SQL запитів.",

                    TriggeredByTriggerId = 1
                },
                new Incident
                {
                    IncidentId = 2,
                    ServiceId = 2, // База даних
                    SeverityId = 3, // Major
                    Title = "Перебої у роботі бази даних",
                    Description = "Періодичні втрати з'єднання з базою даних PostgreSQL. Транзакції не завершуються.",
                    Status = "Resolved",
                    Priority = "High",
                    DetectedAt = new DateTime(2026, 1, 25, 14, 20, 0),
                    AssignedToEmployeeId = 2, // Коваленко
                    ResolvedAt = new DateTime(2026, 1, 25, 15, 45, 0),
                    DowntimeMinutes = 15,
                    RootCause = "Переповнення пулу з'єднань через некоректну конфігурацію max_connections=100. Під час пікового навантаження всі з'єднання були зайняті.",
                    Solution = "Збільшено max_connections з 100 до 200, збільшено shared_buffers до 4GB, перезапущено PostgreSQL",
                    Recommendations = "Впровадити моніторинг пулу з'єднань через pg_stat_activity. Оптимізувати довгі транзакції у додатках."
                },

                new Incident
                {
                    IncidentId = 3,
                    ServiceId = 5, // Пошта
                    SeverityId = 4, // Critical
                    Title = "Поштовий сервер недоступний",
                    Description = "Неможливо надіслати або отримати електронну пошту. SMTP порт 25 не відповідає на з'єднання.",
                    Status = "InProgress",
                    Priority = "Critical",
                    DetectedAt = new DateTime(2024, 1, 20, 10, 20, 48).AddDays(10),
                    AssignedToEmployeeId = 4, // Бондаренко
                    DowntimeMinutes = 25,
                    RootCause = null,
                    Solution = null,
                    Recommendations = null,
                    TriggeredByTriggerId = 3
                },

                new Incident
                {
                    IncidentId = 4,
                    ServiceId = 8, // API платежів
                    SeverityId = 3, // Major
                    Title = "Підвищений час відповіді API платежів",
                    Description = "API платежів відповідає повільно, час обробки транзакцій збільшився до 6 секунд замість звичних 200мс",
                    Status = "New",
                    Priority = "High",
                    DetectedAt = new DateTime(2024, 1, 20, 10, 20, 48).AddMinutes(-5),
                    AssignedToEmployeeId = null,
                    RootCause = null,
                    Solution = null,
                    Recommendations = null
                },

                new Incident
                {
                    IncidentId = 5,
                    ServiceId = 7, // DNS
                    SeverityId = 3, // Major
                    Title = "DNS сервер не відповідав",
                    Description = "DNS сервер припинив обробку запитів. Всі сервіси втратили можливість резолвити доменні імена.",
                    Status = "Closed",
                    Priority = "Critical",
                    DetectedAt = new DateTime(2026, 1, 22, 16, 10, 0),
                    AssignedToEmployeeId = 4, // Бондаренко
                    ResolvedAt = new DateTime(2026, 1, 22, 16, 25, 0),
                    ClosedAt = new DateTime(2026, 1, 22, 16, 30, 0),
                    DowntimeMinutes = 15,
                    RootCause = "Процес BIND9 завершився через помилку сегментації (segmentation fault). Виявлено в /var/log/syslog.",
                    Solution = "Перезапущено BIND9 через systemctl restart bind9. Виконано перевірку конфігурації named-checkconf.",
                    Recommendations = "Оновити BIND9 до останньої версії. Додати моніторинг процесу BIND9 з автоматичним перезапуском."
                }
            );
        }
        private static void SeedIncidentComments(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<IncidentComment>().HasData(
                new IncidentComment
                {
                    CommentId = 1,
                    IncidentId = 1,
                    EmployeeId = 1, // Петренко
                    CommentText = "Виявлено проблему зі SQL запитами. Розпочинаю оптимізацію.",
                    CreatedAt = new DateTime(2026, 1, 20, 10, 45, 0),
                    IsInternal = true,
                    AttachmentPath = null 
                },
                new IncidentComment
                {
                    CommentId = 2,
                    IncidentId = 1,
                    EmployeeId = 1, // Петренко
                    CommentText = "Оптимізацію завершено. Тестую продуктивність на тестовому середовищі.",
                    CreatedAt = new DateTime(2026, 1, 20, 11, 10, 0),
                    IsInternal = true,
                    AttachmentPath = null  
                },
                new IncidentComment
                {
                    CommentId = 3,
                    IncidentId = 1,
                    EmployeeId = 1, // Петренко
                    CommentText = "Зміни застосовано на продакшні. Час відповіді знизився до 300мс. Проблема вирішена.",
                    CreatedAt = new DateTime(2026, 1, 20, 11, 15, 0),
                    IsInternal = false,
                    AttachmentPath = null 
                },

                new IncidentComment
                {
                    CommentId = 4,
                    IncidentId = 2,
                    EmployeeId = 2, // Коваленко
                    CommentText = "Перевіряю логи PostgreSQL. Виявлено помилки: 'FATAL: sorry, too many clients already'",
                    CreatedAt = new DateTime(2026, 1, 25, 14, 35, 0),
                    IsInternal = true,
                    AttachmentPath = null
                },
                new IncidentComment
                {
                    CommentId = 5,
                    IncidentId = 2,
                    EmployeeId = 2, // Коваленко
                    CommentText = "Збільшено max_connections та shared_buffers. Перезапуск PostgreSQL запланований на 15:30.",
                    CreatedAt = new DateTime(2026, 1, 25, 15, 20, 0),
                    IsInternal = true,
                    AttachmentPath = null 
                },
                new IncidentComment
                {
                    CommentId = 6,
                    IncidentId = 2,
                    EmployeeId = 2, // Коваленко
                    CommentText = "PostgreSQL перезапущено успішно. З'єднання стабільні. Моніторю ситуацію.",
                    CreatedAt = new DateTime(2026, 1, 25, 15, 45, 0),
                    IsInternal = false,
                    AttachmentPath = null  
                },

                new IncidentComment
                {
                    CommentId = 7,
                    IncidentId = 3,
                    EmployeeId = 4, // Бондаренко
                    CommentText = "Підключаюсь до поштового серверу для діагностики. Перевіряю статус служби Postfix.",
                    CreatedAt = new DateTime(2024, 1, 20, 10, 20, 48).AddMinutes(-20),
                    IsInternal = true,
                    AttachmentPath = null 
                },
                new IncidentComment
                {
                    CommentId = 8,
                    IncidentId = 3,
                    EmployeeId = 4, // Бондаренко
                    CommentText = "Служба Postfix зупинена. Додаю скріншот помилки з systemctl status.",
                    CreatedAt = new DateTime(2024, 1, 20, 10, 20, 48).AddMinutes(-15),
                    IsInternal = true,
                    AttachmentPath = "/uploads/incidents/3/postfix_status_screenshot.png"  
                },
                new IncidentComment
                {
                    CommentId = 9,
                    IncidentId = 3,
                    EmployeeId = 4, // Бондаренко
                    CommentText = "Перевіряю логи mail queue. Виявлено переповнення черги (50000+ листів).",
                    CreatedAt = new DateTime(2024, 1, 20, 10, 20, 48).AddMinutes(-10),
                    IsInternal = true,
                    AttachmentPath = "/uploads/incidents/3/mailq_output.txt"  
                }
            );
        }

        private static void SeedMaintenanceWindows(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MaintenanceWindow>().HasData(
                new MaintenanceWindow
                {
                    MaintenanceId = 1,
                    ServiceId = 2, // База даних
                    Title = "Оновлення PostgreSQL до версії 15",
                    Description = "Планове оновлення СУБД для покращення продуктивності та безпеки",
                    ScheduledByEmployeeId = 2, // Коваленко
                    StartDateTime = new DateTime(2026, 1, 15, 2, 0, 0),
                    EndDateTime = new DateTime(2026, 1, 15, 3, 0, 0),
                    ActualStartDateTime = new DateTime(2026, 1, 15, 2, 0, 0),
                    ActualEndDateTime = new DateTime(2026, 1, 15, 2, 45, 0),
                    Status = "Completed",
                    Reason = "Software Update",
                    ImpactDescription = "База даних буде повністю недоступна протягом 1 години. Всі додатки, що використовують БД, не працюватимуть.",
                    NotifyUsers = true
                },
                new MaintenanceWindow
                {
                    MaintenanceId = 2,
                    ServiceId = 1, // Портал
                    Title = "Встановлення security патчів",
                    Description = "Критичні патчі безпеки для Apache веб-сервера (CVE-2024-XXXX)",
                    ScheduledByEmployeeId = 1, // Петренко
                    StartDateTime = new DateTime(2024, 1, 20, 10, 20, 48).AddDays(2).Date.AddHours(2), // Післязавтра о 2 ночі
                    EndDateTime = new DateTime(2024, 1, 20, 10, 20, 48).AddDays(2).Date.AddHours(3),
                    Status = "Scheduled",
                    Reason = "Security Patch",
                    ImpactDescription = "Корпоративний портал буде недоступний близько 1 години",
                    NotifyUsers = true
                },
                new MaintenanceWindow
                {
                    MaintenanceId = 3,
                    ServiceId = 4, // Файловий сервер
                    Title = "Заміна жорсткого диску",
                    Description = "Превентивна заміна диску D: через виявлені помилки SMART",
                    ScheduledByEmployeeId = 3, // Шевченко
                    StartDateTime = new DateTime(2024, 1, 20, 10, 20, 48).AddDays(5).Date.AddHours(20), // За 5 днів о 20:00
                    EndDateTime = new DateTime(2024, 1, 20, 10, 20, 48).AddDays(5).Date.AddHours(22),
                    Status = "Scheduled",
                    Reason = "Hardware Replacement",
                    ImpactDescription = "Файловий сервер буде недоступний 2 години. Робота з файлами неможлива.",
                    NotifyUsers = true
                }
            );
        }
        private static void SeedAuditLogs(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AuditLog>().HasData(
               new AuditLog
               {
                   LogId = 1,
                   EmployeeId = null,  // Система
                   Action = "ServiceCheck",
                   EntityType = "Service",
                   EntityId = 1,
                   Description = "Автоматична перевірка сервісу 'Корпоративний портал': Success (245 мс)",
                   Timestamp = new DateTime(2026, 1, 31, 12, 0, 0)
               },
                new AuditLog
                {
                    LogId = 2,
                    EmployeeId = null,  // Система
                    Action = "IncidentCreated",
                    EntityType = "Incident",
                    EntityId = 1,
                    Description = "Автоматично створено інцидент 'Повільна робота порталу' (тригер: High Response Time)",
                    Timestamp = new DateTime(2026, 1, 20, 10, 30, 0)
                },
                new AuditLog
                {
                    LogId = 3,
                    EmployeeId = 1,  // Петренко
                    Action = "IncidentResolved",
                    EntityType = "Incident",
                    EntityId = 1,
                    Description = "Вирішено інцидент 'Повільна робота порталу'. Причина: Високе навантаження. Рішення: Оптимізовано SQL запити.",
                    Timestamp = new DateTime(2026, 1, 20, 11, 15, 0)
                },
                new AuditLog
                {
                    LogId = 4,
                    EmployeeId = 1,  // Адміністратор
                    Action = "ServiceCreated",
                    EntityType = "Service",
                    EntityId = 9,
                    Description = "Створено новий сервіс 'Backup Server' (категорія: File Systems, критичність: High)",
                    Timestamp = new DateTime(2026, 1, 25, 10, 0, 0)
                },
                new AuditLog
                {
                    LogId = 5,
                    EmployeeId = 1,  // Адміністратор
                    Action = "ServiceUpdated",
                    EntityType = "Service",
                    EntityId = 1,
                    Description = "Оновлено сервіс 'Корпоративний портал': Змінено CheckInterval з 5 на 10 хвилин",
                    Timestamp = new DateTime(2026, 1, 26, 14, 30, 0)
                },
                new AuditLog
                {
                    LogId = 6,
                    EmployeeId = 1,  // Адміністратор
                    Action = "ServiceDeleted",
                    EntityType = "Service",
                    EntityId = 15,
                    Description = "Видалено сервіс 'Old API Server' (був неактивний понад 6 місяців)",
                    Timestamp = new DateTime(2026, 1, 28, 16, 0, 0)
                },
                new AuditLog
                {
                    LogId = 7,
                    EmployeeId = 2,  // Коваленко
                    Action = "MaintenanceScheduled",
                    EntityType = "MaintenanceWindow",
                    EntityId = 1,
                    Description = "Заплановано обслуговування 'Оновлення PostgreSQL до версії 15' на 15.01.2026 02:00-03:00",
                    Timestamp = new DateTime(2026, 1, 10, 14, 30, 0)
                }
            );
        }
    }
}