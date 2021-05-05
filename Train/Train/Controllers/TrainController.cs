using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using System.Data.SqlClient;
using Train.Models;
using Train.Providers.TrainDetailProvider;

namespace Train.Controllers
{
    public class TrainController : Controller
    {
        string connection = @"data source=CSG-LPTP-62\MSSQLSERVER01;initial catalog = Train; user id = sa; password=Rakshith98;MultipleActiveResultSets=True";
        ITrainDetails _trainDetails = new TrainDetails();
        // GET: Train
        [HttpGet]
        public ActionResult Index()
        {
            DataTable dataTable = new DataTable();
            using(SqlConnection con = new SqlConnection(connection))
            {
                con.Open();
                SqlDataAdapter sqlDataAdapter = _trainDetails.GetAllTrainDetails(con);
                sqlDataAdapter.Fill(dataTable);
                con.Close();
            }
            return View(dataTable);
        }

        // GET: Train/Details/5
        public ActionResult Details(int id)
        {
            DataTable dataTable = new DataTable();
            using (SqlConnection con = new SqlConnection(connection))
            {
                con.Open();
                SqlDataAdapter sqlDataAdapter = _trainDetails.GetTrainDetailsByTrainNumber(con, id);
                sqlDataAdapter.Fill(dataTable);
                con.Close();
            }
            return View(dataTable);
        }        
    }
}
