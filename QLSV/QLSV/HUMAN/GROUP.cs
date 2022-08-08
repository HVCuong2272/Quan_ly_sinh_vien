using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QLSV.HUMAN
{
    class GROUP
    {
        MY_DB mydb = new MY_DB();

        // Function to insert a new group
        public bool insertGroup(int id, string gname, int userid)
        {
            SqlCommand command = new SqlCommand("INSERT INTO mygroups (id, name, userid) VALUES (@id, @gn, @uid)", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@gn", SqlDbType.VarChar).Value = gname;
            command.Parameters.Add("@uid", SqlDbType.Int).Value = userid;

            mydb.openConnection();

            if ((command.ExecuteNonQuery() == 1))
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }
        }

        // update khi thay doi ten
        public bool updateGroup(int gid, string gname)
        {
            SqlCommand command = new SqlCommand("UPDATE mygroups SET name = @name WHERE id = @id", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = gid;
            command.Parameters.Add("@name", SqlDbType.VarChar).Value = gname;

            mydb.openConnection();

            if ((command.ExecuteNonQuery() == 1))
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }
        }

        //Xoa
        public bool deleteGroup(int groupid)
        {
            SqlCommand command = new SqlCommand("DELETE FROM mygroups WHERE id = @id", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = groupid;
            mydb.openConnection();
            if ((command.ExecuteNonQuery() == 1))
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }
        }

        // Chức năng này quan trọng, xác định group cho userid nào
        public DataTable getGroups(int userid)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM mygroups WHERE userid = @id", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = userid;
            command.Connection = mydb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        // Phan nay kiem tra xem grp co ton tai chua,copy tu phan truoc, thay doi de ktra ID trong muc Add Contact
        public bool groupExist(string name, string operation, int userid, int groupid = 0)
        {
            string query = "";

            SqlCommand command = new SqlCommand(query, mydb.getConnection);

            if (operation == "add")
            {
                query = "SELECT * FROM mygroups WHERE name = @name AND userid = @uid";

                command.Parameters.Add("@name", SqlDbType.VarChar).Value = name;
                command.Parameters.Add("@uid", SqlDbType.Int).Value = userid;
            }
            else if (operation == "edit")
            {
                query = "SELECT * FROM mygroups WHERE name = @name AND userid = @uid AND id <> @gid";

                command.Parameters.Add("@name", SqlDbType.VarChar).Value = name;
                command.Parameters.Add("@uid", SqlDbType.Int).Value = userid;
                command.Parameters.Add("@gid", SqlDbType.Int).Value = groupid;
            }


            command.Connection = mydb.getConnection;
            command.CommandText = query;


            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();

            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool checkID(int groupid)
        {

            SqlCommand command = new SqlCommand("SELECT * FROM mygroups WHERE id = @gid", mydb.getConnection);

            command.Parameters.Add("@gid", SqlDbType.Int).Value = groupid;



            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();

            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
