﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using IDatabase;

namespace DALEF
{
    public class NearbyServicesCategoryDALEF : INearServiceCategory
    {
        ESocietyProjectEntities1 es = new ESocietyProjectEntities1();
        public NearbyServicesCategory GetByServiceCategoryId(int id)
        {
            try
            {
                NearbyServicesCategory n = new NearbyServicesCategory();

                var r = (from t in es.Nearby_Services_Category
                         where t.Nearby_Services_Category_ID == id
                         select t).SingleOrDefault();

                if (r != null)
                {
                    n.Nearby_Services_Category_ID = r.Nearby_Services_Category_ID;
                    n.Nearby_Services_Category = r.Nearby_Services_Category1;
                }
                else
                {
                    throw new Exception("Invalid ID");
                }
                return n;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public string PutNearByServiceCategory(int id, NearbyServicesCategory n)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<NearbyServicesCategory> GetServiceCategory()
        {
            try
            {
                var res = es.Nearby_Services_Category.ToList();

                List<NearbyServicesCategory> nsc = new List<NearbyServicesCategory>();

                foreach (var r in res)
                {
                    NearbyServicesCategory n = new NearbyServicesCategory();

                    n.Nearby_Services_Category_ID = r.Nearby_Services_Category_ID;
                    n.Nearby_Services_Category = r.Nearby_Services_Category1;

                    nsc.Add(n);
                }
                return nsc;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool PostNearByServiceCategory(NearbyServicesCategory s)
        {
            try
            {
                Nearby_Services_Category nsc = new Nearby_Services_Category();

                nsc.Nearby_Services_Category_ID = s.Nearby_Services_Category_ID;
                nsc.Nearby_Services_Category1 = s.Nearby_Services_Category;
                es.Nearby_Services_Category.Add(nsc);
                var res = es.SaveChanges();

                if (res>0)
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


        public string PutNearByServiceCategory(NearbyServicesCategory s, int id)
        {
            try
            {
                var nsc = (from t in es.Nearby_Services_Category
                           where t.Nearby_Services_Category_ID == id
                           select t).SingleOrDefault();

                if (nsc == null)
                {
                    return "Invalid ID";

                }
                else
                {
                    nsc.Nearby_Services_Category_ID = s.Nearby_Services_Category_ID;
                    nsc.Nearby_Services_Category1 = s.Nearby_Services_Category;

                    var res = es.SaveChanges();
                    if (res > 0)
                        return "Data Updated Successfully";
                    else
                        return "Error in updation";
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
