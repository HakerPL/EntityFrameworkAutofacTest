using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.Data.Repositories
{
    public interface IPatternRepository
    {
        bool Save(Entities.Number number);
        bool Remove(Entities.Number number);

        Entities.Number Get(int id);
    }
}
