using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace Developertest.Models
{
    public class BalTest
    {
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-T0MR8MPD;Initial Catalog=DeveloperTest;Integrated Security=True");

        public void SaveInfo(Test obj)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("TestDb", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Condition", "InsertStudentinfo");
            cmd.Parameters.AddWithValue("@name",obj.StudentName);
            cmd.Parameters.AddWithValue("@age", obj.age);
            cmd.Parameters.AddWithValue("@image", obj.image);
            cmd.Parameters.AddWithValue("@class", obj.Class);
            cmd.Parameters.AddWithValue("@rollno", obj.rollno);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public DataSet fatchstudInfo()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("TestDb", con);
            cmd.CommandType=CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Condition", "FatchStudentInfo");
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand= cmd;
            DataSet ds = new DataSet();
            adpt.Fill(ds);
            return ds;
        }
        public DataSet searchstud(Test obj)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("TestDb", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Condition", "SearchStud");
            cmd.Parameters.AddWithValue("name", obj.StudentName);
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataSet ds = new DataSet();
            adpt.Fill(ds);
            return ds;
        }
        public void SaveTechInfo(Test obj)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("TestDb", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Condition", "InsertTechinfo");
            cmd.Parameters.AddWithValue("@name", obj.TeacherName);
            cmd.Parameters.AddWithValue("@age", obj.age);
            cmd.Parameters.AddWithValue("@image", obj.image);
            cmd.Parameters.AddWithValue("@gender", obj.gender);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void SaveSubInfo(Test obj)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("TestDb", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Condition", "InsertSubinfo");
            cmd.Parameters.AddWithValue("@name", obj.SubjectName);
            cmd.Parameters.AddWithValue("@class", obj.Class);
            cmd.Parameters.AddWithValue("@lang", obj.lang);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public DataSet TechName()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("TestDb", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Condition", "TeacherName");
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataSet ds = new DataSet();
            adpt.Fill(ds);
            return ds;
            con.Close();
        }
        public DataSet SubName()
        {
            SqlCommand cmd = new SqlCommand("TestDb", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Condition", "SubjectName");
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataSet ds = new DataSet();
            adpt.Fill(ds);
            return ds;
            con.Close();
        }
        public void SaveTechSub(Test obj)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("TestDb", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Condition", "InsertTeachSubject");
            cmd.Parameters.AddWithValue("@teachid", obj.TeachId.ToString());
            cmd.Parameters.AddWithValue("@subid", obj.SubId.ToString());
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public DataSet TechSub()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("TestDb", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Condition", "TeachSublst");
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataSet ds = new DataSet();
            adpt.Fill(ds);
            return ds;
            con.Close();
        }
    }
}