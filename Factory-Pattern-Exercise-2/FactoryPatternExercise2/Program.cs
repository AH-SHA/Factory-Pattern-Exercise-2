
namespace FactoryPatternExercise2
{
    public class Program
    {

        /* Instructions:  Lastly in the Main()
        Ask the user what database they want to use: a List, SQL, or Mongo
        Store their response in a variable
        Call your factory method and pass in what the user types and store what your factory method returns in an IDataAccess variable
        Call the LoadData and SaveData methods of the IDataAccess variable
        Run the program a few times using the different types.         */

        static void Main(string[] args)
        {
            Console.WriteLine(" ");
            Console.WriteLine("Type the name of the Database you want: List, SQL, or Mongo?");
            var userAnswer = (Console.ReadLine()).ToLower();

                
            var userResult = DataAccessFactory.GetDataAccessType(userAnswer);

            Console.WriteLine("");

            userResult.LoadData();
            userResult.SaveData();





        }

        
    }
}
