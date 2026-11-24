using System;
using System.Collections.Generic;
using System.Linq;

namespace exam01
{
    internal class Program
    {
        static Question CreateMCQQuestion()
        {
            Console.Write("Enter Question Header: ");
            string header = Console.ReadLine();

            Console.Write("Enter Question Body: ");
            string body = Console.ReadLine();

            Console.Write("Enter Question Mark: ");
            int mark = int.Parse(Console.ReadLine());

            Console.Write("Enter Number of Answers: ");
            int numberOfAnswers = int.Parse(Console.ReadLine());

            Answer[] answers = new Answer[numberOfAnswers];

            for (int i = 0; i < numberOfAnswers; i++)
            {
                Console.Write($"Enter Answer {i + 1}: ");
                string text = Console.ReadLine();

                answers[i] = new Answer(i + 1, text);
            }

            Console.Write("Enter Correct Answer ID: ");
            int rightAnswerId = int.Parse(Console.ReadLine());

            Answer rightAnswer = answers.First(a => a.AnswerId == rightAnswerId);

            return new MCQQuestion(header, body, mark, answers, rightAnswer);
        }


        static Question CreateTrueFalseQuestion()
        {
            Console.Write("Enter Question Header: ");
            string header = Console.ReadLine();

            Console.Write("Enter Question Body: ");
            string body = Console.ReadLine();

            Console.Write("Enter Question Mark: ");
            int mark = int.Parse(Console.ReadLine());

            Answer[] answers =
            {
        new Answer(1, "True"),
        new Answer(2, "False")
    };

            Console.WriteLine("1. True");
            Console.WriteLine("2. False");

            Console.Write("Enter Correct Answer ID: ");
            int rightAnswerId = int.Parse(Console.ReadLine());

            Answer rightAnswer = answers.First(a => a.AnswerId == rightAnswerId);

            return new TrueFalseQuestion(header, body, mark, answers, rightAnswer);
        }


        static List<Question> CreateQuestions(int examType, int numberOfQuestions)
        {
            List<Question> questions = new List<Question>();

            for (int i = 0; i < numberOfQuestions; i++)
            {
                Console.WriteLine($"\nCreating Question {i + 1}");

                Question q;

                if (examType == 1) // Practical
                {
                    q = CreateMCQQuestion();
                }
                else // Final
                {
                    Console.WriteLine("Choose Question Type:");
                    Console.WriteLine("1. MCQ");
                    Console.WriteLine("2. True / False");

                    int questionType = int.Parse(Console.ReadLine());

                    if (questionType == 1)
                        q = CreateMCQQuestion();
                    else
                        q = CreateTrueFalseQuestion();
                }

                questions.Add(q);
            }

            return questions;
        }
       

        
        
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Exam System");

            Console.WriteLine("Choose Exam Type:");
            Console.WriteLine("1. Practical");
            Console.WriteLine("2. Final");

            int examType = int.Parse(Console.ReadLine());

            Console.Write("Enter Subject ID: ");
            int subjectId = int.Parse(Console.ReadLine());

            Console.Write("Enter Subject Name: ");
            string subjectName = Console.ReadLine();

            Console.Write("Enter Exam Time in Minutes: ");
            int time = int.Parse(Console.ReadLine());

            Console.Write("Enter Number of Questions: ");
            int numberOfQuestions = int.Parse(Console.ReadLine());

            List<Question> questions = CreateQuestions(examType, numberOfQuestions);

            Subject subject = new Subject(subjectId, subjectName);

            subject.CreateExam(examType, time, questions);

            Console.WriteLine("\nExam Created Successfully!");

            Console.WriteLine($"Subject: {subject.SubjectName}");
            Console.WriteLine($"Exam Time: {subject.Exam.Time} Minutes");
            Console.WriteLine($"Number of Questions: {subject.Exam.NumberOfQuestions}");

            Console.WriteLine("\nDo you want to start the exam?");
            Console.WriteLine("1. Yes");
            Console.WriteLine("2. No");

            int startChoice = int.Parse(Console.ReadLine());

            if (startChoice == 1)
            {
                subject.Exam.StartExam();
            }
            else
            {
                Console.WriteLine("Exam was not started.");
            }
        
    }
    }
}
