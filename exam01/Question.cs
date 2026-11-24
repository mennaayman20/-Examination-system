using System;
using System.Collections.Generic;
using System.Text;

namespace exam01
{
 class Question:ICloneable, IComparable
    {
        public string Header { get; set; }
        public string Body { get; set; }
        public int Mark { get; set; }

        public Answer[] AnswerList { get; set; }
        public Answer RightAnswer { get; set; }

        // Student Answer
        public Answer StudentAnswer { get; set; }

        public Question(string header, string body, int mark,
                      Answer[] answerList, Answer rightAnswer)
        {
            Header = header;
            Body = body;
            Mark = mark;
            AnswerList = answerList;
            RightAnswer = rightAnswer;
        }

        public virtual void DisplayQuestion()
        {
            Console.WriteLine(Header);
            Console.WriteLine(Body);

            foreach (Answer answer in AnswerList)
                Console.WriteLine(answer);
        }

        public override string ToString()
        {
            return $"{Header}\n{Body}\nMark: {Mark}";
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public int CompareTo(object obj)
        {
            Question other = obj as Question;

            if (other == null)
                return 1;

            return Mark.CompareTo(other.Mark);
        }
    }
}
