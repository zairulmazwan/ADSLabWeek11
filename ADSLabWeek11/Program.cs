//Study the following outputs

List<Double> data = FileData.readData(@"/Users/zairulmazwan/Dotnet/ADSLabWeek11/ADSLabWeek11/test_data.csv");
FileData.printList(data);

HillClimbing hc = new HillClimbing(data); //Creating an object for HC. A HC object has properties: solution, fitness and dataset
Console.WriteLine("hc solution:");
hc.printSolution(); //Let see the initial solution for hc
Console.WriteLine("\nThe fitness values for hc : "+hc.getFitness());
Console.WriteLine("\n------------------");
HillClimbing hc2 = new HillClimbing(data); // Creating another object of HC, with the name hc2
hc2 = hc.copySolution(); // Copy the solution from hc to hc2
Console.WriteLine("hc2 solution:");
hc2.printSolution();
Console.WriteLine("\nThe fitness value for hc2 after copying hc: "+hc2.getFitness());

hc2.smallChange();//Perform small change to hc2
Console.WriteLine("hc2 after small change");
hc2.printSolution();
Console.WriteLine("\nThe fitness values for hc2 after small change : "+hc2.getFitness());

// Experiment.runExp(); //Experiment class is written in file HillClimbing.cs



//©Zairul Mazwan©