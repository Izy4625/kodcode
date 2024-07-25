using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Guest
{
    internal class GuestManager

    {
        private static string _runSqlTransferDataGuest = "select pname from Guests";

        private static string _runsqlcategory = "select Cname from Categories";

        private static string _insertGuesttsql = "if  not exists (select Pname from Guests \r\nwhere @Guest = Pname)\r\nbegin\r\n\tinsert into Guests values(@Guest)\r\nend";

        private static string _deletesql = "\r\ndeclare @catId int =\r\n(select Dishorders.Category_id from Dishorders left join\r\nCategories on Categoryid = Category_id where @category1 = Categories.Cname\r\ngroup by Dishorders.Category_id)\r\n\r\ndelete from Dishorders where Category_id = @catId\r\nDelete from Categories  where @category1 = Cname";
        private static string _searchfilter = "select Cname from Categories\r\nwhere Cname like '%' + @category2 + '%'";

        private static string _Dishorders = "select count(Dishorders.fname),Dishorders.Fname\r\nas ammount from Dishorders join Categories \r\non Dishorders.Category_id = Categories.CategoryId\r\nwhere Categories.Cname = 'Fish'\r\n group by Dishorders.Fname";

        private static string _GetDishordsTable = "select Fname,count(fname) as ammount from Dishorders \r\njoin Categories on Dishorders.Category_id = Categories.CategoryId\r\njoin Guests On Guests.PersonId = Categories.CategoryId\r\nwhere @Category_name2 = Categories.Cname And @user_name != Guests.Pname\r\nGroup by Dishorders.Fname";
        public void Dox()
        {

        }

        public static List<string> GetGuests()
        {
            SqlDataReader reader = DBConnection.RunSQLSallresult(_runSqlTransferDataGuest);

            List<string> categories = new List<string>();

            for (int i = 0; reader.Read() != false; i++)
            {

                categories.Add(reader.GetString(0));
            }
            return categories;

        }
        public static List<string> GetCategories()
        {
            SqlDataReader reader = DBConnection.RunSQLSallresult(_runsqlcategory);

            List<string> categories = new List<string>();

            for (int i = 0; reader.Read() != false; i++)
            {

                categories.Add(reader.GetString(0));
            }
            return categories;

        }
        public static string SendGuest(string category)
        {
            string[] parameters = { "@Guest" };
            string[] value = { category };
            DBConnection.RunSQLSHostInsert(_insertGuesttsql, parameters, value);
            return "";
        }
        //public static string DeleteCategory(string category)
        //{
        //    string parameter = "@category1";
        //    string value = category;
        //    DBConnect.RunSQLSHostInsert(_deletesql, parameter, value);
        //    return "";
        //}
        //public static List<object> SearchFilter(string category)
        //{
        //    string[] parameter = { "@category2" };
        //    string[] value = { category };
        //    SqlDataReader reader = DBConnect.RunSQLSallresult(_searchfilter, parameter, value);

        //    List<object> categories = new List<object>();

        //    for (int i = 0; reader.Read() != false; i++)
        //    {

        //        categories.Add(reader.GetString(0));
        //    }
        //    return categories;

        //}
        public static List<object> DishOrders(string category)
        {

            string[] parameter = { "@category3" };
            string[] value = { category };
            SqlDataReader reader = DBConnection.RunSQLSallresult(_searchfilter, parameter, value);

            List<object> categories = new List<object>();

            for (int i = 0; reader.Read() != false; i++)
            {

                categories.Add(reader.GetString(0));
            }
            return categories;

        }



        public static DataTable SqlTableResult()
        {

            DataTable Dish = DBConnection.Runsqltable(_Dishorders);
            return Dish;
        }
        public static DataTable SqlForwardTableResult(string category, string Name)
        {
            string[] parameters = { "@Category_name2", "@user_name" };
            string[] value = { category, Name };
            DataTable Dish = DBConnection.Runsqltable(_GetDishordsTable, parameters, value);
            return Dish;
        }
    }
}
  