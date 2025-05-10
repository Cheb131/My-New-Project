using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.IO.Pipes;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace ListExample
{



    public enum Color
    {
        Red = 0,
        Blue = 1,
        Green = 2,
        Yellow = 3,
        White = 4,
    }

    public class House
    {

        public string name;
        public int numberPerson;
        public string addhouse;
        public Color color;

        public House(string namex, int numberPersonx, string addhousex, Color colorx)
        {
          
            name = namex;
            numberPerson = numberPersonx;
            addhouse = addhousex;
            color = colorx;
        }

    }
    public class Test
    {
        static Dictionary<int, Dictionary<Color, List<House>>> dictFinal = new Dictionary<int, Dictionary<Color, List<House>>>();
       


        public static List<House> AddNewHouses()
        {
            List<House> test = new List<House>
            {
                new House("h1",3,"abc",Color.Red),
                new House("h2",2,"abc",Color.Blue),
                new House("h3",3,"abc",Color.Red),
                new House("h4",4,"abc",Color.Blue),
                new House("h5",5,"abc",Color.Red),
                new House("h6",6,"abc",Color.Blue),
                new House("h7",6,"abcD",Color.Red),
                new House("h8",6,"abcDe",Color.Red),


            };
            return test;
        }

        public static void Main(string[] args)
        {           

            // Dictionary
            Console.WriteLine("Dictionary");

            List<House> listHouseMyDinh = AddNewHouses();       
            foreach (var house in listHouseMyDinh)
            {
                
                int number = house.numberPerson;


                if (dictFinal.ContainsKey(number)) 
                {
                    AddHouseToDictByColor(house, dictFinal[number]);
                }
                else 
                {
                    Color color = house.color;
                  
                    Dictionary<Color, List<House>> dictChild = new Dictionary<Color, List<House>>();
                    AddHouseToDictByColor(house, dictChild);
                    dictFinal.Add(number, dictChild); 
                }
            }

            FindListHouse(6, Color.White);


        }


        public static void FindListHouse(int number, Color color)
        {
            if (!dictFinal.ContainsKey(number))
            {
                Console.WriteLine("khong tim dc");
                return;
            }
            var childDict = dictFinal[number];
            if (!childDict.ContainsKey(color))
            {
                Console.WriteLine("khong tim dc");
                return;
            }
            var listHouse = childDict[color];
            foreach (var house in listHouse)
            {
                Console.WriteLine("house" + house.name);
            }
        }


        public static void AddHouseToDictByColor(House house, Dictionary<Color, List<House>> childDict)
        {
            Color color = house.color;
            if (childDict.ContainsKey(color))
            {
                childDict[color].Add(house);
            }
            else
            {
                childDict.Add(color, new List<House> { house });

            }
        }

}

