using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise2
{
    class MongoDataAccess : IDataAccess
    {
        public MongoDataAccess()
        {

        }

        public void LoadData() 
        {
            Console.WriteLine("I am reading data from a Mongo DB");
            // needs to return a new list - new MongoDataAccess();
        }

        public void SaveData() 
        {
            Console.WriteLine("I am saving data to a Mongo database");
        }


    }

}
