using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COP.Model
{
    public class User
    {
        public string userName { set; get; }
        public string userSurname { set; get; }
        public int age { set; get; }
        public override string ToString()
        {
            return "Фамилия: " + userSurname + "\n"
                + "Имя: " + userName + "\n"
                + "Возраст: " + age;
        }
    }
}
