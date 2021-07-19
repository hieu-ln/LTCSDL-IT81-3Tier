using System;
using System.Collections.Generic;
using System.Text;
using LTCSDL.DAL.DTO;
using LTCSDL.DAL;

namespace LTCSDL.BLL
{
    public class CategoriesBLL
    {
        CategoriesDAL dal;
        public CategoriesBLL()
        {
            dal = new CategoriesDAL();
        }

        public int insert(string name, string description, out string msg)
        {
            int res = dal.insert(name, description, out msg);
            return res;
        }

        public CategoriesDTO getCategoryById(int id, out string msg)
        {
            CategoriesDTO res = new CategoriesDTO();
            res = dal.getCategoryById(id, out msg);
            return res;
        }
    }
}
