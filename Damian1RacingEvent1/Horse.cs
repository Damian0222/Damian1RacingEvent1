using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
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

        public override string ToString()
        {
            return $"{Name}(ID: {HorseID}, DOB: {DateOfBirth.ToShortDateString()}";
        }

        public override bool Equals(object? obj)
        {
            return obj is Horse horse &&
                   horseID == horse.horseID &&
                   name == horse.name &&
                   dateOfBirth == horse.dateOfBirth &&
                   HorseID == horse.HorseID &&
                   Name == horse.Name &&
                   DateOfBirth == horse.DateOfBirth;
        }
    }
}

