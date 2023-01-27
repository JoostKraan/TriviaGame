using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triviagamefinal
{
    public class CatagoryQuestions
    {
        public List<Question> questions;
        public List<Question> GetgeoQuestions()
        {
            List<Question> questions = new List<Question>();
            Question vraag1 = new Question
            {
                Name = "Wat is de hoofdstad van Egypte?",
                Answers = new List<Answers> {
                    new Answers { isCorrect = false, Title = "Madrid" },
                     new Answers { isCorrect = true, Title = "Cairo" },
                      new Answers { isCorrect = false, Title = "Jakarta" },
                       new Answers { isCorrect = false, Title = "Kazan" }
                }
            };
            
            Question vraag2 = new Question
            {
                Name = "Wat is het Kleinste land op Aarde?",
                Answers = new List<Answers> {
                    new Answers {isCorrect = false, Title = " Monaco"},
                    new Answers {isCorrect = true, Title = "Vaticaan Stad"},
                    new Answers {isCorrect = false, Title = "Nauru"},
                    new Answers {isCorrect = false, Title = "San Marino"}
                }
            };
            
            Question vraag3 = new Question
            {
                Name = "In welk land is Internet uitgevonden?",
                Answers = new List<Answers> {
                    new Answers {isCorrect = true, Title = "Verenigde Staten"},
                    new Answers {isCorrect = false, Title = "Nederland"},
                    new Answers {isCorrect = false, Title = "Duitsland"},
                    new Answers {isCorrect = false, Title = "Frankrijk"}
                }
            };
            
            Question vraag4 = new Question
            {
                Name = "Wat is de oudste stad ter wereld?",
                Answers = new List<Answers> {
                    new Answers {isCorrect = false, Title = "Damascus"},
                    new Answers {isCorrect = false, Title = "Aleppo"},
                    new Answers {isCorrect = false, Title = "Varanasi"},
                    new Answers {isCorrect = true, Title = "Lebanon"}
                }
            };
            
            Question vraag5 = new Question
            {
                Name = "Welk land heeft de meeste inwoners?",
                Answers = new List<Answers> {
                    new Answers {isCorrect = true, Title = "China"},
                    new Answers {isCorrect = false, Title = "India"},
                    new Answers {isCorrect = false, Title = "Brazilie"},
                    new Answers {isCorrect = false, Title = "Pakistan"}
                }
            };
            
            Question vraag6 = new Question
            {
                Name = "Wat is de hoofdstad van Australie?",
                Answers = new List<Answers> {
                    new Answers {isCorrect = false, Title = "Sydney"},
                    new Answers {isCorrect = true, Title = "Canberra"},
                    new Answers {isCorrect = false, Title = "Melbourne"},
                    new Answers {isCorrect = false, Title = "Brisbane"}
                }
            };
            
            Question vraag7 = new Question
            {
                Name = "Welke munt-eenheid gebruikt Japan?",
                Answers = new List<Answers> {
                    new Answers {isCorrect = false, Title = "Rupee"},
                    new Answers {isCorrect = false, Title = "Yuan"},
                    new Answers {isCorrect = true, Title = "Yen"},
                    new Answers {isCorrect = false, Title = "Dong"}
                }
            };
            
            Question vraag8 = new Question
            {
                Name = "Hoeveel staten heeft de Verenigde Staten?",
                Answers = new List<Answers> {
                    new Answers {isCorrect = false, Title = "42"},
                    new Answers {isCorrect = false, Title = "47"},
                    new Answers {isCorrect = true, Title = "50"},
                    new Answers {isCorrect = false, Title = "36"}
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
            return new List<Question>();
        }
    }
}

