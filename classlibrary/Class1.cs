using System.Linq;
using System.Collections.Generic;
using classlibrary;
namespace classlibrary
{
    public class Class1
    {
        ProjectContext dc = new ProjectContext();
        public int registermethod(Register r)
        {

            dc.Registers.Add(r);

            int res = dc.SaveChanges();
            return res;
        }
        public int Login(string uname, string pwd)
        {
            var res = (from t in dc.Registers
                       where t.Username == uname & t.Pwd == pwd
                       select t).Count();
            //dc.Loginusers.Add(lu);

            //int databaseadded = dc.SaveChanges();
            return res;

          
            //return databaseadded;
        }
        //public List<Java> Displayajava()
        //{
        //    //var res = from t in dc.Javas
        //    //        where t.Qid=.ToString
        //    //    select t;
        //    var res = dc.Javas.ToList();
        //    //if we used every thing display but need 1 question
        //    return res;


        //}
        //public List<Java> Displayajava()
        //{
        //    //var res = from t in dc.Javas
        //    //        where t.Qid=.ToString
        //    //    select t;

        //    var res = dc.Javas.ToList();
        //    //List<Question> li = new List<Question>();
        //    //li.Add()
        //    return res;
        //}

        public List<Java> Displayajavahard()
        {
            //var res = from t in dc.Javas
            //        where t.Qid=.ToString
            //    select t;

            var res = dc.Javas.ToList();
            //List<Question> li = new List<Question>();
            //li.Add()
            return res;
        }
        public int AddCategorymethod(Techincal c)
        {

            dc.Techincals.Add(c);

            int res = dc.SaveChanges();
            return res;
        }
        //public List<Java> questions(int Qid)
        //{
        //    var res = (from t in dc.Javas
        //               where t.Qid == Qid
        //               select t).ToList();
        //    return res;
        //}
        public int feedbackmethod(Feedback fb)
        {

            dc.Feedbacks.Add(fb);

            int res = dc.SaveChanges();
            return res;
        }
        public List<Displayquestion> GetQuestions()
        {
           

            Displayquestion questions = new Displayquestion();

          
            List<Displayquestion> questionsList = new List<Displayquestion>();
            var res = dc.Displayquestions.ToList();
            foreach (var r in res)
            {
                ////for (; r.Courseid <= 3 && r.Levels == "3";)
                ////{
                if (r.Courseid == 2 && r.Levels == "1")
                {

                    questionsList.Add(new Displayquestion { Courseid = r.Courseid, Qid = r.Qid, Question = r.Question, Option1 = r.Option1, Option2 = r.Option2, Option3 = r.Option3, Option4 = r.Option4 });
                   // }
                }
            }
           
                return questionsList;
           
           

            //questionsList.Add(new Java { Qid = 1, Question = ".Net Questions",Option1="jd",Option2="dd",Option3="cc",Option4="ddp" });
            //questionsList.Add(new Java { Qid = 2, Question = "Java Questions", Option1 = "jd", Option2 = "dd", Option3 = "cc", Option4 = "ddp" });
            //questionsList.Add(new Java { Qid = 3, Question = "Oracle Questions", Option1 = "jd", Option2 = "dd", Option3 = "cc", Option4 = "ddp" });
            //questionsList.Add(new Java { Qid = 4, Question = "SQL Questions", Option1 = "jd", Option2 = "dd", Option3 = "cc", Option4 = "ddp" });
            //questionsList.Add(new Java { Qid = 5, Question = "Angular Questions", Option1 = "jd", Option2 = "dd", Option3 = "cc", Option4 = "ddp" });




        }

        public Displayquestion NextQuestion(int i)
        {
            Displayquestion nextQuestion = new Displayquestion();
            List<Displayquestion> questions = GetQuestions();

            nextQuestion = questions.Take(i).Last();
            return nextQuestion;
        }

        public Displayquestion RandomQuestion()
        {
            var random = new Random();
            Displayquestion randomQuestion = new Displayquestion();
            List<Displayquestion> randomQuestions = new List<Displayquestion>();
            randomQuestions = GetQuestions();
            //for (int i=0;i<randomQuestions.Count();i++)
            //{
            int index = random.Next(randomQuestions.Count());
            //    newRandomList.Add(randomQuestions[index]);
            //}

            randomQuestion = randomQuestions[index];
            return randomQuestion;
            //newRandomList = newRandomList.Skip(2).Take(5).ToList();
            //return newRandomList;
        }

        //public List<Displayquestion> RandomList15Questions()
        //{
        //    var res = dc.Displayquestions.ToList();
        //    var random = new Random();
        //    Displayquestion randomQuestion = new Displayquestion();
        //    List<Displayquestion> randomQuestions = new List<Displayquestion>();
        //    List<Displayquestion> newRandomList = new List<Displayquestion>();
        //    foreach (var r in res)
        //    {
        //        newRandomList.Add(new Displayquestion { Qid = r.Qid, Question = r.Question, Option1 = r.Option1, Option2 = r.Option2, Option3 = r.Option3, Option4 = r.Option4 });
        //    }
        //    for (int i = 0; i < randomQuestions.Count(); i++)
        //    {
        //        int index = random.Next(randomQuestions.Count());
        //    }
        //    newRandomList.Add(randomQuestions[1]);
        //    newRandomList = newRandomList.Skip(2).Take(15).ToList();
        //    return newRandomList;
        //}

    }
}