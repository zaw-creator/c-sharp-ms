using System;

// initialize variables - graded assignments 
int currentAssignments = 5;
int[] sophiaScore = [90, 86, 87, 98, 100];
int[] andrewScore = [92, 89, 81, 96, 90];
int[] emmaScore = [90, 85, 87, 98, 68];
int[] loganScore = [90, 95, 87, 88, 96];
string[] studentNames = { "Sophia", "Andrew", "Emma", "Logan" };

int sophiasum = 0;

decimal sophiascore;

foreach (int score in sophiaScore)
{
    sophiasum += score;
}

sophiascore = (decimal)sophiasum / currentAssignments;

Console.WriteLine("Student\t\tGrade\n");
Console.WriteLine("Sophia:\t\t" + sophiaScore + "\tA-");

Console.WriteLine("Press the Enter key to continue");
Console.ReadLine();









