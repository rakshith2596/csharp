using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Train.Providers.TrainDetailProvider
{
    public class TrainDetails : ITrainDetails
    {
        SqlDataAdapter ITrainDetails.GetAllTrainDetails(SqlConnection con)
        {
            return new SqlDataAdapter("SELECT * FROM train", con);
        }

        SqlDataAdapter ITrainDetails.GetTrainDetailsByTrainNumber(SqlConnection con, int TrainNumber)
        {
            return new SqlDataAdapter("SELECT * FROM train where trainNumber = " + TrainNumber.ToString(), con);
        }
    }
}