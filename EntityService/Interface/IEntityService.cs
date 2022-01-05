using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityService.Interface
{
    public interface IEntityService<T>
    {
        bool AddNewData(T obj);
        bool UpdateData(T obj);
        T GetData();
        void ClearData();
    }
}