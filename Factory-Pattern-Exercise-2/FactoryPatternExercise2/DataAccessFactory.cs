﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise2
{
    public static class DataAccessFactory
    {

        public static IDataAccess GetDataAccessType(string userAnswer)
        {

            switch (userAnswer)
            {
                case "list":
                    return new ListDataAccess();

                    break;

                case "sql":
                    return new SQLDataAccess();

                    break;

                case "mongo":
                    return new MongoDataAccess();

                    break;

                default:
                    return new ListDataAccess();
                    break;




            }



        }




    }

}
