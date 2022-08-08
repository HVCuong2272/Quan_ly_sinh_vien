using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace QLSV.HUMAN
{
    class CONTACT
    {
        MY_DB mydb = new MY_DB();
        // Function to insert a new contact
        public bool insertContact(int contactid, string fname, string lname, string phone, string address, string email, int userid, int groupid, MemoryStream picture)
        {
            SqlCommand command = new SqlCommand("INSERT INTO mycontact (id, fname, lname, group_id, phone, email, address, pic, userid) VALUES (@id, @fn, @ln, @grp, @phn, @mail, @adrs, @pic, @uid)", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = contactid;
            command.Parameters.Add("@fn", SqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@ln", SqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@grp", SqlDbType.Int).Value = groupid;
            command.Parameters.Add("@phn", SqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@mail", SqlDbType.VarChar).Value = email;
            command.Parameters.Add("@adrs", SqlDbType.VarChar).Value = address;
            command.Parameters.Add("@pic", SqlDbType.Image).Value = picture.ToArray();
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

        // Function to update contact
        public bool updateContact(int contactid, string fname, string lname, string phone, string address, string email, int groupid, MemoryStream picture)
        {
            SqlCommand command = new SqlCommand("UPDATE mycontact SET fname = @fn, lname = @ln, group_id = @gid, phone = @phn, email = @mail, address = @adrs, pic = @pic WHERE id = @id ", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = contactid;
            command.Parameters.Add("@fn", SqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@ln", SqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@gid", SqlDbType.Int).Value = groupid;
            command.Parameters.Add("@phn", SqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@mail", SqlDbType.VarChar).Value = email;
            command.Parameters.Add("@adrs", SqlDbType.VarChar).Value = address;
            command.Parameters.Add("@pic", SqlDbType.Image).Value = picture.ToArray();

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

        // delete Contact
        public bool deleteContact(int contactid)
        {
            SqlCommand command = new SqlCommand("DELETE FROM mycontact WHERE id = @id", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = contactid;
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


        // nap du lieu
        public DataTable SelectContactList(SqlCommand command)
        {
            command.Connection = mydb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        // create a function to get all contact by userid
        public DataTable getAllContactById(int userid)
        {
            SqlCommand command = new SqlCommand("SELECT *  FROM mygroups WHERE userid = @uid", mydb.getConnection);
            command.Parameters.Add("@uid", SqlDbType.Int).Value = userid;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();

            adapter.Fill(table);

            return table;
        }

        public DataTable GetContactById(int contactId)
        {
            SqlCommand command = new SqlCommand("SELECT id, fname, lname, group_id, phone, email, address, pic, userid FROM mycontact WHERE id = @id", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = contactId;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        // Check Id in contact have exist or not
        public bool checkID(int contactid)
        {

            SqlCommand command = new SqlCommand("SELECT * FROM mycontact WHERE id = @cid", mydb.getConnection);

            command.Parameters.Add("@cid", SqlDbType.Int).Value = contactid;



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
