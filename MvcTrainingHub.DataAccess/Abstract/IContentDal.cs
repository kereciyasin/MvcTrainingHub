using MvcTrainingHub.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcTrainingHub.DataAccess.Abstract
{
    public interface IContentDal : IRepository<Content>
    {
        // Content specific operations can be added here if needed
    }

}
