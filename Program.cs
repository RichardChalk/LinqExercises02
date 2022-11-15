﻿//I följande uppgifter skall LINQ/LAMBDA användas för att göra urval från listor och
//arrayer. Ex bilar.Where(r=>r…..)

// ////////////////////////////////////////////////////////////////////////////
//BILAR
string[] cars = { "Volvo", "BMW", "Audi", "Skoda", "Toyota", "Ford", "Mercedes","Seat", "Honda", "Volkswagen","Opel", "Mazda","Suzuki" };

//a.Ta fram den första bilen som heter ”Opel” från arrayen. 
// Som bonus testar att skriva det så att den är case insensitive

Console.WriteLine("Bil A:");
Console.WriteLine(myOpel);
Console.WriteLine("---------------------------------");

// b. Ta fram alla bilar vars namn börjar på ”V”.

Console.WriteLine("Bil B:");
foreach (var car in carsStartingWithW)
{
    Console.WriteLine(car);
}
Console.WriteLine("---------------------------------");

// c. Ta fram alla bilar vars namn innehåller bokstäverna ”da”.

Console.WriteLine("Bil C:");
foreach (var car in carsContainingDA)
{
    Console.WriteLine(car);
}
Console.WriteLine("---------------------------------");

// d. Ta fram alla bilar som börjar på ”M” eller som slutar på ”i”

Console.WriteLine("Bil D:");
foreach (var car in carsStartingWithMEndingWithI)
{
    Console.WriteLine(car);
}
Console.WriteLine("---------------------------------");

// ////////////////////////////////////////////////////////////////////////////
// 2. BAND
string[] bands = { "ACDC", "Queen", "Aerosmith", "Iron Maiden", "Megadeth", "Metallica", "Pearl Jam", "Oasis", "Abba", "Blur", "Eurythmics", "Genesis", "INXS", "Midnight Oil", "Kent", "Madness", "Manic Street Preachers", "The Offspring", "Pink Floyd", "Rammstein", "Red Hot Chili Peppers", "Deep Purple", "U2"};

// a.Ta fram det band som har längst bandnamn
// HINT: First sort DESCENDING THEN take the first band in the list.... this will be the longest


Console.WriteLine("Band A:");
Console.WriteLine(longestBand);
Console.WriteLine("---------------------------------");

// b. Ta fram det band som har kortast bandnamn
// First sort ASCENDING THEN take the first band in the list.... this will be the longest


Console.WriteLine("Band B:");
Console.WriteLine(shortestBand);
Console.WriteLine("---------------------------------");

// c. Ta fram en siffra på hur många band som börjar på bokstaven ”M”
// Use WHERE & COUNT

// USE ONLY COUNT

Console.WriteLine("Band C:");
Console.WriteLine(startsWithM);
Console.WriteLine("---------------------------------");

// d. Visa bara band som har ett bandnamn som är längre än 6 bokstäver

Console.WriteLine("Band D:");
foreach (var band in longerThanSix)
{
    Console.WriteLine(band);
}
Console.WriteLine("---------------------------------");

// e. Skapa en lista som sorteras på längden på banden namn.
// Det band med kortast namn skall hamna först i listan och det med längst namn skall hamna sist


Console.WriteLine("Band E:");
foreach (var band in sortedList)
{
    Console.WriteLine(band);
}
Console.WriteLine("---------------------------------");

// ////////////////////////////////////////////////////////////////////////////
//LAMBDA
List<int> myIntegers = new List<int> { 54, 23, 76, 123, 93, 7, 3489, 88 };

//a.Ta fram medelvärdet av alla tal utan att loopa igenom listan.

Console.WriteLine("LAMBDA A:");
Console.WriteLine(findAverage);
Console.WriteLine("---------------------------------");

//b. Ta fram det största av alla tal utan att loopa igenom listan.

Console.WriteLine("LAMBDA B:");
Console.WriteLine(maxNum);
Console.WriteLine("---------------------------------");

//c. Ta fram det minsta av alla tal utan att loopa igenom listan.

Console.WriteLine("LAMBDA C:");
Console.WriteLine(minNum);
Console.WriteLine("---------------------------------");

//d. Beräkna summan av alla tal.

Console.WriteLine("LAMBDA D:");
Console.WriteLine(sum);
Console.WriteLine("---------------------------------");

//e. Ta fram alla jämna tal utan att loopa igenom listan

Console.WriteLine("LAMBDA E:");
foreach (var even in evens)
{
    Console.WriteLine(even);
}
Console.WriteLine("---------------------------------");

//F. Sortera på efternamn (SVÅR)
string[] namnLista = { "Karl Folkesson", "Sven Karlsson", "Greta Blom", "Richard E Chalk" };


Console.WriteLine("LAMBDA F:");
foreach (var name in sortedBySurname)
{
    Console.WriteLine(name);
}
Console.WriteLine("---------------------------------");

//G. NY LISTA
//Skapa en ny lista från denna array där alla värden ökats med 2 dvs nya listan blir 3,5,7,9
int[] intList = { 1, 3, 5, 7 };


Console.WriteLine("LAMBDA G:");
foreach (var num in newList)
{
    Console.WriteLine(num);
}
Console.WriteLine("---------------------------------");


//H. Skapa en lista med endast alla vokaler ur meningen (SVÅR)
string fullText = "Flygande Abeckasiner söka whila på mjuka tufvor";
char[] allVowels = new[] { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };

Console.WriteLine("LAMBDA H:");
foreach (var letter in vowelsDistinct)
{
    Console.WriteLine(letter);
}
Console.WriteLine("---------------------------------");





