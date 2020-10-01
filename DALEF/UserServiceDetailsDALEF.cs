using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using IDatabase;

namespace DALEF
{
    public class UserServiceDetailsDALEF : IUserService
    {
        ESocietyProjectEntities1 es = new ESocietyProjectEntities1();

        public UserServiceDetails GetByIdUserService(int id)
        {
            try
            {
                UserServiceDetails a = new UserServiceDetails();
                var r = es.User_Service_Details.Where(x => x.User_Id == id).SingleOrDefault();
                if (r != null)
                {
                    a.User_Id = r.User_Id;
                    a.Service_Category_ID = Convert.ToInt32(r.Service_Category_ID);
                    a.User_Name = r.User_Name;
                    a.User_Address = r.User_Address;
                    a.User_Contact = r.User_Contact;
                    a.User_Availability = r.User_Availavility;
                    a.User_Rate = r.User_Rate;
                }
                else
                {
                    throw new Exception("invalid Id");
                }
                return a;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<UserServiceDetails> GetUserService()
        {
            try
            {
                var res = es.User_Service_Details.ToList();
                List<UserServiceDetails> ad = new List<UserServiceDetails>();
                foreach (var r in res)
                {
                    UserServiceDetails a = new UserServiceDetails();
                    a.User_Id = r.User_Id;
                    a.Service_Category_ID = r.Service_Category.Service_Category_ID;
                    a.User_Name = r.User_Name;
                    a.User_Address = r.User_Address;
                    a.User_Contact = r.User_Contact;
                    a.User_Availability = r.User_Availavility;
                    a.User_Rate = r.User_Rate;

                    ad.Add(a);
                }
                return ad;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool PostUserService(UserServiceDetails u)
        {
            try
            {
                User_Service_Details a = new User_Service_Details();
               
                a.Service_Category_ID = u.Service_Category_ID;
                a.User_Name = u.User_Name;
                a.User_Address = u.User_Address;
                a.User_Contact = u.User_Contact;
                a.User_Availavility = u.User_Availability;
                a.User_Rate = u.User_Rate;
                es.User_Service_Details.Add(a);
                var res = es.SaveChanges();
                if (res > 0)
                {
                    return true;
                }
                return false;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public string PutUserService(int id, UserServiceDetails u)
        {
            try
            {

                var a = (from ad in es.User_Service_Details
                         where ad.User_Id == id
                         select ad).SingleOrDefault();
                if (a == null)
                {
                    return "Invalid Id";
                }
                else
                {
                    a.User_Id = u.User_Id;
                    a.Service_Category_ID = u.Service_Category_ID;
                    a.User_Name = u.User_Name;
                    a.User_Address = u.User_Address;
                    a.User_Contact = u.User_Contact;
                    a.User_Availavility = u.User_Availability;
                    a.User_Rate = u.User_Rate;


                    var res = es.SaveChanges();
                    if (res > 0)
                    {
                        return "Data Uploaded";
                    }
                }
                return "Error In data Updating";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
      
    }
}
