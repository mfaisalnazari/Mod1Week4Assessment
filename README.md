# Mod1 Week4 Assessment
This assessment has two parts - some questions about this week's lessons, and an exercise focused on our Testing lesson. Work on the Questions first, then move on to the Exercise!

During this assessment, you may use most other resource besides your fellow students.  Feel free to google, look back at your notes, lessons, labs, etc... **you may not use Chat GPT or any other AI tool**

## Set Up

Fork this repository! (Don't clone it yet!!)

## Questions (12 Points Possible)
Edit this `README.md` file - answer the 6 questions before moving on to the exercise.  Make sure to save your changes to the README before moving on to the exercises!

To Edit the README:
* click the pencil icon in the upper right corner.
* make changes in the text editor.
* save your changes by clicking 'Commit Changes'
    * on the confirmation screen, click 'Commit Changes'
 
</br>
</br>

1. Review the class definition below:
    ```c#
    public class Chair
    {
        public int Height { get; }
        public bool HasBack { get; }

        public Chair(int height, bool hasBack)
        {
            Height = height;
            HasBack = hasBack;
        }
    }
    ```
    Which of the following is NOT a valid way to create an instance of Chair? And why does this option not work?  
    A. `var bench = new Chair(24, true);`  
    B. `Chair bench = new Chair(24, true);`  
    C. `var bench = new(24, true);`  
    D. `Chair bench = new(24, true);`  
    option C, because we don't tell it what type of instance we are creating.
    
2. Imagine you are interviewing for your first job.  The interviewer asks "What can you tell me about OOP?".  Write your response below:
Object Oriented Programming, is one of the popular style or type of programming, it relies on objects to organize programs in to simple and reuseble code, That allows us to hold related information in a seperate class also to hide more complex functionality of a program from the user and make the the code more tidier and efficient.

3. What is Automated Testing?
testing the funcionality of a program or project with a separate project that the we create in addition to the actual project, which tests if the actual project is functioning as expected

4. What are some benefits of creating tests for our projects?
it is time efficient and we can test the program before completing it, also it provides feedback based on expected behaviour of the program. 

5. When you create a test project, you do not immediately have access to the class(es) in the project that you are testing.  What do you need to do in order to have access to those classes?
in visual studio you create a reference between your actual project and test project.
6. Take a look at the class below.  Write out the **names** of each test you would write to verify that this class is working. You do not need to write the whole test, just what you would **name** the test methods. Ex: `IsCreatedWithTwoArguments()`
```c#
    public class Vehicle
    {
        public int NumberOfWheels { get; }
        public string Color { get; private set;  }
        public int MilesDriven { get; private set; }

        public Vehicle(int numberOfWheels, string color)
        {
            NumberOfWheels = numberOfWheels;
            Color = color;
            MilesDriven = 0;
        }

        public string Summary()
        {
            string summary = $"This {Color} vehicle has {NumberOfWheels} wheels, and has driven {MilesDriven} miles.";
            return summary;
        }

        public void Drive()
        {
            MilesDriven += 5;
        }

        public void Paint(string newColor)
        {
            Color = newColor;
        }
    }
```
1st  , IsCreatedWithTwoArguments()
2nd , IfSummaryPrintsWithCorrectAttributes().
3rd, IfDriveAddsMiles().
4th, IfPaintChangesColor().


## Exercise (8 Points Possible)
In Visual Studio, clone your forked repository.  
In this solution, there is a `Vehicle` project and a `Vehicle.UnitTests` project.  The class in `Vehicle.cs` is complete, but the tests for that class are not yet finished.  Add tests to the `VehicleTests.cs` file so that all the methods and properties for the `Vehicle` class have tests.  When finished, there should be a minimum of 4 tests (one is already completed for you!).

### Submission

When the assessment is due, your instructors will show you how to commit the code you worked on in Visual Studio and push it up to GitHub :) 

### Rubric

This assessment has a total of **20 Points**.  Earning **10 or more** points is a **pass** and will indicate that you are progressing well with the material.

As a reminder, this assessment is for students and instructors to determine if there are any areas that need additional reinforcement!
