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
            cmd.CommandText = "INSERT INTO StudentInfo VALUES('"+si.student_id+"','"+si.student_RFID+ "','"+si.first_name+ "','"+si.last_name+ "','"+si.gender_id+ "','"+si.contact_mobile+ "','"+si.email_address+ "','"+si.is_active+"')";
            return db.ExeNonQuery(cmd);
        }

        public int insertCourse(Courses c)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO Courses VALUES('" + c.course_name + "','" + c.course_code + "','" + c.course_type_id + "','" + c.is_optional + "','" + c.is_active + "')";
            return db.ExeNonQuery(cmd);
        }

        public DataTable ViewStudents(StudentInformations sf)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT student_id, student_RFID, (first_name + ' ' + last_name) AS name, g.gender, contact_mobile, email_address, is_active FROM StudentInfo INNER JOIN Gender AS g ON g.gender_id = StudentInfo.gender_id  WHERE is_active = 1";
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
    }
}