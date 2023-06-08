using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WFGridViewLinqPrj;
// Example for LINQ (ER)
// Language Intergrated Qurey

namespace WFGridViewLinqPrj
{
    class CLSPROPOER
    {
        public int _rno;
        public string _sname;
        public double _m1 = 0;
        public double _m2 = 0;

        public int Rno //property name
        {
            get
            {
                return _rno; // return instance private variable
            }
            set

            {
                _rno = value; //value is reserved word 
            }
        }
        public string SName //property name
        {

            get
            {
                return _sname;
            }
            set
            {
                _sname = value;
            }
        }
        public double M1
            {
            get 
            {
                return _m1;
            }
            set
            {
                _m1 = value;
            }
            }
        public double M2
        {
            get
            {
                return _m2;
            }
            set
            {
                _m2 = value;
            }
        }
        public double Total

        {
            get
            {
                return _m1 + _m2;

            }
        }
        public double AVG
        {
            get
            {
                return Total / 2;
            }
        }
        public string Results
        {
            get
            {
                return _m1 > 34.4 && _m2 > 34.4 ? "Pass" : "Fail";
            }
        }
    }

    class CLSPROPAA
    {
        public static void Main ()
        {
            CLSPROPOER er = new CLSPROPOER();
            er.Rno = 1001;
            er.SName = "Naveen G";
            er.M1 = 33.3;
            er.M2 = 89.5;

            Console.WriteLine(er.Rno);
            Console.WriteLine(er.SName);
            Console.WriteLine(er.M1);
            Console.WriteLine(er.M2);
            Console.WriteLine(er.Total);
            Console.WriteLine(er.AVG);
            Console.WriteLine(er.Results);
            
        }
    }
}


/*
 output 1:
 1001
Gobinath G
90
56
146
73
Pass
Press any key to continue . . .

    output 2:
1001
Naveen G
33.3
89.5
122.8
61.4
Fail
Press any key to continue . . .



 */
