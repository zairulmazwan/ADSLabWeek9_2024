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
        // Write your prorgam here
        
    }

    // This method should create a new solution randomly. The value should be updated to the property i.e solution.
    public List<int> genRandomSol ()
    {
        // Write your prorgam here
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