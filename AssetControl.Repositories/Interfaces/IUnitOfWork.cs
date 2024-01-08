using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetControl.Repositories.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        void Save();
    }
}
