using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook.App
{
    /// <summary>
    /// 
    /// </summary>
    internal class Addres
    {
        public string Type { get; set; }
        public string AddresBody { get; set; }

        public Addres()
        {
        }
        /// <summary>
        /// Конструктор с двумя параметрами
        /// </summary>
        /// <param name="type"></param>
        /// <param name="addresBody"></param>
        public Addres(string type, string addresBody)
        {
            Type = type;
            AddresBody = addresBody;
        }

    }
}
