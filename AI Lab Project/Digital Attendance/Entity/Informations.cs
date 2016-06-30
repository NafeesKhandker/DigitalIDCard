using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class StudentInformations
    {
        public string student_id { get; set; }
        public string student_RFID { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string contact_mobile { get; set; }
        public string email_address { get; set; }
    }

    public class UserProfile
    {
        public int user_profile_id { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string username { get; set; }
        public string user_details { get; set; }
        public string contact_phone { get; set; }
        public string contact_mobile { get; set; }
        public string email_address { get; set; }
        public bool is_active { get; set; }
        public string password { get; set; }
    }

    public class Courses
    {
        public int course_id { get; set; }
        public string course_name { get; set; }
        public string course_code { get; set; }
        public string password { get; set; }
    }
}
