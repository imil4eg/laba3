using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase
{
    public class Boards
    {
        //ID стола
        public int id { get; set; }

        //Количество мест
        public int NumberOfPlaces { get; set; }

        //Свободен ли
        public string Reserved { get; set; }
    }
}
