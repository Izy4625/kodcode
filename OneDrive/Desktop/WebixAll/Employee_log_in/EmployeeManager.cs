using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee_log_in
{
    internal class EmployeeManager
    {
        private static string _loginSQL = "\r\ndeclare @code int, @answer VARCHAR(250), @fullname VARCHAR(20)='';\r\nIF exists (SELECT * FROM Employees where IdNumber = @id)\r\nbegin\r\nSELECT @code = (SELECT code FROM Employees where IdNumber = @id)\r\nend\r\n\r\nelse\r\nbegin\r\ninsert into Employees  (FullName, IdNumber) values (@FullName, @id);\r\nselect @code = @@IDENTITY;\r\nend\r\n\r\n\r\nIF exists (select * from Passwords WHERE EmployeeCode = @code)\r\nbegin\r\nif exists (select pass From Passwords\r\nWHERE EmployeeCode = @code AND pass = @password AND HAS_ACCESS = 1)\r\nbegin\r\nif exists (select pass From Passwords\r\nWHERE EmployeeCode = @code AND pass = @password AND HAS_ACCESS = 1 AND ExpiryDate>=GETDATE())\r\nbegin\r\nIF exists (SELECT * FROM Attendances\r\nWHERE EmployeeCode = @code AND ExitTime is null)\r\nbegin\r\nUPDATE Attendances set ExitTime = GETDATE()\r\nWHERE EmployeeCode = @code AND ExitTime is null;\r\nselect @answer = 'exit time: ' + convert (nvarchar, GETDATE(),121);\r\nend\r\nelse\r\nbegin\r\ninsert into Attendances VALUES (@code, GETDATE(), GETDATE(), null);\r\nselect @answer = 'entry time: ' + convert (nvarchar, GETDATE(),121);\r\nend\r\n-- כניסה \\ יציאה\r\nend\r\nelse\r\nbegin\r\nselect @answer = 'you need to update your password';\r\n-- עדכון סיסמא\r\nend\r\nend\r\nelse\r\nbegin\r\nselect @answer = 'wrong password';\r\n-- סיסמה שגויה\r\nend\r\nend\r\n\r\nelse\r\nbegin\r\ninsert into Passwords values (@code, @password,DATEADD(day, 180,  GETDATE()), 1)\r\nselect @answer = 'You created an acount with new password'\r\nend\r\n\r\nselect @answer";
        private static string _changePasswordSQL = "declare @answer varchar (150);\r\nIf (@newPass = @ConfPass)\r\n\tbegin\r\n\t\tIf exists(select * from Employees \r\n\t\twhere idnumber = @id)\r\n\t\t\t begin\r\n\t\t\t\tdeclare @code int = (select Code from Employees \r\n\t\t\t\twhere idnumber = @id);\r\n\t\t\t\t\tif exists(select * from Employees,Passwords where passwords.Employeecode = Employees.code\r\n\t\t\t\t\t\tAnd Employees.Idnumber = @id and Passwords.pass = @oldpassword and has_access = 1 )\r\n\t\t\t\t\t\tbegin\r\n\t\t\t\t\t\t\tinsert into Passwords values(@code,@newPass,DATEADD(day, 180,  GETDATE()), 1);\r\n\t\t\t\t\t\t\tupdate passwords\r\n\t\t\t\t\t\t\tset Has_access = 0\r\n\t\t\t\t\t\t\twhere EmployeeCode = @code and Pass = @oldpassword;\r\n\t\t\t\t\t\t\tselect @answer = 'You have Succesfully Updated Your password';\r\n\t\t\t\t\t\tend\r\n\t\t\t\t\telse\r\n\t\t\t\t\t\tbegin\r\n\t\t\t\t\t\t\tselect @answer = 'Old Password incorrect';\r\n\t\t\t\t\t\tend\r\n\t\t\t end\r\n\t\telse\r\n\t\t\tbegin\r\n\t\t\t\tselect @answer = 'Incoerrect Tiudat Zahut'\r\n\t\t\tend\r\n\tend\r\nelse\r\n\tbegin\r\n\t\tselect @answer = 'Confirm pass not Compadible'\r\n\tend\r\n\r\nselect @answer";
        private static string _listTimehours = "\r\ndeclare @_eT Datetime = (select entrytime from Employees left join Attendances\r\non Employees.code = Attendances.Employeecode where Attendances.Code = 2)\r\nselect @_et\r\ndeclare @_exT Datetime = (select exittime from Employees left join Attendances\r\non Employees.code = Attendances.Employeecode where Attendances.Code = 2)\r\n\r\nselect @_et, @_ext";

        public void doX()
        {
        }
        public static string Login(string id, string password)
        {
            // 1. Use the _loginSQL
            // 2. Execute SQL against DB
            string[] parameters = { "@id", "@password" };
            string[] values = { id, password };
            var res = DataBaseConnect.runSQL(_loginSQL, parameters, values);
            // 3. Return response
            return res;
        }
        public static string ChangePassword(string id, string oldPass, string newPass, string confirmPass)
        {
            string[] parameters = { "@id", "@oldpassword", "@NewPass","@Confpass"};
            string[] values = { id, oldPass,newPass,confirmPass };
            var res = DataBaseConnect.runSQL(_changePasswordSQL, parameters, values);
            return res;
        }
       

        public static string PullData()
        {
            string Query = _listTimehours;
            string res = DataBaseConnect.Runsqltable(Query);
            return res;
            
        }
    }
}
    

