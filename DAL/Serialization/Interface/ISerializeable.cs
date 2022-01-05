using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Serialization.Interface
{
    public interface ISerializeable<T>
    {
        bool Serialize(T obj);

        T Deserialize();
    }
}
