using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise2
{
    class ListDataAccess : IDataAccess
    {

        public ListDataAccess()
        {

        }


        public void LoadData()
        {
            Console.WriteLine("I am reading data from a List DB");
            //// return line here
        }

        public void SaveData()
        {
            Console.WriteLine("I am saving data to a List database");
        }




    }
}
