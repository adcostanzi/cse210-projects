using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Goal Manager v1.0!\n");
        int menuOption = 0;
        int goalOption = 0;
        bool checker = false;
        GoalHandler handler = new GoalHandler();
        handler.LoadPossibleAchievements();
        do
        {
            do
            {
                handler.CheckAchievementCompletion();
                handler.DisplayScore();
                Console.WriteLine("\nMenu Options:\n");
                Console.WriteLine("1. Add goal");
                Console.WriteLine("2. Add goal completion");
                Console.WriteLine("3. Display goals");
                Console.WriteLine("4. Save goals");
                Console.WriteLine("5. Load goal");
                Console.WriteLine("6. Display achievements information");
                Console.WriteLine("7. Display your achievements");
                Console.WriteLine("8. Exit\n");
                Console.Write("Your choice: ");
                menuOption = int.Parse(Console.ReadLine());
                Console.WriteLine();
                if(menuOption < 1 || menuOption > 8)
                {
                    Console.WriteLine("Invalid option, please try again.");
                    checker = false;
                }
                else
                {
                    checker = true;
                }

            } while (checker == false);
            checker = false;
            if (menuOption == 1)
            {
                Console.WriteLine("\nGoal Options:\n");
                Console.WriteLine("1. Simple goal");
                Console.WriteLine("2. Eternal goal");
                Console.WriteLine("3. Checklist goal\n");
                Console.Write("Your choice: ");
                goalOption = int.Parse(Console.ReadLine());

                if (goalOption == 1)
                {
                    string goalName;
                    string goalDescription;
                    int goalPoints;
                    Console.Write("\nWhat is the name of you goal? ");
                    goalName = Console.ReadLine();
                    Console.Write("\nBriefly describe your goal: ");
                    goalDescription = Console.ReadLine();
                    Console.Write("\nHow many points should be given when goal is achieved? ");                        
                    goalPoints = int.Parse(Console.ReadLine());

                    SimpleGoal newSimpleGoal = new SimpleGoal(goalName, goalDescription, goalPoints);

                    handler.AddGoal(newSimpleGoal);

                }
                else if (goalOption == 2)
                {
                    string goalName;
                    string goalDescription;
                    int goalPoints;
                    Console.Write("\nWhat is the name of you goal? ");
                    goalName = Console.ReadLine();
                    Console.Write("\nBriefly describe your goal: ");
                    goalDescription = Console.ReadLine();
                    Console.Write("\nHow many points should be given every time this goal is achieved? ");                        
                    goalPoints = int.Parse(Console.ReadLine());

                    EternalGoal newEternalGoal = new EternalGoal(goalName, goalDescription, goalPoints);
                    
                    handler.AddGoal(newEternalGoal);
                }
                else if (goalOption == 3)
                {
                    string goalName;
                    string goalDescription;
                    int goalTimes;
                    int goalPointsPerTime;
                    int goalPoints;

                    Console.Write("\nWhat is the name of you goal? ");
                    goalName = Console.ReadLine();
                    Console.Write("\nBriefly describe your goal: ");
                    goalDescription = Console.ReadLine();
                    Console.Write("\nHow many times should this goal be acomplished to be completed? ");
                    goalTimes= int.Parse(Console.ReadLine());
                    Console.Write("\nHow many points should be given each time the goal is acomplished? ");                        
                    goalPointsPerTime = int.Parse(Console.ReadLine());
                    Console.Write("\nHow many bonus points should be given when goal is finally acomplished? ");                        
                    goalPoints = int.Parse(Console.ReadLine());


                    ChecklistGoal newChecklistGoal = new ChecklistGoal(goalName, goalDescription, goalPoints, goalPointsPerTime, goalTimes);
                    
                    handler.AddGoal(newChecklistGoal);
                }
            }
            else if (menuOption == 2)
            {
                int check = handler.GetGoalListLenght();
                if (check == 0)
                {
                    Console.WriteLine("No goals to display. Try adding a new goal.");
                }
                else
                {
                    int completedGoal = 0;
                    do
                    {
                        Console.WriteLine("Your goals: ");
                        handler.DisplayGoals();
                        Console.Write("What goal has been completed? ");
                        completedGoal = int.Parse(Console.ReadLine());
                        if (completedGoal <= 0  || completedGoal > check)
                        {
                            Console.WriteLine("\nInvalid option, please try again.\n");
                        }
                    } while (completedGoal <= 0 || completedGoal > check);
                    completedGoal --;
                    handler.AddGoalCompletion(completedGoal);
                }
                
            }
            else if (menuOption == 3)
            {
                Console.WriteLine("Your goals: ");
                handler.DisplayGoals();
            }
            else if (menuOption == 4)
            {
                Console.Write("What is the name of the file to save? ");
                string filename = Console.ReadLine() + ".txt";
                handler.SaveFile(filename);
            }
            else if (menuOption == 5)
            {
                Console.Write("What is the name of the file to load? ");
                string filename = Console.ReadLine() + ".txt";
                handler.LoadFile(filename);
            }
            else if (menuOption == 6)
            {
                handler.DisplayAchievementsInfo();
            }
            else if (menuOption == 7)
            {
                handler.DisplayCompleteAchievements();
            }

        
        } while (menuOption != 8);
    }
}