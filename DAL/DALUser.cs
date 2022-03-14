using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace AppManager.DAL
{
    public class DALUser
    {
        SQLHelper cnconnec = new SQLHelper();
        
        // Lay Du Lieu theo bang


        public DataTable GetDataTable(string condition)
        {
            return cnconnec.Getdatatable("select*from User" +condition);
        }
        public void Editdata(string condition)
        {

        }


         
    }
}
