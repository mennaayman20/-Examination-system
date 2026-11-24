using System;
using System.Collections.Generic;
using System.Text;

namespace exam01
{
     class Subject
    {
        public int SubjectId { get; set; }
        public string SubjectName { get; set; }
        public Exam Exam { get; set; }

        public Subject(int subjectId, string subjectName)
        {
            SubjectId = subjectId;
            SubjectName = subjectName;
        }

        public void CreateExam(int examType, int time, List<Question> questions)
        {
            if (examType == 1)
            {
                Exam = new PracticalExam(time, questions);
            }
            else if (examType == 2)
            {
                Exam = new FinalExam(time, questions);
            }
        }
    }
}
