using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab.core.Repositories
{
    public interface IUnitOfWork: IDisposable
    {
        ICourseRepository Courses { get; }
        int Complete();
       
    }
}
