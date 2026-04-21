using ArrayAndLists.Codes;

//string[] array = new[] { "Niels", "Mads", "Søren", "Lars" };

//// Looper en array
//foreach (var item in array)
//{
//    Console.WriteLine(item);
//}

//// Finder element i array
//var ismatched = array.ToList().FirstOrDefault(x => x == "Susamme");
//if (ismatched != null)
//    Console.WriteLine("item er fundet");
//else
//    Console.WriteLine("item er ikke fundet");

//// Finder index i array
////var index = Array.FindIndex(array, x => x == "Niels");
//var index2 = Array.IndexOf(array, "Niels");
//Console.WriteLine($"item fundet i index {index2}");

////Manipuler index
//array[0] = "Mathias";
//foreach (var item in array)
//{
//    Console.WriteLine(item);
//}

//// Konverter til List
//List<string> ss = array.ToList();

//// -------------------------------------------------------
//// 2D array
//// -------------------------------------------------------
//Console.WriteLine();

//string[,] result = new string[2, 2]
//{
//    { "Row1-Col1", "Row1-Col2" },
//    { "Row2-Col1", "Row2-Col2" }
//};

//// GetLength(0)
//// GetLength(1)
//for (int i = 0; i < result.GetLength(0); i++)
//{
//    for (int j = 0; j < result.GetLength(1); j++)
//    {
//        Console.WriteLine(result[i, j]);
//    }
//}

//// Find en værdi i array
//bool exist = result.Cast<string>().Any(x => x == "ddd");
//Console.WriteLine(exist ? "Item exist." : "Item does not exist.");

//// Get index value of an item
//int foundRow = -1;
//int foundCol = -1;
//for (int i = 1; i < result.GetLength(0); i++)
//{
//    for (int j = 0; j < result.GetLength(1); j++)
//    {
//        if (result[i, j] == "Row2-Col2")
//        {
//            foundRow = i;
//            foundCol = j;
//            break;
//        }
//    }

//    if (foundRow != -1) break;
//}
//Console.WriteLine($"Item found at index {foundRow}, {foundCol}");

////Manipuler index
//result[1, 1] = "Mathias";
//for (int i = 0; i < result.GetLength(0); i++)
//{
//    for (int j = 0; j < result.GetLength(1); j++)
//    {
//        Console.WriteLine(result[i, j]);
//    }
//}

// --------------------------------------------------------
//StudentTGrades.ShowStudentGradesTable_FirstIteration();

string[] TECHovedForløb = new string[] { "H1", "H2", "H3", "h4", "H5", "H6" };

string[][] subjects = new string[][]
{
    new string[] { "Grundlæggendeprogrammering", "OOP", "Computerteknologi", "Clientside programmering", "Database programmering" },
    new string[] { "OOP 2", "GUI", "Netværk", "Database 2", "LINQ" },
    new string[] { "Embedded", "IoT Embedded", "Database 3", "GUI", "Serverside programmering" },
    new string[] { "Linux Embedded", "IoT Linux Embedded", "Software sikkerhed og test", "Kryptografi" },
    new string[] { "Apps", "BigData", "Python" },
    new string[] { "Svendprøve" }
};

for (int i = 0; i < subjects.Length; i++)
{
    Console.WriteLine(TECHovedForløb[i]);

    for (int j = 0; j < subjects[i].Length; j++)
        Console.WriteLine(" - " + subjects[i][j]);
}

bool exist = subjects.SelectMany(x => x).Contains("LINQ");
Console.WriteLine(exist ? "Item exist." : "Item does not exist.");

int row = -1;
int col = -1;
for (int i = 0; i < subjects.Length; i++)
{
    for (int j = 0; j < subjects[i].Length; j++)
    {
        if (subjects[i][j] == "LINQ")
        {
            row = i;
            col = j;
            break;
        }        
    }

    if (row != -1) break;
}
Console.WriteLine($"Fundet i index: {row}, {col}");

subjects[1][4] = "MongoDB";
for (int i = 0; i < subjects.Length; i++)
{
    Console.WriteLine(TECHovedForløb[i]);

    for (int j = 0; j < subjects[i].Length; j++)
        Console.WriteLine(" - " + subjects[i][j]);
}

Console.ReadLine();