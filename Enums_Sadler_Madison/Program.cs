// See https://aka.ms/new-console-template for more information
// System.Data namespace needed to use Console class
using System.Data;

// Creates an integer called myBirthMonth and sets it to Months.Oct
int myBirthMonth = (int)Months.Oct;
// Creates an integer called myBirthDay and sets it to 17
int myBirthDay = 17;
// Creates an integer called myBirthYear and sets it to 2005
int myBirthYear = 2005;

// Creates a string called myBirthDate and sets it to the text "My birthday is on birth month inputted (Oct)/birth day inputted (17)/birth year inputted (2005)."
string myBirthDate = $"My birthday is on {myBirthMonth}/{myBirthDay}/{myBirthYear}.";

// Creates a file called myFile.txt and adds the text "This is my text file!" to the file
File.WriteAllText("myFile.txt", "This is my text file!\n");
// Prints to the console what is on the file myFile.txt
Console.WriteLine(File.ReadAllText("myFile.txt"));

// Appends text to myFile.txt and adds the text "WooHoo more text added to file!"
File.AppendAllText("myFile.txt", "WooHoo more text added to file!\n");
// Prints to the console what is on the file myFile.txt
Console.WriteLine(File.ReadAllText("myFile.txt"));

// Creates an if else statement
// Copies myFile.txt to a new file called newFile.txt if the new file does not exist
if (!File.Exists("newFile.txt"))
{
    File.Copy("myFile.txt", "newFile.txt");
}
// Replaces the file with myFile.txt if the new file does exist
else
{
    File.Replace("myFile.txt", "newFile.txt", "backupFile.txt");
}

// Appends the myBirthDate string to newFile.txt
File.AppendAllText("newFile.txt", myBirthDate);
// Prints to console what is on newFile.txt
Console.WriteLine(File.ReadAllText("newFile.txt"));

// Creates a global enum called Months that goes from Jan to Dec
// Sets Jan to 1
enum Months
{
    Jan = 1,
    Feb,
    Mar,
    Apr,
    May,
    Jun,
    Jul,
    Aug,
    Sep,
    Oct,
    Nov,
    Dec
}