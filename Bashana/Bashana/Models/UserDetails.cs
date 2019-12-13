using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace NguniLearning2.Models
{
    public class UserDetails
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

    }
}

