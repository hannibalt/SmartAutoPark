using _AutoParkData.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace _Business.Abstract
{

    public interface ILogsService
    {
        List<Logs> GetAll();
        List<Logs> GetById(int logsid);

        Logs GetLogsById(int id);
        void Add(Logs logs);
        void Update(Logs logs);
        void Delete(Logs logs);
    }
}
