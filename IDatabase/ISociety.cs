using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;



namespace IDataBase
{
    public interface ISociety
    {
        // TO GET ALL THE SOCIETY DETAILS
        IEnumerable<Society> GetAllSociety();

        // TO ADD A NEW SOCIETY INTO DB
       

        // TO RETRIEVE PARTICULAR SOCIETY INFO
        Society GetSocietyByID(string sid);

        bool PostSociety(Society s);

        // TO UPDATE SOCIETY DETAILS
        string PutSociety(Society s, string sid);
    }
}