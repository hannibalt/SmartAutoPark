using _AutoParkData.Models;
using System;
using System.Collections.Generic;
using System.Text;

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
    }
}
