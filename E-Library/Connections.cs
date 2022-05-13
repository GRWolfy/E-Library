using System.Data.SqlClient;

namespace E_Library
{
    public class Connection
    {
        public static SqlConnection con;
        private static string dbconnect = "Data Source=DESKTOP-VM9TO32;Initial Catalog=E-Library;Integrated Security=True"; //connection string 

        public static void DB()
        {
            try
            {
                con = new SqlConnection(dbconnect);
                con.Open();
            }
            catch (Exception e)
            {
                con.Close();
                MessageBox.Show(e.Message);
            }
        }
    }
}


/*  

(*) - primary key, increment 1
   
                Table name: users
 [COLUMN]           [TYPE AND SIZE]         [Allow Null]
idnumber           bigint                       No
role               varchar(50)                  No
firstname          varchar(50)                  No
lastname           varchar(50)                  No
gender             varchar(50)                  No
yearlevel          varchar(50)                  No
course             varchar(50)                  No
email              varchar(50)                  No
address            varchar(50)                  No
contactnumber      bigint                       No
password           varchar(50)                  No
picture            image                        Yes

                Table name: books
 [COLUMN]           [TYPE AND SIZE]         [Allow Null]
bookid(*)          int                          No
bookname           varchar(50)                  No
bookauthor         varchar(50)                  No
booklocation       varchar(50)                  No
availability       varchar(50)                  No
picture            image                        Yes

                Table name: cart
 [COLUMN]           [TYPE AND SIZE]         [Allow Null]
cartid(*)          int                          No
bookid             varchar(50)                  No
idnumber           varchar(50)                  No


                Table name: logs
 [COLUMN]           [TYPE AND SIZE]         [Allow Null]
logid(*)           int                          No
idnumber           varchar(50)                  No
bookid             varchar(50)                  No
borrowdatetime     varchar(50)                  Yes
returndatetime     varchar(50)                  Yes

 */