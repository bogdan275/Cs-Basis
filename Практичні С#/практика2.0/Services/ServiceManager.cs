using Data;
using Repositories.Main;
using Services.Reports;
using Services.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    public class ServiceManager
    {
        private readonly MonitoringContext _context;

        public AuditLogService AuditLogService { get; private set; }
        public DepartmentService DepartmentService { get; private set; }
        public EmployeeService EmployeeService { get; private set; }
        public IncidentCommentService IncidentCommentService { get; private set; }
        public IncidentService IncidentService { get; private set; }
        public IncidentSeverityService IncidentSeverityService { get; private set; }
        public MaintenanceWindowService MaintenanceWindowService { get; private set;}
        public MonitoringCheckService MonitoringCheckService { get; private set; }
        public ServiceCategoryService ServiceCategoryService { get; private set; }
        public ServiceDependencyService ServiceDependencyService { get; private set; }
        public ServiceService ServiceService { get; private set; }
        public SpecializationService SpecializationService { get; private set; }
        public TriggerService TriggerService { get; private set; }

        public ReportService ReportService { get; private set; }

        public UserService UserService { get; private set; }

        public ServiceManager()
        {
            _context = new MonitoringContext();

            var AuditLogRepo = new AuditLogRepository(_context);
            var DepartmentRepo = new DepartmentRepository(_context);
            var EmployeeRepo = new EmployeeRepository(_context);
            var IncidentCommentRepo = new IncidentCommentRepository(_context);
            var IncidentRepo = new IncidentRepository(_context);
            var IncidentSeverityRepo = new IncidentSeverityRepository(_context);
            var MaintenanceWindowRepo = new MaintenanceWindowRepository(_context);
            var MonitoringCheckRepo = new MonitoringCheckRepository(_context);
            var ServiceCategoryRepo = new ServiceCategoryRepository(_context);
            var ServiceDependencyRepo = new ServiceDependencyRepository(_context);
            var ServiceRepo = new ServiceRepository(_context);
            var SpecializationRepo = new SpecializationRepository(_context);
            var TriggerRepo = new TriggerRepository(_context);

            var UserRepo = new UserRepository(_context);

            this.AuditLogService = new AuditLogService(AuditLogRepo, EmployeeRepo);
            this.DepartmentService = new DepartmentService(DepartmentRepo);
            this.EmployeeService = new EmployeeService(EmployeeRepo, DepartmentRepo, SpecializationRepo);
            this.IncidentCommentService = new IncidentCommentService(IncidentCommentRepo, IncidentRepo, EmployeeRepo);
            this.IncidentService = new IncidentService(IncidentRepo, ServiceRepo, IncidentSeverityRepo, EmployeeRepo, AuditLogRepo);
            this.IncidentSeverityService = new IncidentSeverityService(IncidentSeverityRepo);
            this.MaintenanceWindowService = new MaintenanceWindowService(MaintenanceWindowRepo, ServiceRepo, EmployeeRepo);
            this.MonitoringCheckService = new MonitoringCheckService(MonitoringCheckRepo, ServiceRepo);
            this.ServiceCategoryService = new ServiceCategoryService(ServiceCategoryRepo);
            this.ServiceDependencyService = new ServiceDependencyService(ServiceDependencyRepo, ServiceRepo);
            this.ServiceService = new ServiceService(ServiceRepo, ServiceCategoryRepo, EmployeeRepo, AuditLogRepo);
            this.SpecializationService = new SpecializationService(SpecializationRepo);
            this.TriggerService = new TriggerService(TriggerRepo, ServiceRepo, IncidentSeverityRepo);

            this.UserService = new UserService(UserRepo, EmployeeRepo);
            this.ReportService = new ReportService(IncidentService, ServiceService, EmployeeService);
        }
    }
}
