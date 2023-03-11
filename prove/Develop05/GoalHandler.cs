public class GoalHandler
{
    private List<Goal> _listOfGoals = new List<Goal>();

    private List<Achievement> _listOfAchievements = new List<Achievement>();

    private List<Achievement> _completedAchievements = new List<Achievement>();

    private int _yourPoints = 0;

    private int _yourLevel = 1;


    public GoalHandler()
    {

    }

    public int GetGoalListLenght()
    {
        return _listOfGoals.Count();
    }
    public void DisplayGoals()
    {
        int counter = 1;
        foreach (Goal listedGoal in _listOfGoals)
        {
            Console.Write($"{counter}. ");
            listedGoal.DisplayGoal();
            counter ++;
        }
    }


    public void AddGoal(Goal newGoal)
    {
        _listOfGoals.Add(newGoal);
    }

    public void DisplayScore()
    {
        if (_yourLevel >= 11)
        {
            Console.WriteLine($"\nYou are a GOAL MASTER and your score is {_yourPoints}");
        }
        else
        {
            Console.WriteLine($"\nYou are level {_yourLevel} and your score is {_yourPoints}");
        }
        
    }

    public void AddGoalCompletion(int index)
    {
        _yourPoints = _yourPoints + _listOfGoals[index].CompleteGoal();;
    }

    public void SaveFile(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
           outputFile.WriteLine(_yourLevel + "&" + _yourPoints);

           foreach (Goal listedGoal in _listOfGoals)
           {
                outputFile.WriteLine(listedGoal.SaveGoalAsString());
           }   

           foreach (Achievement achievement in _completedAchievements)
           {
                outputFile.WriteLine(achievement.SaveAchievementAsString());
           }      
        }
    }

    public void LoadFile(string filename)
    {
        string[] lines = System.IO.File.ReadAllLines(filename);

        string[] firstLine = lines[0].Split("&");
        int level = int.Parse(firstLine[0]);
        int points = int.Parse(firstLine[1]);
        
        _yourLevel = level;
        _yourPoints = points;


        for (int i = 1; i <= lines.Count()-1; i++)
        {
            string[] parts = lines[i].Split("&");

            if (parts[0] == "SimpleGoal")
            {
                string name = parts[1];
                string description = parts[2];
                int goalPoints = int.Parse(parts[3]);
                SimpleGoal newGoal = new SimpleGoal(name, description, goalPoints);
                if (parts[4] == "True")
                {
                    newGoal.ChangeToCompleteStatus();
                }

                _listOfGoals.Add(newGoal);
            }
            else if (parts[0] == "EternalGoal")
            {
                string name = parts[1];
                string description = parts[2];
                int goalPoints = int.Parse(parts[3]);
                EternalGoal newGoal = new EternalGoal(name, description, goalPoints);
                if (parts[4] == "True")
                {
                    newGoal.ChangeToCompleteStatus();
                }
                _listOfGoals.Add(newGoal);
            }
            else if (parts[0] == "ChecklistGoal")
            {
                string name = parts[1];
                string description = parts[2];
                int goalPoints = int.Parse(parts[3]);
                int bonusPoints = int.Parse(parts[4]);
                int times = int.Parse(parts[5]);
                int status = int.Parse(parts[6]);
                ChecklistGoal newGoal = new ChecklistGoal(name, description, goalPoints, bonusPoints, times, status);
                if (parts[7] == "True")
                {
                    newGoal.ChangeToCompleteStatus();
                }
                _listOfGoals.Add(newGoal);
            }
            else if (parts[0] == "Achievement")
            {
                int savedLevel = int.Parse(parts[1]);
                string description = parts[2];
                int limit = int.Parse(parts[3]);
                int bonus = int.Parse(parts[4]);
                bool status = false;
                if (parts[5] == "True")
                {
                    status = true;
                } 
                else if (parts[5] == "False")
                {
                    status = false;
                }
                Achievement newAchievement = new Achievement(savedLevel, description, limit, bonus, status);
                _completedAchievements.Add(newAchievement);
            }
        }
        for (int i = 0; i <= _completedAchievements.Count-1; i++)
        {
            bool check = _completedAchievements[i].IsComplete();
            if (check == true)
            {
                _listOfAchievements[i].CompleteStatus();
            }
        }
    }

    public void LoadPossibleAchievements()
    {
         string[] lines = System.IO.File.ReadAllLines("Achievements.txt");

         foreach (string line in lines)
         {
            string[] parts = line.Split("&");

            int level = int.Parse(parts[0]);

            string description = parts[1];

            int limit = int.Parse(parts[2]);

            int bonus = int.Parse(parts[3]);

            Achievement newAchievement = new Achievement(level, description, limit, bonus);

            _listOfAchievements.Add(newAchievement);
         }
    }

    public void CheckAchievementCompletion()
    {
        foreach (Achievement achievement in _listOfAchievements)
        {
            bool isAchievementComplete = achievement.IsComplete();
            if (isAchievementComplete == false)
            {
                bool check = achievement.CheckLimit(_yourPoints);
                if (check == true)
                {
                    string level = achievement.GetLevel();
                    Console.WriteLine($"\nLevel {level} completed! Congratulations!");
                    _yourLevel ++;
                    int bonusPoints = achievement.GetBonusPoints();
                    Console.WriteLine($"\nYou have now earned {bonusPoints} bonus points!");
                    _yourPoints = _yourPoints + bonusPoints;
                    _completedAchievements.Add(achievement);
                }
            }
        }
    }

    public void DisplayAchievementsInfo()
    {
        foreach (Achievement achievement in _listOfAchievements)
        {
            achievement.DisplayAchievement();
        }
    }

    public void DisplayCompleteAchievements()
    {
        foreach (Achievement achievement in _listOfAchievements)
        {
            bool check = achievement.DisplayAchievementOption7();
            if (check == false)
            {
                int limit = achievement.GetLimit();
                Console.WriteLine($"\nCurrent progress: {_yourPoints}/{limit}");
                break;
            }
        }
    }

    
}