using System;
using System.Collections.Generic;
using System.Text;

namespace exam01
{
    abstract class Exam
    {
        public int Time { get; set; }
        public int NumberOfQuestions { get; set; }
        public List<Question> Questions { get; set; }

        public Exam(int time, List<Question> questions)
        {
            Time = time;
            Questions = questions;
            NumberOfQuestions = questions.Count;
        }

        public abstract void StartExam();

        public abstract void ShowResult();
    }
}
