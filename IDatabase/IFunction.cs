using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
namespace IDatabase
{
    public interface IFunction
    {
            IEnumerable<FunctionDetails> GetFunctionDetails();
            FunctionDetails GetByIdFunctionDetails(int id);
            bool PostFunctionDetails(FunctionDetails f);
            string PutFunctionDetails(FunctionDetails f, int id);
        }
    }

