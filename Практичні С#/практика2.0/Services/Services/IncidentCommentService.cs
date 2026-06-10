using Data.Models;
using Repositories.Base;
using Repositories.Main;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Services
{
    public class IncidentCommentService
    {
        private readonly IncidentCommentRepository _commentRepo;
        private readonly IncidentRepository _incidentRepo;
        private readonly EmployeeRepository _employeeRepo;

        public IncidentCommentService(
            IncidentCommentRepository commentRepo,
            IncidentRepository incidentRepo,
            EmployeeRepository employeeRepo)
        {
            _commentRepo = commentRepo;
            _incidentRepo = incidentRepo;
            _employeeRepo = employeeRepo;
        }

        public IEnumerable<IncidentComment> GetAllComments()
        {
            return _commentRepo.GetAll();
        }

        public IEnumerable<Incident> GetAllIncidents()
        {
            return _incidentRepo.GetAll();
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            return _employeeRepo.GetAll();
        }

        public void AddComment(IncidentComment comment)
        {
            if (string.IsNullOrWhiteSpace(comment.CommentText))
            {
                throw new ArgumentException("Comment text can't be null");
            }

            comment.CreatedAt = DateTime.Now;
            _commentRepo.Add(comment);
        }

        public void UpdateComment(IncidentComment comment)
        {
            if (string.IsNullOrWhiteSpace(comment.CommentText))
            {
                throw new ArgumentException("Comment text can't be null");
            }

            _commentRepo.Update(comment);
        }

        public void DeleteComment(int commentId)
        {
            _commentRepo.Delete(commentId);
        }

        public IEnumerable<IncidentComment> GetCommentsByIncident(int incidentId)
        {
            return _commentRepo.GetAll()
                .Where(c => c.IncidentId == incidentId)
                .OrderBy(c => c.CreatedAt)
                .ToList();
        }

        public IEnumerable<IncidentComment> GetInternalComments(int incidentId)
        {
            return _commentRepo.GetAll()
                .Where(c => c.IncidentId == incidentId && c.IsInternal)
                .OrderBy(c => c.CreatedAt)
                .ToList();
        }

        public IEnumerable<IncidentComment> GetPublicComments(int incidentId)
        {
            return _commentRepo.GetAll()
                .Where(c => c.IncidentId == incidentId && !c.IsInternal)
                .OrderBy(c => c.CreatedAt)
                .ToList();
        }
    }
}
