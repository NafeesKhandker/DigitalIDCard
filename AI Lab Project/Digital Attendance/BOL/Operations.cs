using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DAL;
using Entity;

namespace BOL
{
    public class Operations
    {
        string loggedUsername;
        public void setUserName(string username)
        {
            loggedUsername = username;
        }
        public DbConnection db = new DbConnection();
        //All Database Operations

        public int insertStudentInfo(StudentInformations si)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO StudentInfo VALUES('"+si.student_id+"','"+si.student_RFID+ "','"+si.first_name+ "','"+si.last_name+ "','"+si.contact_mobile+ "','"+si.email_address+"')";
            return db.ExeNonQuery(cmd);
        }

        public int insertCourse(Courses c)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO Courses VALUES('" + c.course_name + "','" + c.course_code +"')";
            return db.ExeNonQuery(cmd);
        }

        public DataTable ViewStudents(StudentInformations sf)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT student_id, student_RFID, (first_name + ' ' + last_name) AS name, contact_mobile, email_address FROM StudentInfo";
            return db.ExeReader(cmd);
        }

        public DataTable login(UserProfile up)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM UserProfile AS up WHERE up.user_name = '"+up.username+"' AND up.password = '"+up.password+"'";
            return db.ExeReader(cmd);
        }

        public DataTable ViewUserProfile(UserProfile up)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM UserProfile AS up WHERE up.user_name = '"+loggedUsername+"'";
            return db.ExeReader(cmd);
        }

        public SqlDataReader GetStudentID()
        {
            SqlConnection conn = db.connection;
            string Sql = "SELECT student_id FROM StudentInfo";     
            if (conn.State != ConnectionState.Open)
               conn.Open();
            SqlCommand cmd = new SqlCommand(Sql, conn);
            return cmd.ExecuteReader();
            
        }

        public SqlDataReader GetCourses()
        {
            string Sql = "SELECT course_code FROM Courses";
            SqlConnection conn = db.connection;
            if (conn.State != ConnectionState.Open)
                conn.Open();
            SqlCommand cmd = new SqlCommand(Sql, conn);

            return cmd.ExecuteReader();
        }

        public bool IsValidPassword(string pass)
        {
            string Sql = "SELECT COUNT(*) FROM Courses WHERE password = '"+pass+"'";
            SqlConnection conn = db.connection;
            if (conn.State != ConnectionState.Open)
                conn.Open();
            SqlCommand cmd = new SqlCommand(Sql, conn);
            if (cmd.ExecuteScalar() != null)
            {
                int Status = (int)cmd.ExecuteScalar();
                if (Status > 0)
                {
                    conn.Close();
                    return true;
                }    
            }
            conn.Close();
            return false;
        }

        public String GetCourseNameByPW(string pass)
        {
            string Sql = "SELECT course_name FROM Courses WHERE password = '" + pass + "'";
            SqlConnection conn = db.connection;
            if (conn.State != ConnectionState.Open)
                conn.Open();
            SqlCommand cmd = new SqlCommand(Sql, conn);
            string value = (string)cmd.ExecuteScalar();
            conn.Close();
            return value;
        }

        public String GetCourseCodeByPW(string pass)
        {
            string Sql = "SELECT course_code FROM Courses WHERE password = '" + pass + "'";
            SqlConnection conn = db.connection;
            if (conn.State != ConnectionState.Open)
                conn.Open();
            SqlCommand cmd = new SqlCommand(Sql, conn);
            string value = (string)cmd.ExecuteScalar();
            conn.Close();
            return value;
        }

        public bool IsRunningCourse(string courseCode)
        {
            string Sql = "SELECT COUNT(*) FROM DynamicCourseID WHERE dynamic_course_code = '" + courseCode + "'";
            SqlConnection conn = db.connection;
            if (conn.State != ConnectionState.Open)
                conn.Open();
            SqlCommand cmd = new SqlCommand(Sql, conn);
            if (cmd.ExecuteScalar() != null)
            {
                int Status = (int)cmd.ExecuteScalar();
                if (Status > 0)
                {
                    conn.Close();
                    return true;
                }
            }
            conn.Close();
            return false;
        }

        public int insertDynamicCourse(string courseCode)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO DynamicCourseID VALUES('" + courseCode + "')";
            return db.ExeNonQuery(cmd);
        }

        public int DeleteDynamicCourse(string courseCode)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "DELETE FROM DynamicCourseID WHERE dynamic_course_code = '" + courseCode + "'";
            return db.ExeNonQuery(cmd);
        }

        public int DeleteAllDynamicCourses()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "DELETE FROM DynamicCourseID";
            return db.ExeNonQuery(cmd);
        }

        public bool HasCourseAssigned(string stdID, string crsname)
        {
            string Sql = "SELECT COUNT(*) FROM AssignedCourseList WHERE student_id = '" + stdID + "' AND course_id = '" + crsname + "'";
            SqlConnection conn = db.connection;
            if (conn.State != ConnectionState.Open)
                conn.Open();
            SqlCommand cmd = new SqlCommand(Sql, conn);
            if (cmd.ExecuteScalar() != null)
            {
                int Status = (int)cmd.ExecuteScalar();
                if (Status > 0)
                {
                    conn.Close();
                    return true;
                }
            }
            conn.Close();
            return false;
        }

        public int AssaignCourse(string stdID, string crsname)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO AssignedCourseList VALUES('" + stdID + "','" + crsname + "')";
            return db.ExeNonQuery(cmd);
        }

        public DataTable ViewAllAssignedCourses()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM AssignedCourseList";
            return db.ExeReader(cmd);
        }

        public DataTable ViewByIDAssignedCourses(string stdID)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM AssignedCourseList WHERE student_id = '" + stdID + "'";
            return db.ExeReader(cmd);
        }

        public int DeleteAssignedCourses(string stdID, string crsCode)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "DELETE FROM AssignedCourseList WHERE student_id = '" + stdID + "' AND course_id = '" + crsCode + "'";
            return db.ExeNonQuery(cmd);
        }

        public bool IsAssignedToThisCourse(string RFID, string crsCode)
        {
            string Sql = "SELECT COUNT (*) course_id FROM AssignedCourseList INNER JOIN StudentInfo ON AssignedCourseList.student_id = StudentInfo.student_id AND StudentInfo.student_RFID = '" + RFID + "' AND AssignedCourseList.course_id = '" + crsCode + "'";
            SqlConnection conn = db.connection;
            if (conn.State != ConnectionState.Open)
                conn.Open();
            SqlCommand cmd = new SqlCommand(Sql, conn);
            if (cmd.ExecuteScalar() != null)
            {
                int Status = (int)cmd.ExecuteScalar();
                if (Status > 0)
                {
                    conn.Close();
                    return true;
                }
            }
            conn.Close();
            return false;
        }

        public int TakeAttendance(string RFID, string crsCode)
        {
            string date = DateTime.Now.ToString("d/M/yyyy");
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO Attendance (student_id, course_code, attendence_date, is_present) VALUES((SELECT StudentInfo.student_id FROM StudentInfo WHERE StudentInfo.student_RFID = '" + RFID + "'), '" + crsCode + "', '" + date + "', 1)"
;
            return db.ExeNonQuery(cmd);
        }

        public DataTable ViewAttendenceToday()
        {
            string dateToday = DateTime.Now.ToString("d/M/yyyy");
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM Attendance WHERE attendence_date = '" + dateToday + "'";
            return db.ExeReader(cmd);
        }
    }
}