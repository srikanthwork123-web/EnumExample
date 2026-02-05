using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumExample
{
    internal class Program
    {
        /*syntax of enum
       ========================
        enum <enum_name> {
            enumeration list   //(enumeration list is a comma-separated list)
        };
        */
        //enum having string constantmessages.
        enum Days { Sun, Mon, tue, Wed, thu, Fri, Sat };//enum contains constant messages or values
        //In enum the first value starts with 0.
        enum enum_collegename { Jntu,cbit,vizanan,narayana,kits,srm,vit};
     //   enum enum_booleanvalues {true,false};//we can't write keywords inside enum.if you write it will throw compiletime error.
        enum enum_Address { Hyderabad,chenni,banglore,kochin};
        //To access enum data  synatx is:enumname.value
        //example for accessing is:enum_Address.Hyderabad
        static void Main(string[] args)
        {
            string collegename = "Jntu";//this is called Hardcoding the value(Don't write this way in realtime job)
            string address = "Hyderbad";
            //Convert.ToInt32() is used to convert the type to integer type
            //======To read the enum constans in another place we have to fallow below process======
            //=====Read the days from enum===============================================
            int WeekdayStart = Convert.ToInt32(Days.Mon);//it will display integer value of enum
            int WeekdayEnd = Convert.ToInt32(Days.Fri);
            Console.WriteLine("Monday " + WeekdayStart);
            Console.WriteLine("Friday " + WeekdayEnd);
            string Day1 = Convert.ToString(Days.Mon);
            Console.WriteLine("Monday " + Day1);//it will display string value of enum
            string Day2 = Convert.ToString(Days.tue);
            Console.WriteLine("Tusday " + Day2);//it will display string value of enum
            string Day3 = Convert.ToString(Days.Wed);
            Console.WriteLine("wednesday " + Day3);//it will display string value of enum
            string Day4 = Convert.ToString(Days.thu);
            Console.WriteLine("Thursday " + Day4);//it will display string value of enum
            string Day5 = Convert.ToString(Days.Fri);
            Console.WriteLine("Friday " + Day5);//it will display string value of enum
            string Day6 = Convert.ToString(Days.Sat);
            Console.WriteLine("Saturday " + Day6);//it will display string value of enum
            string Day7 = Convert.ToString(Days.Sun);
            Console.WriteLine("sunday " + Day7);//it will display string value of enum

            //==========Getting the college names from enum ======
            string JntuCollegeName = Convert.ToString(enum_collegename.Jntu);
            Console.WriteLine(JntuCollegeName);//Here i am printing the colleage name.
            string CBITCollegeName = Convert.ToString(enum_collegename.cbit);
            Console.WriteLine(CBITCollegeName);
            string vitCollegeName = Convert.ToString(enum_collegename.vit);
            Console.WriteLine(vitCollegeName);
            string vizananCollegeName = Convert.ToString(enum_collegename.vizanan);
            Console.WriteLine(vizananCollegeName);
       
            //==========Getting the Address names from enum ======
            string hyderabad_Addres = Convert.ToString(enum_Address.Hyderabad);//Realtime read the data from enum.
            Console.WriteLine(hyderabad_Addres);
            string banglore_Addres = Convert.ToString(enum_Address.banglore);
            Console.WriteLine(banglore_Addres);
            string kochin_Addres = Convert.ToString(enum_Address.kochin);
            Console.WriteLine(kochin_Addres);
            string narayana_Addres = Convert.ToString(enum_collegename.narayana);
            Console.WriteLine(narayana_Addres);
            Console.ReadKey();
        }
    }
}
/*  output:
 * ===============
 Monday 1
Friday 5
Monday Mon
Tusday tue
wednesday Wed
Thursday thu
Friday Fri
Saturday Sat
sunday Sun
Jntu
cbit
vit
vizanan
Hyderabad
banglore
kochin
narayana
========================================