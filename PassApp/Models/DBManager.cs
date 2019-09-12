using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BLL;


namespace PassApp.Models
{
    public class DBManager
    {

        BLL.Business bll = new BLL.Business();
        
        /// <summary>
        /// Adds a new password record.
        /// </summary>
        /// <param name="p">The password object.</param>
        public void Add(PassWord p)
        {
            bll.Add(p);
           
        }

        public List<PassWord> GetAll()
        {
            return bll.GetAll();
            
        }

        public void Delete(int id)
        {

            bll.Delete(id);
                       
        }

        public PassWord Details(int id)
        {
            return bll.Details(id);
          
        }
        public void Update(PassWord p)
        {

            bll.Update(p);
           
          
        }









    }
}