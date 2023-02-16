using EmployeLeaveManSystem.Contracts;
using EmployeLeaveManSystem.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeLeaveManSystem.Repository
{
    public class LeaveHistoryRepository : ILeaveHistoryRepository
    {
        private readonly ApplicationDbContext _db;

        public LeaveHistoryRepository(ApplicationDbContext db)
        {
            _db = db;
        }
        public bool Create(LeaveHistory entity)
        {
            _db.leaveHistories.Add(entity);
            return Save();
        }

        public bool Delete(LeaveHistory entity)
        {
            _db.leaveHistories.Remove(entity);
            return Save();
        }

        public ICollection<LeaveHistory> FindAll()
        {
            var leavehistories = _db.leaveHistories.ToList();
            return leavehistories;
        }

        public LeaveHistory FindById(int id)
        {
            var leavehistory = _db.leaveHistories.Find(id);
            return leavehistory;
        }

        public bool isExist(int id)
        {
            var exists = _db.leaveHistories.Any(q => q.Id == id);
            return exists;
        }

        public bool Save()
        {
            var changes = _db.SaveChanges();
            return changes > 0;
        }

        public bool Update(LeaveHistory entity)
        {
            _db.leaveHistories.Update(entity);
            return Save();
        }
    }
}
