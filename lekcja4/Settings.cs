using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lekcja4
{
    internal class Settings
    {
        private static Settings instance;
        private int sound;
        private int music;
        private string resolution;

        public static Settings Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new Settings();
                }
                return instance;
            }
        }

        public int Sound { get => sound; set => sound = value; }
        public int Music { get => music; set => music = value; }
        public string Resolution { get => resolution; set => resolution = value; }

        private Settings()
        {
            Sound = 100;
            Music = 100;
            Resolution = "800x600";
        }
    }
}
