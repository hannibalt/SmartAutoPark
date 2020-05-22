using _AutoParkData.Models;
using System.Collections.Generic;

namespace _Business.Abstract
{
    public interface IModeratorsService
    {
        List<Moderators> GetAll();
        List<Moderators> GetById(int moderatorId);

        Moderators GetModerators(int id);
        void Add(Moderators moderators);
        void Update(Moderators moderators);
        void Delete(Moderators moderators);
        Moderators GetUser(string username, string pass);
    }
}
