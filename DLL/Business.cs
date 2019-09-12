using PassApp.Models;
using System.Collections.Generic;
using System.Linq;
using DAL;

namespace BLL
{
    public class Business
    {
      
        public void Add(PassWord p)
        {
            p.PassWordID = Database.LastId++;

            Database.passWordList.Add(p);

        }

        public List<PassWord> GetAll()
        {
            return Database.passWordList;
        }

        public void Delete(int id)
        {

            Database.passWordList.Remove(Details(id));

        }

        public PassWord Details(int id)
        {
            return Database.passWordList.Where(x => x.PassWordID == id).Single();
        }
        public void Update(PassWord p)
        {

            var tempRec = Database.passWordList.Where(x => x.PassWordID == p.PassWordID).Single();

            tempRec.Note = p.Note;
            tempRec.PassWordKey = p.PassWordKey;
            tempRec.PassWordValue = p.PassWordValue;

        }
    }
}
