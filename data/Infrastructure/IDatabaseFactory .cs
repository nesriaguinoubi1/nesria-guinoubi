
using PI.DOMAIN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recruit.PI.Data.Infrastructure
{
    public interface IDatabaseFactory : IDisposable
    {
     PIContext DataContext { get; }
    }

}
