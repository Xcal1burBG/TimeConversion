using System.Linq;
using System;

class Result
{

    /*
     * Complete the 'timeConversion' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts STRING s as parameter.
     */

    public static string timeConversion(string s)
    {
        string time = s.Substring(0, 8);
        string partOfTheDay = s.Substring(8, 2);
        string hoursAsString = s.Substring(0, 2);
        string minutesAsString = s.Substring(3, 2);
        string secondsAsString = s.Substring(6, 2);

        int hours = int.Parse(hoursAsString);

        if (hoursAsString == "12" && partOfTheDay == "AM")
        {
            hours -= 12;
        }

        if (hours >= 1 && hours <= 11 && partOfTheDay == "PM")
        {
            hours += 12;
        }

        if (hours >= 0 && hours <= 9)
        {
            hoursAsString = $"0{hours}";
        }

        if (hours > 9)
        {
            hoursAsString = hours.ToString();
        }

        return $"{hoursAsString}:{minutesAsString}:{secondsAsString}";
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        string s = Console.ReadLine();

        string result = Result.timeConversion(s);

        Console.WriteLine(result);


    }
}
