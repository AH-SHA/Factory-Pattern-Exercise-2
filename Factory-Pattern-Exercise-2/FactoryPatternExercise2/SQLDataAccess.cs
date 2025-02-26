using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise2
{
    class SQLDataAccess : IDataAccess
    {

        public SQLDataAccess()
        {

        }

        public void LoadData()
        {
            Console.WriteLine("I am reading data from an SQL DB");
            /// return statement new MongoDataAccess();
        }

        public void SaveData()
        {
            Console.WriteLine("I am saving data to a SQL database");
        }



    }
}
