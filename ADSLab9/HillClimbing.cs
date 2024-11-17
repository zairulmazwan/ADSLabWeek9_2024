public class HillClimbing
{
    public static List<Double> data;
    public HillClimbing(List<Double> d)
    {
        data = new List<double>(d);
    }


    // This method should run the experiment for the Scales problem.
    public void runHC(int iter)
    {

        // Create a solution and a new solution
       

        // copy the existion solution to the new solution

        // Start searching a solution
        for (int i = 0; i<iter; i++)
        {   
            
            // perform a small change toward the new solution
           

            // If tne new solution is better than the current solution, we copy the solution from the new one to the current solution
           
        }
            Console.WriteLine("Final solution ");
            // Write your results and solutions to csv files.
    }

    // This method should perform a small change to the new solution after we've copied from the solution.
    public Scales smallChange(Scales newSol, int n)
    {
        // Complete your method for small change

        newSol.calculateFitness();
        return newSol;
    }
}