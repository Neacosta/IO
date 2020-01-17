using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IO
{
    public class player
    {


        //properties
        public string FileName { get; set; }

        public int PlayerAverage { get; set; }

        public string name;
        
        public DateTime date;

        private List<int> scoresList = new List<int>();

        //constructor to launch the program
        public player() { }

        //Constructor to manage getting players into a list. 
        public player(string row)
        {
       

            string[] columns = row.Split('|');

            // set name
            this.name = columns[0];
            this.date = Convert.ToDateTime(columns[1]);

            // set scoresList
            for (int i = 2; i < columns.Length; i++)
                if (columns[i] != "")
                    this.scoresList.Add(Convert.ToInt32(columns[i]));

        }

        public DateTime GameDate
        {
            get
            {
                return date;
            }
            set
            {
                date = value;
            }
        }

        public string PlayerName
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public List<int> Scores
        {
            get
            {
                return scoresList;
            }
            set
            {
                scoresList = value;
            }
        }



    }
}
