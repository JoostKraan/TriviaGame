using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triviagamefinal
{
    public class HistoryQuestions
    {
        public List<Question> questions;
        public List<Question> GetHistoryQuestions()
        {
            List<Question> questions = new List<Question>();
            Question vraag1 = new Question
            {
                Name = "When did World War 2 start and end?",
                Answers = new List<Answers> {
                    new Answers { isCorrect = false, Title = "1939-1940" },
                     new Answers { isCorrect = false, Title = "1918-1919" },
                      new Answers { isCorrect = true, Title = "1939-1945" },
                       new Answers { isCorrect = false, Title = "1914-1915" }
                }
            };

            Question vraag2 = new Question
            {
                Name = "Who built the great wall in China",
                Answers = new List<Answers> {
                    new Answers {isCorrect = false, Title = "Genghis Khan"},
                    new Answers {isCorrect = false, Title = "The Persians"},
                    new Answers {isCorrect = false, Title = "The Dutch"},
                    new Answers {isCorrect = true, Title = "The Chinese"}
                }
            };

            Question vraag3 = new Question
            {
                Name = "Who led the French Revolution?",
                Answers = new List<Answers> {
                    new Answers {isCorrect = false, Title = "Napoleon"},
                    new Answers {isCorrect = true, Title = "Maximilien Robespierre"},
                    new Answers {isCorrect = false, Title = "Charles de Gaulle"},
                    new Answers {isCorrect = false, Title = "Barrack Obama"}
                }
            };

            Question vraag4 = new Question
            {
                Name = "When was the first moonlanding?",
                Answers = new List<Answers> {
                    new Answers {isCorrect = false, Title = "1965"},
                    new Answers {isCorrect = false, Title = "1970"},
                    new Answers {isCorrect = true, Title = "1969"},
                    new Answers {isCorrect = false, Title = "1968"}
                }
            };

            Question vraag5 = new Question
            {
                Name = "Who was the 5th president of America",
                Answers = new List<Answers> {
                    new Answers {isCorrect = true, Title = "James Monroe"},
                    new Answers {isCorrect = false, Title = "James Buchanan"},
                    new Answers {isCorrect = false, Title = "William H. Taft"},
                    new Answers {isCorrect = false, Title = "Harry S. Truman"}
                }
            };

            Question vraag6 = new Question
            {
                Name = "Who discovered America?",
                Answers = new List<Answers> {
                    new Answers {isCorrect = false, Title = "Christopher Columbus"},
                    new Answers {isCorrect = false, Title = "Leif Erikson"},
                    new Answers {isCorrect = false, Title = "George Washington"},
                    new Answers {isCorrect = true, Title = "Amerigo Vespucci"}
                }
            };

            Question vraag7 = new Question
            {
                Name = "What was the Great Depression?",
                Answers = new List<Answers> {
                    new Answers {isCorrect = true, Title = "An economic downfall"},
                    new Answers {isCorrect = false, Title = "Covid 19"},
                    new Answers {isCorrect = false, Title = "The release of fortnite"},
                    new Answers {isCorrect = false, Title = "Homework"}
                }
            };

            Question vraag8 = new Question
            {
                Name = "How many kings and queens were before Willem Alexander",
                Answers = new List<Answers> {
                    new Answers {isCorrect = false, Title = "4"},
                    new Answers {isCorrect = false, Title = "10"},
                    new Answers {isCorrect = true, Title = "7"},
                    new Answers {isCorrect = false, Title = "12"}
                }
            };

            Question vraag9 = new Question
            {
                Name = "Welke rivier gaat er door de Gran Canyon?",
                Answers = new List<Answers> {
                    new Answers {isCorrect = true, Title = "Calorado River"},
                    new Answers {isCorrect = false, Title = "Mississippi River"},
                    new Answers {isCorrect = false, Title = "Hudson River"},
                    new Answers {isCorrect = false, Title = "Yukon River"}
                }
            };

            Question vraag10 = new Question
            {
                Name = "Wat zijn de meest gespoken talen in Canada?",
                Answers = new List<Answers> {
                    new Answers {isCorrect = true, Title = "Spaans en Engels"},
                    new Answers {isCorrect = false, Title = "Russisch en Engels"},
                    new Answers {isCorrect = false, Title = "Frans en Engels"},
                    new Answers {isCorrect = false, Title = "Manderijns en Engels"}
                }
            };
            questions.Add(vraag10);
            questions.Add(vraag9);
            questions.Add(vraag8);
            questions.Add(vraag7);
            questions.Add(vraag6);
            questions.Add(vraag5);
            questions.Add(vraag4);
            questions.Add(vraag3);
            questions.Add(vraag2);
            questions.Add(vraag1);
            return questions;
        }

    }
}

