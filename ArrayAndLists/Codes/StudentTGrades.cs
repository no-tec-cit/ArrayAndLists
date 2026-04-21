using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayAndLists.Codes;

internal class StudentTGrades
{
    public static void ShowStudentGradesTable_FirstIteration()
    {
        // Students array
        string[] rows = { "Elev1", "Elev2", "Elev3", "Elev4", "Elev5", "Elev6", "Elev7", "Elev8", "Elev9", "Elev10", "Elev11", "Elev12", "Elev13", "Elev14", "Elev15" };
        
        // Subjects array
        string[] columns = { "Gr.prog.", "Com.teknologi", "OOP", "Databaseprog.", "Databaseserver", "Clientsideprog." };

        // Grades 2D array
        int[,] grades = new int[rows.Length, columns.Length];

        // Gr.prog.         Com.teknologi       OOP                 Databaseprog.       Databaseserver      Clientsideprog.
        grades[0, 0] = 02; grades[0, 1] = 10; grades[0, 2] = 7; grades[0, 3] = 12; grades[0, 4] = 10; grades[0, 5] = 4;
        grades[1, 0] = 02; grades[1, 1] = 2; grades[1, 2] = 10; grades[1, 3] = 7; grades[1, 4] = 10; grades[1, 5] = 12;
        grades[2, 0] = 02; grades[2, 1] = 10; grades[2, 2] = 12; grades[2, 3] = 4; grades[2, 4] = 2; grades[2, 5] = 7;
        grades[3, 0] = 02; grades[3, 1] = 7; grades[3, 2] = 4; grades[3, 3] = 10; grades[3, 4] = 12; grades[3, 5] = 10;
        grades[4, 0] = 02; grades[4, 1] = 12; grades[4, 2] = 10; grades[4, 3] = 7; grades[4, 4] = 10; grades[4, 5] = 4;
        grades[5, 0] = 02; grades[5, 1] = 4; grades[5, 2] = 7; grades[5, 3] = 10; grades[5, 4] = 12; grades[5, 5] = 10;
        grades[6, 0] = 02; grades[6, 1] = 7; grades[6, 2] = 12; grades[6, 3] = 4; grades[6, 4] = 2; grades[6, 5] = 7;
        grades[7, 0] = 02; grades[7, 1] = 10; grades[7, 2] = 7; grades[7, 3] = 0; grades[7, 4] = 10; grades[7, 5] = 12;
        grades[8, 0] = 02; grades[8, 1] = 02; grades[8, 2] = 10; grades[8, 3] = 7; grades[8, 4] = 4; grades[8, 5] = 10;
        grades[9, 0] = 02; grades[9, 1] = 12; grades[9, 2] = 12; grades[9, 3] = 10; grades[9, 4] = 7; grades[9, 5] = 4;
        grades[10, 0] = 02; grades[10, 1] = 12; grades[10, 2] = 12; grades[10, 3] = 10; grades[10, 4] = 12; grades[10, 5] = 4;
        grades[11, 0] = 02; grades[11, 1] = 4; grades[11, 2] = 12; grades[11, 3] = 10; grades[11, 4] = 4; grades[11, 5] = 4;
        grades[12, 0] = 02; grades[12, 1] = 12; grades[12, 2] = 7; grades[12, 3] = 7; grades[12, 4] = 10; grades[12, 5] = 7;
        grades[13, 0] = 02; grades[13, 1] = 7; grades[13, 2] = 02; grades[13, 3] = 12; grades[13, 4] = 7; grades[13, 5] = 4;
        grades[14, 0] = 02; grades[14, 1] = 12; grades[14, 2] = 12; grades[14, 3] = 4; grades[14, 4] = 4; grades[14, 5] = 10;

        // ---------------------------
        // Udskrivning af tabellen
        // ---------------------------
        // *** Udskriv Kolonne
        Console.Write("".PadRight(15));
        for (int j = 0; j < columns.Length; j++)
            Console.Write(columns[j].PadRight(15));
        
        // *** Udskriv Række
        Console.WriteLine();
        for(int i = 0; i< rows.Length; i++)
        {
            Console.Write(rows[i].PadRight(15));

            for(int j=0;j< columns.Length; j++)
            {
                if(grades[i, j] == 02)
                    Console.Write(grades[i, j].ToString("D2").PadRight(15));
                else
                    Console.Write(grades[i, j].ToString().PadRight(15));
            }

            Console.WriteLine();
        }
        // ---------------------------
    }
}
