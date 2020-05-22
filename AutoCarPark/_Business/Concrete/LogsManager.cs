using _AutoParkData.Models;
using _Business.Abstract;
using DataAccess.Abstract;
using System.Collections.Generic;

namespace _Business.Concrete
{
    public class LogsManager : ILogsService
    {
        private ILogsDal _logsDal;
        //private PaymentsManager paymnah;
        public LogsManager(ILogsDal logsDal)
        {
            _logsDal = logsDal;
        }
        public void Add(Logs logs)
        {
            _logsDal.Add(logs);
        }

        public void Delete(Logs logs)
        {
            _logsDal.Delete(logs);
        }

        public List<Logs> GetAll()
        {
            return _logsDal.GetList();
        }

        public List<Logs> GetById(int logsid)
        {
            return _logsDal.GetList(l => l.LogId == logsid);
        }



        public Logs GetLogsById(int id)
        {
            var logs = _logsDal.Get(l => l.LogId == id);
            return logs;
        }

        public void Update(Logs logs)
        {
            _logsDal.Update(logs);

        }
    }
}
