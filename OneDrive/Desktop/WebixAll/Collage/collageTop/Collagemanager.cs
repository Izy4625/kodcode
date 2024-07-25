using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace collageTop
{
    internal class Collagemanager
    {
        public static string SendMachzor(string Maname, string CoName, string Starttime, float Price)
        {
            string sql = " if  exists(select name from Courses where name = @cname)\r\n\tbegin\r\n\t\tif not exists(select name from Machzor where name = @Mname)\r\n\t\t\tbegin\r\n\t\t\t\tinsert into Machzor values(@Mname,(select Courseid from Courses \r\n\t\t\t\twhere name = @cname),@StartTme,@price)\r\n\t\t\tend\r\nend ";
            string[] parameters = { "@Mname", "@cname", "@StartTme", "@price" };
            object[] value = { Maname, CoName, Starttime, Price };
            DataBase.RunSQLSCollageInsert(sql, parameters, value);
            return "";
        }
        public static string sendSchedule(string Mname, string day, string hour)
        {
            string sql = "if exists(select name from Machzor where name = @M7name)\r\n\tbegin\r\n\t\tinsert into ScheduleDays values(@day,@hour,(select MachzorId from\r\n\t\tmachzor where name = @m7name))\r\n\tend\r\nselect * from ScheduleDays";
            string[] parameters = { "@M7name", "@day", "@hour" };
            string[] value = { Mname, day, hour };
            DataBase.RunSQLSCollageInsert(sql, parameters, value);
            return "";
        }
        public static string sendStudent(string Sname, string Mname)
        {
            string sql = "insert into Students Values(@s1name ,(select MachzorId from machzor\r\nwhere name =@M1name)) ";
            string[] parameters = { "@s1name", "@M1name" };
            string[] value = { Sname, Mname };
            DataBase.RunSQLSCollageInsert(sql, parameters, value);
            return "";
        }
        public static string Updatepayment(string Sname, string Mname)
        {
            string sql = "insert into payments values(\r\n(select studentId from students\r\nwhere name =@s2name),(select Machzor_Id from students where name = @s2name)\r\n,(select cost\r\nfrom machzor where name =@M2name))";
            string[] parameters = { "@s2name", "@M2name" };
            string[] value = { Sname, Mname };
            DataBase.RunSQLSCollageInsert(sql, parameters, value);
            return "";
        }
        public static string GetBalance(string Sname)
        {
            string sql = "declare @answer decimal =\r\n(select payments.balance from payments left join students on \r\npayments.student = Students.studentId where Students.name = @S3name)\r\nselect @answer";
            string[] parameters = { "@S3name" };
            string[] value = { Sname };
            var res = DataBase.runSQLSingleresult(sql, parameters, value);
            return res;
        }
        public static string PayBalnce(string Sname, float amount)
        {
            string sql = "UPDATE payments \r\nSET balance = Payments.balance - @amount\r\nWHERE Student = (Select studentId from Students where name = @s5name)";
            string[] parameters = { "@s5name", "@amount" };
            object[] value = { Sname, amount };
            DataBase.RunSQLSCollageInsert(sql, parameters, value);
            return "";
        }
        public static string Getmachzorex(string Mname)
        {
            string sql = "select  Sum(subjects.price) * sum(subjects.Hours1) as Total_am from subjects join courses \r\non subjects.Course_Id = Courses.CourseId join Machzor on Machzor.Course_Id = courses.CourseId where\r\nMachzor.name = @M9name";
            string[] parameters = { "@M9name" };
            string[] value = { Mname };
            var res = DataBase.runSQLSingleresult(sql, parameters, value);
            return res;

        }
    }
}