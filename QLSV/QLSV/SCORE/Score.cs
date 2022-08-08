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


namespace QLSV.SCORE
{
    class Score
    {
        MY_DB mydb = new MY_DB();
        public bool inserScore( int student_Id, int course_Id, float student_score, string description)
        {
            SqlCommand command = new SqlCommand("INSERT INTO score (student_Id, course_Id, student_score, description) VALUES (@sid,@cid,@scr,@dscr)", mydb.getConnection);
            command.Parameters.Add("@sid", SqlDbType.Int).Value = student_Id;
            command.Parameters.Add("@cid", SqlDbType.Int).Value = course_Id;
            command.Parameters.Add("@scr", SqlDbType.Float).Value = student_score;
            command.Parameters.Add("@dscr", SqlDbType.VarChar).Value = description;

            mydb.openConnection();

            if((command.ExecuteNonQuery() == 1))
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
        public bool studentScoreExists(int student_Id, int course_Id)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM score WHERE student_Id=@sid AND course_Id=@cid", mydb.getConnection);

            command.Parameters.Add("@sid", SqlDbType.Int).Value = student_Id;
            command.Parameters.Add("@cid", SqlDbType.Int).Value = course_Id;

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);


            if (table.Rows.Count == 0)
            {
                return false;
            }
            else
            {
                return true;
            }


        }
        public DataTable getStudentScore()
        {
            SqlCommand command = new SqlCommand();
            command.Connection = mydb.getConnection;

            command.CommandText = ("SELECT score.Student_Id, std2.fname, std2.lname, score.course_id, Course.Name_Course, score.student_score FROM std2 INNER JOIN score ON std2.Id = score.Student_Id INNER JOIN Course ON score.course_id = Course.ID ");

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;


        }
        public DataTable getStudentScore3()
        {
            SqlCommand command = new SqlCommand();
            command.Connection = mydb.getConnection;

            command.CommandText = ("SELECT score.Student_Id, std2.lname, Course.Name_Course, score.student_score FROM std2 INNER JOIN score ON std2.Id = score.Student_Id INNER JOIN Course ON score.course_id = Course.ID ");

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;


        }
        public DataTable max()
        {
            SqlCommand command = new SqlCommand();
            command.Connection = mydb.getConnection;

            command.CommandText = ("SELECT  score.student_score FROM std2 INNER JOIN score ON std2.Id = score.Student_Id INNER JOIN Course ON score.course_id = Course.ID ");

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;


        }
        public bool getStudentScore2(int Student_Id, string fname, string lname,int  course_id, string Name_Course, float student_score)
        {
            //SqlCommand command = new SqlCommand();
            //command.Connection = mydb.getConnection;

            SqlCommand command = new SqlCommand("INSERT INTO Tam (Student_Id, fname, lname, course_id, Name_Course, student_score) VALUES (@Student_Id,@fname,@lname,@course_id,@Name_Course,@student_score)", mydb.getConnection);
            command.Parameters.Add("@Student_Id", SqlDbType.Int).Value = Student_Id;
            command.Parameters.Add("@fname", SqlDbType.VarChar).Value = fname; 
            command.Parameters.Add("@lname", SqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@course_id", SqlDbType.Int).Value = course_id;
            command.Parameters.Add("@Name_Course", SqlDbType.VarChar).Value = Name_Course;
            command.Parameters.Add("@student_score", SqlDbType.Float).Value = student_score;



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
        public DataTable getNameCourse(string Name_Course)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = mydb.getConnection;

            command.CommandText = ("SELECT * From Tam Where Name_Course=@Name_Course");
            command.Parameters.Add("@Name_Course", SqlDbType.VarChar).Value = Name_Course;

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;


        }
        public bool deleteScoreTam()
        {
            SqlCommand command = new SqlCommand("DELETE FROM Tam", mydb.getConnection);

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

        public bool deleteScore(int student_Id, int courseID)
        {
            SqlCommand command = new SqlCommand("DELETE FROM score WHERE Student_Id=@SID AND course_id = @cid", mydb.getConnection);
            command.Parameters.Add("@SID", SqlDbType.Int).Value = student_Id;
            command.Parameters.Add("@CID", SqlDbType.Int).Value = courseID;
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
        public DataTable avgScorebyCourse()
        {
            SqlCommand command = new SqlCommand();
            command.Connection = mydb.getConnection;

            command.CommandText = ("SELECT Course.Name_Course, avg(score.student_score) as Average_Score FROM Course, score WHERE Course.ID = score.course_id GROUP BY Course.Name_Course");

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public DataTable getCourseScores(int Course_Id)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = mydb.getConnection;

            command.CommandText = ("SELECT score.Student_Id, std2.fname, std2.lname, score.course_id, Course.Name_Course, score.student_score FROM std2 INNER JOIN score ON std2.Id = score.Student_Id INNER JOIN Course ON score.course_id = Course.ID WHERE score.course_id = " + Course_Id);

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public DataTable getStudentScores(int student_Id)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = mydb.getConnection;

            command.CommandText = ("SELECT score.Student_Id, std2.fname, std2.lname, score.course_id, Course.Name_Course, score.student_score FROM std2 INNER JOIN score ON std2.Id = score.Student_Id INNER JOIN Course ON score.course_id = Course.ID WHERE score.Student_Id = " + student_Id);

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public string getStaticCourse(int courseid)
        {
            SqlCommand command = new SqlCommand("Select dbo.GetGrade(@id) As AverageGrade", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = courseid;
            mydb.openConnection();
            string count = command.ExecuteScalar().ToString();
            mydb.closeConnection();
            return count;
        }



        public string getStaticPass()
        {
            return execCount("Insert Into dbo.average Select distinct std2.Id, (sum(student_score) / (Select Count(DISTINCT Name_Course) From Course )) AS AverageScore, case when(sum(student_score) / (Select Count(DISTINCT Name_Course) From Course)) >= 5.0 then 'pass'  when(sum(student_score) / (Select Count(DISTINCT Name_Course) From Course)) < 5.0 then 'fail' else NULL END AS Result from score, std2, Course where score.Student_Id = std2.Id AND Course.ID = score.course_id group by std2.Id  Select count(Result) from average Where Result = 'pass' DELETE FROM dbo.average; ");
        }
        public string getStaticFail()
        {
            return execCount("Insert Into dbo.average Select distinct std2.Id, (sum(student_score) / (Select Count(DISTINCT Name_Course) From Course )) AS AverageScore, case when(sum(student_score) / (Select Count(DISTINCT Name_Course) From Course)) >= 5.0 then 'pass'  when(sum(student_score) / (Select Count(DISTINCT Name_Course) From Course)) < 5.0 then 'fail' else NULL END AS Result from score, std2, Course where score.Student_Id = std2.Id AND Course.ID = score.course_id group by std2.Id  Select count(Result) from average Where Result = 'fail' DELETE FROM dbo.average; ");
        }
        public string execCount(string query)
        {
            SqlCommand command = new SqlCommand(query, mydb.getConnection);
            mydb.openConnection();
            string count = command.ExecuteScalar().ToString();
            mydb.closeConnection();
            return count;
        }
        public DataTable LoadResultForm()
        {
            SqlCommand command = new SqlCommand();
            command.Connection = mydb.getConnection;
            command.CommandText = ("IF OBJECT_ID('tempdb..##Temp') IS NOT NULL DROP TABLE ##Temp DECLARE @ListToPivot AS NVARCHAR(MAX) SELECT @ListToPivot = COALESCE(@ListToPivot + ',', '') + QUOTENAME(Name_Course) From Course DECLARE @SqlStatement NVARCHAR(MAX) SET @SqlStatement = N' SELECT* FROM( SELECT std2.Id, std2.fname, std2.lname, Course.Name_Course , score.student_score FROM score, std2, Course WHERE score.Student_Id = std2.Id AND score.course_id = Course.ID ) StudentResults PIVOT( SUM(student_score) FOR[Name_Course] IN( '+@ListToPivot+' ) ) AS PivotTable' set @SqlStatement = 'select * into ##Temp from (' + @SqlStatement + ') y' EXEC(@SqlStatement) SELECT* FROM(SELECT* FROM ##Temp) AS t1 INNER JOIN (Select distinct std2.Id, (sum(student_score)/ (Select Count(DISTINCT Name_Course) From Course )) AS AverageScore, case when(sum(student_score) / (Select Count(DISTINCT Name_Course) From Course)) >= 5.0 then 'pass'  when(sum(student_score) / (Select Count(DISTINCT Name_Course) From Course)) < 5.0 then 'fail' else NULL END AS Result from score, std2, Course where score.Student_Id = std2.Id AND Course.ID = score.course_id group by std2.Id) AS t2 ON (t1.Id = t2.Id)");
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public bool updateScore(int Student_Id, int course_id, float student_score )
        {
            SqlCommand command = new SqlCommand("UPDATE score SET student_score = @student_score WHERE Student_Id=@Student_Id AND course_id=@course_id", mydb.getConnection);

            command.Parameters.Add("@course_id", SqlDbType.Int).Value = course_id;
            command.Parameters.Add("@Student_Id", SqlDbType.Int).Value = Student_Id;
            command.Parameters.Add("@student_score", SqlDbType.Float).Value = student_score;
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
    }
}
