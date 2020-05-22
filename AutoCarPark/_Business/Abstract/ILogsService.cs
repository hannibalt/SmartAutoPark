using _AutoParkData.Models;
using System.Collections.Generic;

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
