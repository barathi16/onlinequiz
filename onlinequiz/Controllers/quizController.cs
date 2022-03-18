using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using classlibrary;
using onlinequiz.Controllers;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using System;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
namespace onlinequiz.Controllers
{

    public class quizController : Controller
    {
        private readonly ILogger<quizController> _logger;
    
        Class1 ob = new Class1();
        Displayquestion question = new Displayquestion();
        public quizController(ILogger<quizController> logger)
        {
            ViewData["QuestionsData"] = null;
            _logger = logger;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(IFormCollection frm)

        {
            string uname = frm["uname"];
            string pwd = frm["pwd"];
            HttpContext.Session.SetString("userid", uname);
            var r = ob.Login(uname, pwd);

            if (r > 0)
            {
                //ViewData["a"] = "Valid user";
               // Response.Redirect("course");
                return RedirectToAction("course");

            }
            else
            {
                ViewData["a"] = "In-Valid user";
                return View();
            }

           
        }
        public ViewResult Logout()
        {
            HttpContext.Session.Remove("userid");
            //Response.Redirect("Login");
            return View();
        }
        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register(Register r)
        {
            if (ModelState.IsValid)
            {

                var i = ob.registermethod(r);

                if (i > 0)
                {
                    ViewData["a"] = "New User created successfully";
                }
                else
                {
                    ViewData["a"] = "Error occured try after some time";
                }
                return View();
            }
            else
            {
                return View();
            }

        }
        public ActionResult Technical()
        {

            return View();
        }

        //[HttpGet]
        //    public ActionResult java()
        //    {
        //        //   hi.Add(Question);
        //        //if (Qid == null)//int Qid
        //        //{
        //        //    Qid = 1;
        //        //}

        //        //     return View(hi[0]);
        //        var result = ob.GetQuestions();
        //        return View(result);
        //        //  return View();
        //    }
        //    [HttpPost]
        //    public ActionResult java(Java j)
        //    {
        //        // var result = ob.Displayajava();

        //      TempData["c"] = Convert.ToInt32(TempData["c"]) + 1;

        //      return View(hi[Convert.ToInt32(TempData["c"])]);

        //     //    return View();
        //    }
        public ActionResult Displayquestion(string tempParam)
        {
            if (string.IsNullOrEmpty(tempParam))
            {
                question = ob.GetQuestions().First();
                ViewData["QuestionsData"] = question;
            }
            if (tempParam == "Next")
            {
                int tempID = Convert.ToInt32(TempData["ID"]) + 1;
                question = ob.NextQuestion(tempID);
                ViewData["QuestionsData"] = question;
                TempData["ID"] = question;
            }
            if (tempParam == "Random")
            {
                //question = ob.RandomList15Questions();
                question = ob.RandomQuestion();
                ViewData["QuestionsData"] = question;
            }
            return View();
        }

        public ActionResult Next()
        {
            return RedirectToAction("Displayquestion", new { tempParam = "Next" });
        }

        public ActionResult Random()
        {
            return RedirectToAction("Displayquestion", new { tempParam = "Random" });
        }

        //[HttpGet]
        //public ActionResult javaessay()
        //{



        //    var result = ob.Displayajavaessay();

        //    return View(result);


        // }
        //[HttpGet]
        //public ActionResult javamedium()
        //{



        //    var result = ob.Displayamedium();

        //    return View(result);


        //}
        //[HttpGet]
        //public ActionResult javahard()
        //{

        //    // //double pageCount = (double)((decimal)this.Context.Customers.Count() / Convert.ToDecimal(maxRows));
        //    // //Javahard.pageCount = (int)Math.Ceiling(pageCount);

        //    // //Javahard.CurrentPageIndex = currentPage;
        //    //var result = ob.Displayahard();

        //    //return View(result);

        //    if (TempData["i"] == null)
        //    {
        //        TempData["i"] = 1;
        //    }

        //    if (HttpContext.Session.GetString("Qid") == null)
        //    {

        //        return RedirectToAction("javahard");
        //    }

        //    try
        //    {
        //       Java q = null;
        //        int examid = Convert.ToInt32(TempData["courseid"].ToString());
        //        if (TempData["qid"] == null)
        //        {

        //            //q = ob.Displayajavahard().First(x => x.Question == qid);
        //            var list = ob.Displayajavahard().Skip(Convert.ToInt32(TempData["i"].ToString()));
        //            int qid = list.First().Qid;
        //            TempData["Qid"] = qid;
        //        }
        //        else
        //        {
        //            int qid = Convert.ToInt32(TempData["qid"].ToString());
        //            //q = ob.Displayajavahard().Where(x => x.Question == qid && x.Courseid == qid).SingleOrDefault();

        //            var list = ob.Displayajavahard().Skip(Convert.ToInt32(TempData["i"].ToString()));
        //            qid = list.First().Qid;
        //            TempData["Qid"] = qid;
        //            TempData["i"] = Convert.ToInt32(TempData["i"].ToString()) + 1;
        //        }
        //        TempData.Keep();
        //        return View(q);
        //    }
        //    catch (Exception)
        //    {
        //        return RedirectToAction("javahard");

        //    }

        //}

        //[HttpPost]
        //public ActionResult javahard(Java q)
        //{
        //    return RedirectToAction("javahard");
        //}

        public ActionResult ENDTEST()
        {




            return View();


        }
        public ActionResult Admin()
        {




            return View();



        }
        [HttpGet]
        public ActionResult ADDCategory()
        {




            return View();


        }


        [HttpPost]
        public ActionResult ADDCategory(Techincal c)
        {

            var i = ob.AddCategorymethod(c);

            if (i > 0)
            {

                ViewData["a"] = "New User created successfully";
            }
            else
            {
                ViewData["a"] = "Error occured try after some time";
            }


            return View();







        }
        public ActionResult ADDTEST()
        {



            return View();
        }
        public ActionResult course()
        {
            return View();
        }
        public ActionResult Aboutus()
        {
            return View();
        }
        public ActionResult Contactus()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Feedback()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Feedback(Feedback fb)
        {

            var i = ob.feedbackmethod(fb);

            if (i > 0)
            {
                ViewData["a"] = "thanks for ur valuable commments";
            }
            else
            {
                ViewData["a"] = "plz fill the requirment propperly";
            }
            return View();


        }
        public ActionResult myerrorpage()
        {
            return View();
        }
    }
}
