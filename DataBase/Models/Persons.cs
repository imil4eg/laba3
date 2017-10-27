using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.Models
{
    class Persons
    {
        //id человека
        public int Id { get; set; }

        //Имя 
        public string FirstName { get; set; }

        //Фамилия
        public string LastName { get; set; }

        //Номер телефона
        public string Phone { get; set; }
    }
}
