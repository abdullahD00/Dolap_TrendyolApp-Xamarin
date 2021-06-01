using System;
using System.Collections.Generic;
using System.Text;
using SQLite;



namespace Dolap.Users
{
       public  class USER 
    {

        [PrimaryKey,AutoIncrement]
        public int USERID { get; set; }
        public string NAME { get; set; }
        public string PASSWORD { get; set; }
        
       
       



    }
}
