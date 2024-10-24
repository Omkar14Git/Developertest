using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.SqlClient;
using System.Data;
using Developertest.Models;
using System.IO;


namespace Developertest.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult SaveSudInfo()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SaveSudInfo(Test obj, HttpPostedFileBase ProfileImage)
        {
            if (ProfileImage != null && ProfileImage.ContentLength > 0)
            {
                string profileImageFilename = Path.GetFileNameWithoutExtension(ProfileImage.FileName);
                string profileImageExtension = Path.GetExtension(ProfileImage.FileName);
                profileImageFilename = profileImageFilename + profileImageExtension;

                // Log the path for debugging
                string profileImagePath = "~/Content/img/" + profileImageFilename;
                obj.image = profileImagePath; // Save the image path to the object

                // Save the image to the server
                string profileImageFullPath = Path.Combine(Server.MapPath("~/Content/img/"), profileImageFilename);

                // Log the full path for debugging
                System.Diagnostics.Debug.WriteLine("Image Full Path: " + profileImageFullPath);

                ProfileImage.SaveAs(profileImageFullPath);
            }
            BalTest balTest = new BalTest();
            balTest.SaveInfo(obj); // Save the object info

            return RedirectToAction("StudentInfo");
        }

        [HttpGet]
        public ActionResult StudentInfo()
        {
            BalTest objbal = new BalTest();
            DataSet ds = new DataSet();
            ds=objbal.fatchstudInfo();
            Test obj = new Test();
            List<Test>templist = new List<Test>();
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                Test obj1 = new Test();

                obj1.Id= Convert.ToInt32(dr["StudendId"].ToString());
                obj1.StudentName=dr["StudentName"].ToString();
                obj1.age = Convert.ToInt32(dr["Age"].ToString());
                obj1.image = dr["Image"].ToString();
                obj1.Class = dr["Class"].ToString();
                obj1.rollno = dr["RollNo"].ToString();

                templist.Add(obj1);
            }
            obj.Studentlst = templist;
            return View(obj);
        }
        [HttpPost]

        public ActionResult StudentInfo(Test obj)
        {
            BalTest balobj=new BalTest();
            DataSet ds = new DataSet();
            ds=balobj.searchstud(obj);
            List<Test> templist = new List<Test>();
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                Test obj1 = new Test();

                obj1.Id = Convert.ToInt32(dr["StudendId"].ToString());
                obj1.StudentName = dr["StudentName"].ToString();
                obj1.age = Convert.ToInt32(dr["Age"].ToString());
                obj1.image = dr["Image"].ToString();
                obj1.Class = dr["Class"].ToString();
                obj1.rollno = dr["RollNo"].ToString();

                templist.Add(obj1);
            }
            obj.Studentlst = templist;
            return View(obj);
        }

        [HttpGet]
        public ActionResult SaveTechInfo()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SaveTechInfo(Test obj, HttpPostedFileBase ProfileImage)
        {
            if (ProfileImage != null && ProfileImage.ContentLength > 0)
            {
                string profileImageFilename = Path.GetFileNameWithoutExtension(ProfileImage.FileName);
                string profileImageExtension = Path.GetExtension(ProfileImage.FileName);
                profileImageFilename = profileImageFilename + profileImageExtension;

                // Log the path for debugging
                string profileImagePath = "~/Content/img/" + profileImageFilename;
                obj.image = profileImagePath; // Save the image path to the object

                // Save the image to the server
                string profileImageFullPath = Path.Combine(Server.MapPath("~/Content/img/"), profileImageFilename);

                // Log the full path for debugging
                System.Diagnostics.Debug.WriteLine("Image Full Path: " + profileImageFullPath);

                ProfileImage.SaveAs(profileImageFullPath);
            }
            BalTest balTest = new BalTest();
            balTest.SaveTechInfo(obj);
            return RedirectToAction("SaveTechInfo");
        }

        [HttpGet]
        public ActionResult SaveSubInfo()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SaveSubInfo(Test obj)
        {
          
            BalTest balTest = new BalTest();
            balTest.SaveSubInfo(obj);
            return View();
        }
        [HttpGet]
        public ActionResult TeacherSubName()
        {
            BalTest obj = new BalTest();

            // Fetching Teacher Data
            DataSet ds = obj.TechName();
            List<Test> lstTeach = new List<Test>();
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                Test cls = new Test();
                cls.TeachId = Convert.ToInt32(dr["TeacherId"].ToString()); // Assuming TeacherId is present
                cls.TeacherName = dr["Name"].ToString();
                lstTeach.Add(cls);
            }

            // Fetching Subject Data
            DataSet ds1 = obj.SubName();
            List<Test> lstsub = new List<Test>();
            foreach (DataRow dr in ds1.Tables[0].Rows)
            {
                Test cls = new Test();
                cls.SubId = Convert.ToInt32(dr["SubjectId"].ToString()); // Assuming SubjectId is present
                cls.SubjectName = dr["Name"].ToString();
                lstsub.Add(cls);
            }

            // Correctly setting ViewBag items
            ViewBag.Teacher = new SelectList(lstTeach, "TeachId", "TeacherName");
            ViewBag.Subject = new SelectList(lstsub, "SubId", "SubjectName");

            return View();
        }
        [HttpPost]
        public ActionResult TeacherSubName(Test obj)
        { 
            BalTest objbal= new BalTest();
            objbal.SaveTechSub(obj);
            return RedirectToAction("TeacherSubName");
        }
        [HttpGet]
        public ActionResult TeacherSublst()
        {
            Test obj= new Test();
            BalTest balobj = new BalTest();
            DataSet ds = new DataSet();
            ds = balobj.TechSub();
            List<Test> templist = new List<Test>();
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                Test obj1 = new Test();

                obj1.SubjectName = dr["SubjectName"].ToString();
                obj1.TeacherName = dr["TeacherName"].ToString();
                obj1.Class = dr["Class"].ToString();

                templist.Add(obj1);
            }
            obj.Studentlst = templist;
            return View(obj);
        }

    }
}