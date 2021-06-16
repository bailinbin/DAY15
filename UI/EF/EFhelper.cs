using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UI.EF
{
    
    public class EFhelper<T> where T:class,new()
    {
        Model1 db = new Model1();
        public List<T> Getlist()
        {
            return db.Set<T>().ToList();
        }
    }
}