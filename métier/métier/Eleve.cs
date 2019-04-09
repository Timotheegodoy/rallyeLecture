using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace métier
{
    public class Eleve
    {
        private string nom;
        private string prenom;
        private string login;
        private string passWord;
        static Random rnd = new Random();

        public Eleve(string nom, string prenom, string login,PassWordType type)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.login = login;
            this.passWord = GetNewPassword(type);
        }

        static private string GetPasswordAleatoire()
        {
            string chaine = "";
            string[] MajAlphabet = { "A", "B", "C", "D", "E", "F", "G", "H",  "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "X", "Y", "Z"};
            string[] minAlphabet = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "x", "y", "z"};
            string[] SpecialChar = { "&", "*", "°", "@" };
            List<string> carac=new List<string>();
            carac.Add("majuscule");
            carac.Add("minuscule");
            carac.Add("minuscule");
            carac.Add("minuscule");
            carac.Add("minuscule");
            carac.Add("minuscule");
            carac.Add("minuscule");
            carac.Add("chiffre");
            carac.Add("special");
            for(int i=0;i<9;i++)
            {
                int tirage = rnd.Next(0, carac.Count());
                string k=carac[tirage];
                switch (k)
                {
                    case "minuscule":
                        chaine += minAlphabet[rnd.Next(0,25)];
                        break;
                    case "majuscule":
                        chaine += MajAlphabet[rnd.Next(0,25)];
                        break;
                    case "special":
                        chaine += SpecialChar[rnd.Next(0,SpecialChar.Length)];
                        break;
                    case "chiffre":
                        chaine += Convert.ToString(rnd.Next(0,10));
                        break;
                }
                carac.RemoveAt(tirage);
            }
            return chaine;
        }

        private string GetPasswordConstruit()
        {
            string chaine = prenom.ToUpper()[0] + nom.ToLower();
            return chaine;
        }

        public string GetNewPassword(PassWordType type)
        {
            string chaine = "";
            if (type == PassWordType.aleatoire)
            {
                chaine = GetPasswordAleatoire();
            }
            else
            {
                chaine = GetPasswordConstruit();
            }
            return chaine;
        }

        public string GetPassword
        {
            get
            {
                return this.passWord;
            }
        }

        public string GetLogin
        {
            get
            {
                return this.login;
            }
        }

        public string Getnom
        {
            get
            {
                return this.login;
            }
        }

        public string GetPrenom
        {
            get
            {
                return this.login;
            }
        }
    }
}
