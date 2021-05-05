using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train.Providers.TrainDetailProvider
{
    interface ITrainDetails
    {
        SqlDataAdapter GetAllTrainDetails(SqlConnection con);
        SqlDataAdapter GetTrainDetailsByTrainNumber(SqlConnection con, int TrainNumber);
    }
}
