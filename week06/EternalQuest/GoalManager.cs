using System;
using System.Collections.Generic;
using System.IO;

// This class handles everything: goals, score, saving, loading and gamification
public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;
    private int _level = 1;

    public void CreateGoal()
    {
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");

        Console.Write("Choose type: ");
        int choice = int.Parse(Console.ReadLine());

        Console.Write("Name: ");
        string name = Console.ReadLine();

        Console.Write("Description: ");
        string desc = Console.ReadLine();

        Console.Write("Points: ");
        int points = int.Parse(Console.ReadLine());

        if (choice == 1)
        {
            _goals.Add(new SimpleGoal(name, desc, points));
        }
        else if (choice == 2)
        {
            _goals.Add(new EternalGoal(name, desc, points));
        }
        else if (choice == 3)
        {
            Console.Write("Target count: ");
            int target = int.Parse(Console.ReadLine());

            Console.Write("Bonus: ");
            int bonus = int.Parse(Console.ReadLine());

            _goals.Add(new ChecklistGoal(name, desc, points, target, bonus));
        }

        Console.WriteLine("Goal added successfully ");
    }

    public void RecordEvent()
    {
        ListGoals();

        Console.Write("Select goal: ");
        int index = int.Parse(Console.ReadLine());

        int pointsEarned = _goals[index].RecordEvent();
        _score += pointsEarned;

        Console.WriteLine($"You earned {pointsEarned} points!");

        CheckLevelUp();
    }

    public void ListGoals()
    {
        Console.WriteLine("\nYour Goals:");

        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i}. {_goals[i].GetStatus()} {_goals[i].GetName()}");
        }
    }

    public void DisplayScore()
    {
        Console.WriteLine($"\nScore: {_score}");
        Console.WriteLine($"Level: {_level} - {GetTitle()}");
    }

    private void CheckLevelUp()
    {
        int newLevel = _score / 1000 + 1;

        if (newLevel > _level)
        {
            _level = newLevel;
            Console.WriteLine($" LEVEL UP! You are now level {_level}!");
            Console.WriteLine($"New Title: {GetTitle()}");
        }
    }

    private string GetTitle()
    {
        if (_level < 3) return "Beginner Disciple";
        else if (_level < 5) return "Faith Builder";
        else if (_level < 8) return "Spiritual Warrior";
        else return "Ninja Unicorn ";
    }

    public void Save(string file)
    {
        using (StreamWriter output = new StreamWriter(file))
        {
            output.WriteLine(_score);
            output.WriteLine(_level);

            foreach (Goal goal in _goals)
            {
                output.WriteLine(goal.GetSaveString());
            }
        }

        Console.WriteLine("Progress saved ");
    }

    public void Load(string file)
    {
        string[] lines = File.ReadAllLines(file);

        _score = int.Parse(lines[0]);
        _level = int.Parse(lines[1]);

        _goals.Clear();

        for (int i = 2; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split("|");

            if (parts[0] == "Simple")
            {
                _goals.Add(new SimpleGoal(parts[1], parts[2], int.Parse(parts[3]), bool.Parse(parts[4])));
            }
            else if (parts[0] == "Eternal")
            {
                _goals.Add(new EternalGoal(parts[1], parts[2], int.Parse(parts[3])));
            }
            else if (parts[0] == "Checklist")
            {
                _goals.Add(new ChecklistGoal(parts[1], parts[2], int.Parse(parts[3]),
                    int.Parse(parts[4]), int.Parse(parts[5]), int.Parse(parts[6])));
            }
        }

        Console.WriteLine("Progress loaded ");
    }
}