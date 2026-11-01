using DateModifier;
using System.Globalization;

DateTime firstDate = DateTime.ParseExact(Console.ReadLine()
    , "yyyy MM dd"
    , CultureInfo.InvariantCulture);

DateTime secondDate = DateTime.ParseExact(Console.ReadLine()
    , "yyyy MM dd"
    , CultureInfo.InvariantCulture);


int differenceInDays = DateCalculator.GetDaysBetween(firstDate, secondDate);

Console.WriteLine(differenceInDays);