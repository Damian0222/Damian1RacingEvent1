using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Damian1RacingEvent1
{
    public class Horse
    {
        public string horseID;
        public string name;
        public DateTime dateOfBirth;

        //setters and getters
        public string HorseID
        {
            get { return horseID; }
            set { horseID = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public DateTime DateOfBirth
        {
            get { return dateOfBirth; }
            set { dateOfBirth = value; }
        }

        public Horse(string horseID, string name, DateTime dateOfBirth)
        {
            HorseID = horseID;
            Name = name;
            DateOfBirth = dateOfBirth;
        }

    }
}




