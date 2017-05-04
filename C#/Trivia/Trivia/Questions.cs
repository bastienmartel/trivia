using System;
using System.Collections.Generic;
using System.Linq;

namespace Trivia
{
    public class Questions
    {
        private readonly List<QuestionsStack> _categories = new List<QuestionsStack>();

        public Questions(IEnumerable<string> categories, QuestionsInterface monInterfaceAMoi)
        {
            GenerateQuestions(categories, monInterfaceAMoi);
        }

        private void GenerateQuestions(IEnumerable<string> categories, QuestionsInterface monInterfaceAMoi)
        {
            foreach (var category in categories)
            {
                //var questionsStack = new QuestionsStack(category);
                _categories.Add(monInterfaceAMoi.GetQuestionStack(category));
            }
        }

        public void AskQuestion(int playerPlace)
        {
            CurrentCategory(playerPlace).AskQuestionAndDiscardIt();
        }
        private QuestionsStack CurrentCategory(int playerPlace)
        {
            return _categories[playerPlace % _categories.Count];
        }
    }
}