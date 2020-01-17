using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace IO
{
    class PlayerDB
    {

        public static List<player> GetPlayers(string path)
        {


            // create the object for the input stream for a text file
            StreamReader textIn =
                new StreamReader(
                new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read));

            // create the Players list
            List<player> players = new List<player>();

            // read the data from the file and store it in the student list
            while (textIn.Peek() != -1)
            {
                string row = textIn.ReadLine();
                player player = new player(row);
                players.Add(player);
            }

            // close the input stream for the text file
            textIn.Close();

            return players;
        }


        public static void AddPlayers(string path, DateTime date, string name)
        {


            File.AppendAllText(path, (name + "|" + date.ToShortDateString().ToString()).ToString() + "|" + Environment.NewLine);
            

        }

       

    }
}

