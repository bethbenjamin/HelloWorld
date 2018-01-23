using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {

            ////part one greeting statement
            //string messageOne = "Hello World";
            //string messageTwo = "i am sparticus";

            ////// part two set initial Sparticus attributes
            //int ageOne = 35;
            //int ageTwo = 45;
            //int ageThree = 80;
            //double heightOne = 72.50;
            //double heightTwo = 91.45;
            //float weightOne = 210.0284606f;
            //float weightTwo = 331.12345678f;
            //bool isGodLikeOne = true;
            //bool isGodLikeTwo = false;
            //char genderMale = 'M';
            //char genderFemale = 'F';



            //// Part Three display variable values
            //Console.WriteLine(messageOne);
            //Console.WriteLine(messageTwo);


            //// Part Four is Mathematical operator, bool and char
            //Console.WriteLine(weightOne * weightTwo);
            //Console.WriteLine(weightOne * weightTwo);
            //Console.WriteLine(heightOne - heightTwo);
            //Console.WriteLine(heightOne - heightTwo);
            //Console.WriteLine(ageOne + ageTwo);
            //Console.WriteLine(isGodLikeOne);
            //Console.WriteLine(genderMale);

            ////Part five variable reassignment
            //ageTwo = 70;
            //heightTwo = 35.12345f;
            //weightTwo = -429.1234573f;


            ////Part 6 mathematical operator examples
            //Console.WriteLine(5 % 2);
            //Console.WriteLine(ageTwo / ageOne);
            //Console.WriteLine(ageTwo % ageOne);
            //Console.WriteLine(ageThree / ageOne);
            //Console.WriteLine(ageThree % ageOne);
            //ageTwo++;
            //Console.WriteLine(ageTwo);
            //ageTwo--;
            //Console.WriteLine(ageTwo);


            ////Part 7
            //Console.WriteLine("5" == "5");
            //Console.WriteLine(40 != 40);
            //Console.WriteLine(11 < 4);

            ////Part 8 Concatenation Example
            //Console.WriteLine(messageOne + "!" +  messageTwo + ".");
            //Console.WriteLine(messageOne + "!" + messageTwo + ".");
            //Console.WriteLine("I am  {0}  years old, and yes it's  {1} i am godlike.",ageOne, isGodLikeOne);
            //Console.WriteLine("I weigh around {0} pounds, and I am around {1} inches tall.", weightOne, heightOne);

            //// Part 9 string equality examples
            //Console.WriteLine(messageTwo.Equals(messageOne));
            //Console.WriteLine(messageTwo.Equals("i am sparticus"));

            //string myGreeting = "Hello";
            //Console.WriteLine(myGreeting.ToUpper()); // prints "HELLO"
            //Console.WriteLine(myGreeting.ToLower()); // prints "hello"
            //Console.WriteLine(myGreeting); // prints "Hello"

            //// Part 10 String Length Examples
            //int messOneLength = messageOne.Length;
            //int messTwoLength = messageTwo.Length;

            //Console.WriteLine("the lenght of messageOne is " + messageOne.Length);
            //Console.WriteLine("the lenght of messageTwo is " + messageTwo.Length);
            //Console.WriteLine("the lenght of messageOne is " + messOneLength);
            //Console.WriteLine("the lenght of messageTwo is " + messTwoLength);


            ////example from slack produces same 11/14
            //int messOneLength = messageOne.Length;
            //int messTwoLength = messageTwo.Length;

            //Console.WriteLine("The length of messageOne is " + messageOne.Length);
            //Console.WriteLine("The length of messageTwo is " + messageTwo.Length);
            //Console.WriteLine("The length of messageOne is " + messOneLength);
            //Console.WriteLine("The length of messageTwo is " + messTwoLength);

            //// Part 11 IF THEN Statements
            //string city1 = "Vesuvious";
            //string city2 = "Nola";
            //string city3 = "Nuceria";

            //int cityDistance1, cityDistance2, cityDistance3;

            ////user asked to add distance information
            ////this line is defined by indexing
            //Console.WriteLine("What's the distance to {0}?", city1);  
            //cityDistance1 = int.Parse(Console.ReadLine());
            ////this line is defined by concatination
            //Console.WriteLine("what is the distance to " + city2 + "?");
            //cityDistance2 = int.Parse(Console.ReadLine());
            //// this line is defined by string
            //Console.WriteLine("What is the distance to Nuceria?");
            //cityDistance3 = int.Parse(Console.ReadLine());

            //if ((cityDistance1 <= 125) && ((cityDistance1 < cityDistance2) && (cityDistance1 < cityDistance3)))

            //{
            //    Console.WriteLine("We will march to Vesuvious");
            //}

            //if ((cityDistance2 <= 125) && ((cityDistance2 < cityDistance1) && (cityDistance2 < cityDistance3)))

            //{
            //    Console.WriteLine("We will march to Vesuvious");
            //}

            //if ((cityDistance3 <= 125) && ((cityDistance3 < cityDistance1) && (cityDistance3 < cityDistance2)))
            //{
            //    Console.WriteLine("We will march to Nuceria");
            //}

            // Part 12 IF ELSE statements

            //Console.WriteLine("What is your rank soldier?");
            //string rank = Console.ReadLine();

            //Console.WriteLine("What is your age soldier?");
            //int age = int.Parse(Console.ReadLine());

            //Console.WriteLine("what is your job soldier?");
            //string job = Console.ReadLine();

            ////if statement reads if the rank of the officer is officer OR you are greater or equal to age 26 then return the statement
            //if ((rank == "officer") || (age <= 26))
            //{
            //    Console.WriteLine("get your gear, kiss your family goodbye, put on your marching boots.");
            //}

            ////Else if statement reads If the results are true, the THEN instructions are taken; if not, the ELSE instructions are taken. 

            //// ask PETE // how did we get this to return this statement
            //else if ((job == "cook") && (age >= 26))
            //{
            //    Console.WriteLine("My army has to eat. Pack your pots and pans");
            //}
            //else
            //{
            //    Console.WriteLine("sorry you are staying at home");
            //}

            //string input = Console.ReadLine().ToLower();  //take input to user and set it to uppercase


            //string transportation = "";
            //string input = Console.ReadLine().ToUpper();
            //switch (input)
            //{
            //    case "help":
            //        Console.Write("Here are the weapons you can carry");
            //        Console.Write("Sword");
            //        Console.Write("Bow and arrow");
            //        Console.Write("Knife");
            //        Console.Write("Please choose a weapon from the menu listed above");
            //        transportation = Console.ReadLine().ToUpper();
            //        break;
            //    case "red":
            //        Console.WriteLine("You have chosen red, ");
            //        transportation = "red car is ";
            //        break;
            //    case "supply":
            //        Console.WriteLine("You will carry pots and pans");
            //        weapon = "pots and pans";
            //        break;

            //    case "specialist":
            //        Console.WriteLine("You will operate the catapault");
            //        weapon = "catapault";
            //        break;
            //    default:
            //        Console.WriteLine("You did not select the proper weapon");
            //        Console.Write("Please choose a weapon");
            //        weapon = Console.ReadLine().ToUpper();
            //        break;
            //}

            //switch (input)
            //{
            //    case "help":
            //        Console.WriteLine("help menu: explain what roygbiv is");
            //    break;

            //    case "red":
            //        Console.WriteLine("set global variable of transportation to this location"); 
            //    break;

            //    case "orange":
            //        Console.WriteLine("You will carry pots and pans");
            //    break;

            //    case "yellow":
            //        Console.WriteLine("You will operate a catapult");
            //        break;
            //    case "green":
            //        Console.WriteLine("set global variable of transportation to this location");
            //        break;
            //    case "blue":
            //        Console.WriteLine("set global variable of transportation to this location");
            //        break;
            //    case "indigo":
            //        Console.WriteLine("set global variable of transportation to this location");
            //        break;
            //    case "violet":
            //        Console.WriteLine("set global variable of transportation to this location");
            //        break;
            //    default:
            //        Console.WriteLine("You didn't choose help or a valid ROYGBIV color.");
            //        break;
            //}






            ////1.items: cups of sugar - cups already in = result. 7 - 2 = 5
            ////2.items: bill = 13 * 4.  13 * 4 = 52
            ////3.items: diapers cost $8.00 divided by $40 = 5
            ////4.items: wallet has $29 plus x = $41. $41 -$29 =$12 for cleaning attic

            //// 5.items: miles more than pranav. 47 - 30 = 17

            //// 6.items: envelopes = $3 / $12

            //// 7.items: salad plus $27.10 = 33.22.  5.12 + 27.10 = 33.22


            //// int total;
            ////double norachi = 27.10;
            ////double saladcost = 5.12;
            ////total = (7 - 2);
            ////Console.WriteLine("1. Cups of sugar "+total);
            ////total = (13 * 4);
            ////Console.WriteLine("2. If each person paid $13 the bill would be  " + total);
            ////total = (40 / 8);
            ////Console.WriteLine("3. Packages of diapers they could buy are " +total);
            ////total = (47 - 30);
            ////Console.WriteLine("4. Pranav only ran " + total);
            ////total = (12 / 3);
            ////Console.WriteLine("5. Envelopes = " +total);
            ////Console.WriteLine(norachi + saladcost);

            //////im going to try it a different way that way seems too straight forward

            ////double x = 0.00;
            ////Console.WriteLine(x + 7 - 2);
            ////Console.WriteLine(x + 13 * 4);
            ////Console.WriteLine(x + 40 / 8);
            ////Console.WriteLine(x + 41 - 29);
            ////Console.WriteLine(x + 47 - 30);
            ////Console.WriteLine(x + 12 / 3);
            ////Console.WriteLine(x + 27.10 + 5.12);
            //Part 13 WHILE LOOPING example

            //string action = " "; //declared a string variale action
            //while (action != "exit")// action is NOT equal to exit
            //{
            //    Console.WriteLine("What is your rank soldier?");
            //    string rank = Console.ReadLine();

            //    Console.WriteLine("What is your age soldier?");
            //    int age = int.Parse(Console.ReadLine());
            //    Console.WriteLine("What is your job soldier?");
            //    string job = Console.ReadLine();

            //    if ((rank == "officer") || (age <= 26))
            //    {
            //        Console.WriteLine("Get your gear, kiss your family goodbye, put on your marching boots.");
            //    }
            //    else if ((job == "cook") || (age >= 26))
            //    {
            //        Console.WriteLine("My army has to eat. Pack your pots and pans");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Sorry you are staying home.");
            //    }
            //    Console.WriteLine("Add another? Type exit to quit");
            //    action = Console.ReadLine(); //assigning variable to action

            //}

            // Food List array
            string[] foodList = new string[5]; //food list array
            foodList[0] = "Milk";
            foodList[1] = "Fruit";
            foodList[2] = "Meat";
            foodList[3] = "Wine";
            foodList[4] = "Bread";
            int[] foodAmount = new int[5]; //food int array
            foodAmount[0] = 1000;
            foodAmount[1] = 100;
            foodAmount[2] = 2000;
            foodAmount[3] = 10000;
            foodAmount[4] = 1500;

            // for loop example
            for (int i = 0; i < foodAmount.Length; i++)
            {
                Console.WriteLine("Please enter a value for " +foodList [i]);
                foodAmount[i] = int.Parse(Console.ReadLine());
            }

            //Console.WriteLine("{0}, {1}, {2}, {3}. {4}.", foodList[0], foodList[1], foodList[2], foodList[3], foodList[4]);

            //Console.WriteLine("{0}, {1}, {2}, {3}. {4}.", foodAmount[0], foodAmount[1], foodAmount[2], foodAmount[3], foodAmount[4]);
            //Console.WriteLine(foodList[0] + ": " + foodAmount[0] + ", " + foodList[1] + ": " + foodAmount[1] + ", " + foodList[2] + ": "
            //    + foodAmount[2] + ", " + foodList[3] + ": " + foodAmount[3] + ", " + foodList[4] + ": " + foodAmount[4]);
            //Console.WriteLine(foodList.Length);
            //string[] elements = messageTwo.Split(' ');
            //Console.WriteLine(elements[0]);
            //Console.WriteLine(elements[1]);
            //Console.WriteLine(elements[2]);

            //    // Part 14 DO WHILE LOOP EXAMPLE

            //    string action = " ";
            //    do// tells compiler we're entering a loop and "do it once"

            //    {
            //        Console.WriteLine("What is your rank soldier?");
            //        string rank = Console.ReadLine();

            //        Console.WriteLine("What is your age soldier?");
            //        int age = int.Parse(Console.ReadLine());
            //        Console.WriteLine("What is your job soldier?");
            //        string job = Console.ReadLine();

            //        if ((rank == "officer") || (age <= 26))
            //        {
            //            Console.WriteLine("Get your gear, kiss your family goodbye, put on your marching boots.");
            //        }
            //        else if ((job == "cook") || (age >= 26))
            //        {
            //            Console.WriteLine("My army has to eat. Pack your pots and pans");
            //        }
            //        else
            //        {
            //            Console.WriteLine("Sorry you are staying home.");
            //        }
            //        Console.WriteLine("Add another? Type exit to quit");
            //        action = Console.ReadLine();
            //    } while (action != "exit");
            //}
        }
    }
}
