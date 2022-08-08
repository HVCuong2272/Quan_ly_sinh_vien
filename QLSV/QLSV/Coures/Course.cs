using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV.Coures
{
    class Course
    {
        MY_DB mydb = new MY_DB();

        public bool insertCourse(int ID, string courseName, int hoursNumber, string description, int se)
        {
            SqlCommand command = new SqlCommand("INSERT INTO Course (ID, Name_Course, Hours, Description,Semester )" + "VALUES (@id,@name, @hrs, @dscr,@se)", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = ID;
            command.Parameters.Add("@name", SqlDbType.VarChar).Value = courseName;
            command.Parameters.Add("@hrs", SqlDbType.Int).Value = hoursNumber;
            command.Parameters.Add("@dscr", SqlDbType.Text).Value = description;
            command.Parameters.Add("@se", SqlDbType.Int).Value = se;
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

        public bool checkCourseName(string courseName, int courseID = 0)
        {

            SqlCommand command = new SqlCommand("SELECT * FROM Course WHERE Name_Course = @cName AND id <> @cid", mydb.getConnection);

            command.Parameters.Add("@cid", SqlDbType.Int).Value = courseID;
            command.Parameters.Add("@cName", SqlDbType.VarChar).Value = courseName;


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
        public bool deleteCourse(int courseID)
        {
            SqlCommand command = new SqlCommand("DELETE FROM Course WHERE id=@ID", mydb.getConnection);
            command.Parameters.Add("@ID", SqlDbType.Int).Value = courseID;
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

        public DataTable getAllCourse()
        {
            SqlCommand command = new SqlCommand("SELECT *  FROM Course", mydb.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();

            adapter.Fill(table);

            return table;


        }
        public DataTable getCoursebyID(int courseID)
        {
            SqlCommand command = new SqlCommand("SELECT *  FROM Course WHERE id= @cid", mydb.getConnection);
            command.Parameters.Add("@cid", SqlDbType.Int).Value = courseID;

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();

            adapter.Fill(table);

            return table;
        }

        public bool updateCours(int courseID, string courseName, int hoursNumber, string description, int Semester)
        {
            SqlCommand command = new SqlCommand("UPDATE Course SET Name_Course=@name, Hours = @hrs, Description = @dscr, Semester=@Semester WHERE ID=@cid", mydb.getConnection);
            
            command.Parameters.Add("@cid", SqlDbType.Int).Value = courseID;
            command.Parameters.Add("@name", SqlDbType.VarChar).Value = courseName;
            command.Parameters.Add("@hrs", SqlDbType.Int).Value = hoursNumber;
            command.Parameters.Add("@dscr", SqlDbType.Text).Value = description;
            command.Parameters.Add("@Semester", SqlDbType.Int).Value = Semester;
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
        public string execCount(string query)
        {
            SqlCommand command = new SqlCommand(query, mydb.getConnection);
            mydb.openConnection();
            string count = command.ExecuteScalar().ToString();
            mydb.closeConnection();
            return count;

        }
        public string TotalCourse()
        {
            return execCount("SELECT COUNT(*) FROM Course");
        }
        public DataTable getAvailable()
        {
            SqlCommand command = new SqlCommand();
            command.Connection = mydb.getConnection;

            command.CommandText = ("SELECT ID,Name_Course  FROM Course");

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;


        }
        public bool insertAC(int ID, int Courseid)
        {
            SqlCommand command = new SqlCommand("INSERT INTO score (Student_Id, course_id )" + "VALUES (@id, @Courseid)", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = ID;
            command.Parameters.Add("@Courseid", SqlDbType.VarChar).Value = Courseid;

      

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
        public DataTable getchon ( string Student_Id)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = mydb.getConnection;

            command.CommandText = ("SELECT course_id  FROM score Where Student_Id=@Student_Id ");
            command.Parameters.Add("@Student_Id", SqlDbType.VarChar).Value = Student_Id;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;


        }
        public DataTable getSeemester(int Semester)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = mydb.getConnection;

            command.CommandText = ("SELECT ID ,Name_Course FROM Course Where Semester=@Semester");
            command.Parameters.Add("@Semester", SqlDbType.Int).Value = Semester;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;



        }

    }
}
