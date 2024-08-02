using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace ProjetDLL.ExoQuiz
{
    public class QuizTest
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public Quizz Quizz { get; set; }
        public Utilisateur Candidat { get; set; }
        public int Score { get; set; }

        public Dictionary<QuizQuestion, List<QuizReponse>> UserReponses { get; set; }

        public QuizTest(DateTime date, Quizz quizz, Utilisateur candidat, int score)
        {
            Date = date;
            Quizz = quizz;
            Candidat = candidat;
            Score = score;
            UserReponses = new Dictionary<QuizQuestion, List<QuizReponse>>();
        }

        //Méthode qui vérifie la réponse --- 1- 
        public void CheckReponse(QuizQuestion qst, string choixStr) 
        {
            if (!qst.IsMultiple) //1 réponse possible
            {
                int choix = Convert.ToInt32(choixStr);
                if (choix < 1 || choix > qst.Reponses.Count)
                {
                    throw new Exception("Le choix doit être compris entre 1 et " + qst.Reponses.Count);
                }
                if (qst.Reponses[choix - 1].IsCorrect)
                {
                    Score++;
                }

                UserReponses.Add(qst, new List<QuizReponse> { qst.Reponses[choix - 1] });
            }
            //Plusieurs réponses possibles
            else
            {
                string[] choices = choixStr.Split(','); //1,3
                List<QuizReponse> reps = new List<QuizReponse>();
                foreach (string choice in choices)
                {
                    int choix = Convert.ToInt32(choice);
                    if (choix < 1 || choix > qst.Reponses.Count)
                    {
                        throw new Exception("Le choix doit être compris entre 1 et " + qst.Reponses.Count);
                    }
                    if (qst.Reponses[choix - 1].IsCorrect)
                    {
                        Score++;
                    }
                    else
                    {
                        Score--;
                    }

                    reps.Add(qst.Reponses[choix - 1]);
                   
                }
                UserReponses.Add(qst, reps);
            }
        }

        //Méthode qui transmet le résultat par Email
        public void EnvoyerResultat()
        {
            string body = "Bonjour, \n Votre score pour le Quiz " + Quizz.Sujet + " est de " + Score;
            MailMessage m = new MailMessage("noreply@dawan.fr", Candidat.Email, "Quiz Sujet: " + Quizz.Sujet, body);

            //m.CC.Add("email");

            //Ecriture des réponses de l'utilisateur dans un fichier

            StreamWriter sr = new StreamWriter("c:\\test\\reponses.txt");
            foreach (QuizQuestion question in UserReponses.Keys)
            {
                sr.WriteLine(question.QstText);
                foreach (QuizReponse reponse in UserReponses[question])
                {
                    sr.WriteLine(reponse.RepText);
                }

                sr.WriteLine("------------------------------");
            }
            sr.Close();

            //Envoie par pièce jointe du fichier à l'utilisateur
            m.Attachments.Add(new Attachment("c:\\test\\reponses.txt"));

            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            smtp.UseDefaultCredentials = true;
            smtp.Credentials = new NetworkCredential("phrad.sainha@gmail.com", "1234dawan");
            smtp.EnableSsl = true;
            smtp.Send(m);

        }
    }
}

/*
  * question------------------------
  * 1- lllll
  * 2- kkkkk
  * 3- lllll
  * 4-gdhgdd
  * 
  * 
  */
