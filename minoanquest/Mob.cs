using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minoanquest
{
    class Mob
    {
        int birthday;
        public Mob()
        {
            birthday = TimeControl.getSteps();
            Console.WriteLine("Mob Created. Birthday is "+TimeControl.getSteps().ToString());
        }

        public int getAge()
        {
            int age = 0;
            age = TimeControl.getSteps() - birthday;
            return age;
        }
    }
}
