using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;


namespace MusicLINQ
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Collections to work with
            List<Artist> Artists = JsonToFile<Artist>.ReadJson();
            List<Group> Groups = JsonToFile<Group>.ReadJson();

            //=========================================================
            //Solve all of the prompts below using various LINQ queries
            //=========================================================

            //=========================================================
            //There is only one artist in this collection from Mount 
            //Vernon. What is their name and age?
            //=========================================================
            var FindArtistInVernon = Artists.Where(a => a.Hometown == "Mount Vernon");
                foreach(var artist in FindArtistInVernon)
                {
                     Console.WriteLine("Name: {0} " + "\n" + "Age: {1}" + "\n" + "Hometown: {2}", artist.RealName, artist.Age, artist.Hometown);
                }
            //=========================================================
            //Who is the youngest artist in our collection of artists?
            //=========================================================
            var FindMinAge = Artists.OrderBy(a => a.Age).Take(1);
                foreach (var match in FindMinAge)
                {
                    System.Console.WriteLine(match.Age);
                }
           
            //=========================================================
            //Display all artists with 'William' somewhere in their 
            //real name        
            //=========================================================
            var FindWilliam = Artists.Where(a => a.RealName.Contains("William"));

                foreach(var match in FindWilliam)
                {
                    System.Console.WriteLine(match.RealName);
                }

            //=========================================================
            //Display all groups with names less than 8 characters
            //=========================================================
            var Group8Char = Groups.Where(g => g.GroupName.Length < 8);            
                foreach (var match in Group8Char)
                {
                    System.Console.WriteLine(match.GroupName);
                }
            //=========================================================
            //Display the 3 oldest artists from Atlanta
            //=========================================================
            var AtlantaArtists = Artists.Where(a => a.Hometown == "Atlanta").OrderByDescending(a => a.Age).Take(3);
                foreach (var artist in AtlantaArtists)
                {
                   System.Console.WriteLine("Name: {0} " + "\n" + "Age: {1}" + "\n" + "Hometown: {2}", artist.RealName,  artist.Age, artist.Hometown);
                }

            //=========================================================
            //(Optional) Display the Group Name of all groups that have 
            //at least one member not from New York City
            //=========================================================

            //=========================================================
            //(Optional) Display the artist names of all members of the 
            //group 'Wu-Tang Clan'
            //=========================================================
        }
    }
}
