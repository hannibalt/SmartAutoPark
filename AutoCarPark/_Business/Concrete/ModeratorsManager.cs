using _AutoParkData.Models;
using _Business.Abstract;
using DataAccess.Abstract;
using System.Collections.Generic;

namespace _Business.Concrete
{
    public class ModeratorsManager : IModeratorsService
    {
        private IModeratorsDal _moderatorsDal;
        public ModeratorsManager(IModeratorsDal moderatorsDal)
        {
            _moderatorsDal = moderatorsDal;
        }
        public void Add(Moderators moderators)
        {
            _moderatorsDal.Add(moderators);
        }

        public void Delete(Moderators moderators)
        {
            _moderatorsDal.Delete(moderators);
        }

        public List<Moderators> GetAll()
        {
            return _moderatorsDal.GetList();
        }

        public List<Moderators> GetById(int moderatorId)
        {
            return _moderatorsDal.GetList(l => l.ModId == moderatorId);
        }

        public Moderators GetModerators(int id)
        {
            var Moderators = _moderatorsDal.Get(c => c.ModId == id);
            return Moderators;
        }

        public void Update(Moderators moderators)
        {
            _moderatorsDal.Update(moderators);
        }

        public Moderators GetUser(string username, string pass)
        {
            var Moderators = _moderatorsDal.Get(c => (c.ModUsername == username) && (c.ModPassword == pass));
            return Moderators;
        }
    }
}
