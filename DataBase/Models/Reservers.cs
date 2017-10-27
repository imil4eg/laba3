using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.Models
{
    class Reservers
    {
        //Номер заказа
        public int NumberOfReserve { get; set; }

        //Номер человека
        public int PersonID { get; set; }

        //Номер стола
        public int BoardID { get; set; }

        //Время
        public DateTime Time { get; set; }
    }
}
