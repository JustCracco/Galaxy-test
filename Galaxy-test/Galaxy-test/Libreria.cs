using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galaxy_test
{
    public class Libreria
    {
        List<Film> films;

        public Libreria()
        {
            films = new List<Film>();
        }

        public string getListaFilmVisti()
        {
            string s = "";

            for(int i = 0; i < films.Count; i++)
            {
                if (films[i].getVisto())
                    s += $"{films[i].getName()}, ";
            }

            return s;
        }

        public string getListaFilmDaVedere()
        {
            string s = "";

            for (int i = 0; i < films.Count; i++)
            {
                if (!films[i].getVisto())
                    s += $"{films[i].getName()}, ";
            }

            return s;
        }

        public string getListaFilm()
        {
            string s = "";

            for (int i = 0; i < films.Count; i++)
                s += $"{films[i].getName()}, ";

            return s;
        }

        public string getFilmFromRegista(string searchregista)
        {
            string s = "";

            for(int i = 0; i < films.Count; i++)
            {
                if (films[i].getRegista() == searchregista)
                    s += $"{films[i].getName()}, ";
            }

            return s;
        }

        public string getFilmPerNome(string searchname)
        {
            string s = "";

            for(int i = 0; i < films.Count; i++)
            {
                if (films[i].getName() == searchname)
                    s += $"{films[i].getName()}";
            }

            return s;
        }

        public void AddFilm(Film newFilm)
        {
            bool alreadyIn = false;

            for(int i = 0; i < films.Count; i++)
            {
                if (films[i].getName() == newFilm.getName())
                    alreadyIn = true;
            }

            if(!alreadyIn)
                films.Add(newFilm);
        }

        public void RemoveFilm(Film delFilm)
        {
            int index = 0;
            bool found = false;

            for(int i = 0; i < films.Count; i++) 
            {
                if (films[i].getName() == delFilm.getName())
                {
                    found = true;
                    index = i;
                }
            }

            if(found)
                films.RemoveAt(index);
        }

        public void VediFilm(Film ViewFilm)
        {
            for(int i = 0; i < films.Count; i++)
            {
                if (films[i].getName() == ViewFilm.getName())
                    films[i].setVisto();
            }
        }
    }
}
