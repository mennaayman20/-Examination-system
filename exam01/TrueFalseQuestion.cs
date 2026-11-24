using System;
using System.Collections.Generic;
using System.Text;

namespace exam01
{
     class TrueFalseQuestion: Question
    {
        public TrueFalseQuestion(string header, string body, int mark,
                          Answer[] answerList, Answer rightAnswer)
       : base(header, body, mark, answerList, rightAnswer)
        {
        }
    }
}
