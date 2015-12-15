using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter9Lab
{
    class Conference : IComparable
    {
        private string groupName;
        private string date;
        private int attendence;

        public string GroupName
        {
            get
            {
                return groupName;
            }
            set
            {
                groupName = value;
            }
        }

        public string Date
        {
            get
            {
                return date;
            }
            set
            {
                date = value;
            }
        }

        public int Attendence
        {
            get
            {
                return attendence;
            }
            set
            {
                attendence = value;
            }
        }

        public Conference(string n, string d, int a)
        {
            GroupName = n;
            Date = d;
            Attendence = a;
        }

        int IComparable.CompareTo(Object obj)
        {
            int returnVal;
            Conference temp = (Conference)obj;
            if (this.Attendence > temp.Attendence)
            {
                returnVal = 1;
            }
            else if (this.Attendence < temp.Attendence)
            {
                returnVal = -1;
            }
            else
            {
                returnVal = 0;
            }
            return returnVal;
        }
    }
}
