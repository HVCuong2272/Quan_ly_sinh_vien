using System;
using QLSV.SCORE;
using QLSV.Coures;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace QLSV.ACCOUNT
{
    class Account
    {

        MY_DB mydb = new MY_DB();
        public DataTable getAccount()
        {
            SqlCommand command = new SqlCommand();
            command.Connection = mydb.getConnection;

            command.CommandText = ("SELECT Id, username, password, Power   FROM login ");
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;


        }
        public bool checkAccount(int Id, string Username , int Password)
        {

            SqlCommand command = new SqlCommand("SELECT * FROM login WHERE Id = @Id AND username= @User AND password=@Pass", mydb.getConnection);

            command.Parameters.Add("@Id", SqlDbType.Int).Value = Id;
            command.Parameters.Add("@User ", SqlDbType.VarChar).Value = Username;
            command.Parameters.Add("@Pass ", SqlDbType.VarChar).Value = Password;

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

        public bool insertAccount(int Id, string username , int password )
        {
            SqlCommand command = new SqlCommand("INSERT INTO login (Id, username, password)" + "VALUES (@id,@name, @pass)", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = Id;
            command.Parameters.Add("@name", SqlDbType.VarChar).Value = username;
            command.Parameters.Add("@pass", SqlDbType.Int).Value = password;
           

            mydb.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool deleteAccount(int id)
        {
            SqlCommand command = new SqlCommand("DELETE FROM login WHERE Id=@id", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
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

        public bool updateAccount(int Id, string username, string password, string Power)
        {
            SqlCommand command = new SqlCommand("UPDATE login set  Id=@Id, username=@username, password=@password, Power = @Power  WHERE  Id=@Id", mydb.getConnection);
            command.Parameters.Add("@Id", SqlDbType.Int).Value = Id;
            command.Parameters.Add("@username", SqlDbType.VarChar).Value = username;
            command.Parameters.Add("@password", SqlDbType.VarChar).Value = password;
            command.Parameters.Add("@Power", SqlDbType.VarChar).Value = Power;

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
        public bool updateIDAccount(int Id, string username )
        {
            SqlCommand command = new SqlCommand("UPDATE login set  Id=@Id  WHERE  username=@username", mydb.getConnection);
            command.Parameters.Add("@Id", SqlDbType.Int).Value = Id;
            command.Parameters.Add("@username", SqlDbType.VarChar).Value = username;
            


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


        public bool checkAccount(string username , int Id )
        {

            SqlCommand command = new SqlCommand("SELECT * FROM login WHERE username <> @username AND Id = @Id", mydb.getConnection);

            command.Parameters.Add("@Id", SqlDbType.Int).Value = Id;
            command.Parameters.Add("@username", SqlDbType.VarChar).Value = username;


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

        public bool checkQUYEN(string power,int Id)
        {

            SqlCommand command = new SqlCommand("SELECT * FROM login WHERE power=@power AND Id=@ID", mydb.getConnection);

            command.Parameters.Add("@Id", SqlDbType.Int).Value = Id;
            command.Parameters.Add("@power", SqlDbType.VarChar).Value = power;


            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();

            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool insertInfor(int id, string fname, string  lname, string gender,int  phone,string address, string nationality)
        {
            SqlCommand command = new SqlCommand("UPDATE login set  id=@id, fname=@fname, lname=@lname, gender = @gender , phone=@phone, address=@address, nationality=@nationality WHERE  Id=@Id", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@fname", SqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@lname", SqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@gender", SqlDbType.VarChar).Value = gender;
            command.Parameters.Add("@phone", SqlDbType.Int).Value = phone;
            command.Parameters.Add("@address", SqlDbType.VarChar).Value = address;
            command.Parameters.Add("@nationality", SqlDbType.VarChar).Value = nationality;

            mydb.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }



        public DataTable getInfo()
        {
            SqlCommand command = new SqlCommand();
            command.Connection = mydb.getConnection;

            command.CommandText = ("SELECT id, fname, lname, gender, phone, address, nationality   FROM login ");
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;


        }
  



    }
}
