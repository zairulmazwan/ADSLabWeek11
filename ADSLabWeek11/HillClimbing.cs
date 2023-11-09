public class HillClimbing
{
    public List<int> solution;

    public double fitness;

    public List<Double> data = new List<double>();

    public HillClimbing(List<Double> d)
    {
        Random r = new Random();
        data = d;
        solution = new List<int>();
        for (int i=0; i<d.Count; i++)
        {
            int gene = r.Next(0,2);
            solution.Add(gene);
        }
        calCurrentFit();
    }

    public void printSolution()
    {
        foreach(int x in solution)
        {
            Console.WriteLine(x);
        }
    }

    public List<int> getSolution()
    {
        return solution;
    }

    public void calCurrentFit()
    {
        fitness = 0;
        double left=0, right=0;
        for(int i=0; i<solution.Count; i++)
        {
            if(solution[i]==0){
                left+=data[i];
                // Console.WriteLine("Left "+currenSol[i]);
            }else{
                right+=data[i];
                // Console.WriteLine("Right "+currenSol[i]);
            }
        }
        fitness = Math.Round(Math.Abs(left-right),2);
    }

    public double getFitness()
    {
        calCurrentFit();
        return fitness;
    }

    public List<int> copySolution()
    {
        List<int> res = new List<int>();
        res = solution.ToList();
        return res;
    }

    public void smallChange()
    {
        Random r = new Random();
        int ind = r.Next(solution.Count);
        // Console.WriteLine(ind);
        // Console.WriteLine("Val "+solution[ind]);

        if(solution[ind]==0)
        {
            solution[ind] = 1;
        }
        else
        {
            solution[ind] = 0;
        }
    }
}

public class Experiment
{
    public static void runExp ()
    {
        
    }
}

//©Zairul Mazwan©