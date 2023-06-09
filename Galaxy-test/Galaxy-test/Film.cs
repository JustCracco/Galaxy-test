using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galaxy_test
{
    class Film
    {
        string name;
        string regista;
        float mediarecensione;
        bool visto;

        public Film(string name, string regista, float mediarecensione, bool visto)
        {
            this.name = name;
            this.regista = regista;
            this.mediarecensione = mediarecensione;
            this.visto = visto;
        }

        public string getName()
        {
            return name;
        }

        public string getRegista()
        {
            return regista;
        }

        public float getMediarecensione()
        {
            return mediarecensione;
        }

        public bool getVisto()
        {
            return visto;
        }

        public void setVisto()
        {
            visto = !visto;
        }
    }
}
