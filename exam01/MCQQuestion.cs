using System;
using System.Collections.Generic;
using System.Text;

namespace exam01
{
     class MCQQuestion:Question
    {
        public MCQQuestion(string header, string body, int mark,
                      Answer[] answerList, Answer rightAnswer)
        : base(header, body, mark, answerList, rightAnswer)
        {
        }
    }
}
