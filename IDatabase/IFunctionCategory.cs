using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;

namespace IDatabase
{
    public interface IFunctionCategory
    {
        IEnumerable<FunctionCategory> GetFunctionCategory();
       
        FunctionCategory GetFunctionCategory(int id);
        bool PostFunctionCategory( FunctionCategory d);

        string PutFunctionCategory(FunctionCategory d,int id);
    }
}
