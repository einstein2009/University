using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nick_Ackors_University
{
    class Department
    {
        public string[] DeptName { get; set; }
        public int[] UStaff { get; set; }
        public string DeptHead { get; set; }

        public Department()
        {

            Staff[] staff = new Staff[10];
            for (int i = 0; i < 10; i++)
            {
                staff = new Staff[i];
                staff[0] = new Dean dean();
                staff[1] = Professor;
                staff[2] = Administrator;
                staff[3] = Researcher;
            }

        }





    }
}
