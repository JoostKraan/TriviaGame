using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triviagamefinal
{
    public class GameQuestions
    {
        public List<Question> questions;
        public List<Question> getGameQuestions()
        {
            List<Question> questions = new List<Question>();
            Question vraag1 = new Question
            {
                Name = "In what year was Pac-Man created?",
                Answers = new List<Answers> {
                    new Answers { isCorrect = true, Title = "1980" },
                     new Answers { isCorrect = false, Title = "1990" },
                      new Answers { isCorrect = false, Title = "1982" },
                       new Answers { isCorrect = false, Title = "1986" }
                }
            };
            Question vraag2 = new Question
            {
                Name = "What was the name of the main protagonist in the Half-Life series?",
                Answers = new List<Answers> {
                    new Answers {isCorrect = false, Title = "Gordon Freeman"},
                    new Answers {isCorrect = true, Title = "Morgan Freeman"},
                    new Answers {isCorrect = false, Title = "Lordon Freeman"},
                    new Answers {isCorrect = false, Title = "Gardon Freeman"}
                }
            };
            Question vraag3 = new Question
            {
                Name = "Who is the main Character in Metal gear Solid?",
                Answers = new List<Answers> {
                    new Answers {isCorrect = false, Title = "Gas Snake"},
                    new Answers {isCorrect = false, Title = "Liquid Snake"},
                    new Answers {isCorrect = true, Title = "Solid Snake"},
                    new Answers {isCorrect = false, Title = "Long Snake"}
                }
            };
            Question vraag4 = new Question
            {
                Name = "When did portal 1 get released?",
                Answers = new List<Answers> {
                    new Answers {isCorrect = false, Title = "2012"},
                    new Answers {isCorrect = false, Title = "2005"},
                    new Answers {isCorrect = false, Title = "2000"},
                    new Answers {isCorrect = true, Title = "2007"}
                }
            };
            Question vraag5 = new Question
            {
                Name = "In what Continent did Call of Duty Modern Warfare (2009) take place?",
                Answers = new List<Answers> {
                    new Answers {isCorrect = false, Title = "Russia"},
                    new Answers {isCorrect = false, Title = "America"},
                    new Answers {isCorrect = false, Title = "United Kingdom"},
                    new Answers {isCorrect = true, Title = "Europe"}
                }
            };
            Question vraag6 = new Question
            {
                Name = "What is Microsoft worth?",
                Answers = new List<Answers> {
                    new Answers {isCorrect = false, Title = "700 Million"},
                    new Answers {isCorrect = false, Title = "300 Billion"},
                    new Answers {isCorrect = true, Title = "1700 Trillion"},
                    new Answers {isCorrect = false, Title = "2 Trillion"}
                }
            };
            Question vraag7 = new Question
            {
                Name = "When did lootboxes start appearing in games?",
                Answers = new List<Answers> {
                    new Answers {isCorrect = false, Title = "2002"},
                    new Answers {isCorrect = true, Title = "2007"},
                    new Answers {isCorrect = false, Title = "2015"},
                    new Answers {isCorrect = false, Title = "2013"}
                }
            };
            Question vraag8 = new Question
            {
                Name = "When will Half Life 3 Release?",
                Answers = new List<Answers> {
                    new Answers {isCorrect = false, Title = "2025"},
                    new Answers {isCorrect = false, Title = "2028"},
                    new Answers {isCorrect = false, Title = "2024"},
                    new Answers {isCorrect = true, Title = "f̸̙̹͙͕̻͖̾̐̓̊̃̈́̎̀͘͜ͅd̸̢̛͔͈̦̻̄̀̕͘͠f̷͇̌̏͛d̸͉͓̈́̆̐͊̈͑̄̉̽̄̈̾͝͠f̴̛̞̞͆͑͂́͑̉̎̿̕d̸̮̫͖͖̉͘f̵̦̟͈̮͇͆͌̾̽̊͜͠ͅd̶̢̢̜̞̲̜͖̰̦̭̫̓̏̋͊̎̌̈͂̽͜͝f̴̢̢̳̪̮̬̰̤̘̬̼̲̠̰͖̑̉̋̈͐̏͛͘͘d̴̫̠͛͂͐͒̄̉̈́́̈́̐͗͑͜"}
                }
            };
            Question vraag9 = new Question
            {
                Name = "What is the name of the Minecraft Enchantment table Language",
                Answers = new List<Answers> {
                    new Answers {isCorrect = true, Title = "Echanto blocko"},
                    new Answers {isCorrect = false, Title = "Galactic"},
                    new Answers {isCorrect = false, Title = "Enchanterra"},
                    new Answers {isCorrect = false, Title = "Arcanean"}
                }
            };
            Question vraag10 = new Question
            {
                Name = "What is the best dino in the game ARK Survival Evolved?",
                Answers = new List<Answers> {
                    new Answers {isCorrect = true, Title = "Therizinosaur"},
                    new Answers {isCorrect = true, Title = "Dodo"},
                    new Answers {isCorrect = true, Title = "Kairuku"},
                    new Answers {isCorrect = true, Title = "Phiomia"}
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

