using GitFresh.Clean.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitFresh.Clean.Application
{
    public interface IDietRepository
    {
        List<Diet> GetAllDiet();
    }
}
