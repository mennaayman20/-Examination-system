using System;
using System.Collections.Generic;
using System.Text;

namespace exam01
{
     class FinalExam : Exam
    {
        public FinalExam(int time, List<Question> questions)
       : base(time, questions)
        {
        }

        public override void StartExam()
        {
            Console.WriteLine("\n===== Final Exam =====");

            foreach (Question q in Questions)
            {
                q.DisplayQuestion();

                Console.Write("Enter your answer ID: ");
                int answerId = int.Parse(Console.ReadLine());

                q.StudentAnswer = q.AnswerList
                    .FirstOrDefault(a => a.AnswerId == answerId);

                Console.WriteLine();
            }

            ShowResult();
        }

        public override void ShowResult()
        {
            int score = 0;

            Console.WriteLine("\n===== Final Result =====");

            foreach (Question q in Questions)
            {
                if (q.StudentAnswer != null &&
                    q.StudentAnswer.AnswerId == q.RightAnswer.AnswerId)
                {
                    score += q.Mark;
                }
            }

            int totalMarks = Questions.Sum(q => q.Mark);

            Console.WriteLine($"Your Score: {score} / {totalMarks}");

            foreach (Question q in Questions)
            {
                Console.WriteLine("----------------------");
                q.DisplayQuestion();

                Console.WriteLine($"Your Answer: {q.StudentAnswer?.AnswerText ?? "Not Answered"}");
                Console.WriteLine($"Correct Answer: {q.RightAnswer.AnswerText}");
            }
        }

    }
}
