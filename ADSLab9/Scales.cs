public class Scales : HillClimbing
{
    public List<int> solution = new List<int>();
    int solSize = 0;
    public double fitness = 0.00;


    public Scales() : base(data)
    {
        solSize = data.Count;
        solution = genRandomSol();
        calculateFitness();
    }

    public void copySolution(List<int> sol)
    {
        solution = new List<int>(sol);
        calculateFitness();
    }

    // This method should calculate the fitness value for the solution. The value should be updated to the property i.e fitness.
    public void calculateFitness()
    {
        double left=0.00, right=0.00;
        
        // Complete the method

        fitness =  Math.Abs(left-right);
    }

    // This method should create a new solution randomly. The value should be updated to the property i.e solution.
    public List<int> genRandomSol ()
    {
        List<int> res = new List<int>();

        // Complete the method

        return res; 
    }

    public void printSol()
    {
        foreach (int i in solution)
        {
            Console.Write(i+" ");
        }
        Console.WriteLine();
    }
}