using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trivia 
{
    public class QuestionsInterfaceGenerated : QuestionsInterface
    {

        public QuestionsStack GetQuestionStack(string category)
        {
            var questions = new LinkedList<string>();
            for (var i = 0; i < 50; i++)
            {
                
                questions.AddLast(category + " Question " + i);
            }
            var pileQuestion = new QuestionsStack(category, questions);
            return pileQuestion;
        }
    }
}
