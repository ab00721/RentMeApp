using RentMeApp.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentMeApp.DAL
{
    public class ReportDAL
    {
        public List<Report> GetMostPopularFurnitureDuringDates(DateTime startDate, DateTime endDate)
        {
            List<Report> reports = new List<Report>();

            using (SqlConnection connection = RentMeDBConnection.GetConnection())
            {
                using (SqlCommand command = new SqlCommand("getMostPopularFurnitureDuringDates", connection)) 
                {
                    command.CommandType = System.Data.CommandType.StoredProcedure;

                    command.Parameters.Add("@start_date", SqlDbType.DateTime);
                    command.Parameters["@start_date"].Value = startDate;

                    command.Parameters.Add("@end_date", SqlDbType.DateTime);
                    command.Parameters["@end_date"].Value = endDate;

                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Report report = new Report();
                            report.FurnitureID = (int) reader["FurnitureID"];
                            report.Category = reader["Category"].ToString();
                            report.Name = reader["Name"].ToString();
                            report.CountOfRentalTransactions = (int) reader["CountRentalTransactions"];
                            report.TotalTransactions = (int)reader["Total Transactions"];
                            report.PercentageOfTransactions = reader["% of transactions"].ToString();
                            report.PercentageBtwEighteenTwentyNine = reader["% b/t 18-29"].ToString();
                            report.PercentageNotBtwEighteenTwentyNine = reader["%not  b/t 18-29"].ToString();

                            reports.Add(report);



                            //Incident incident = new Incident();
                            //incident.ProductCode = reader["Product Code"].ToString();
                            //if (reader["Date Opened"] != DBNull.Value)
                            //{
                            //    incident.DateOpened = DateOnly.FromDateTime((DateTime)reader["Date Opened"]);
                            //}
                            //incident.Customer = reader["Customer"].ToString();
                            //incident.Technician = reader["Technician"].ToString();
                            //incident.Title = reader["Title"].ToString();
                            //openIncidents.Add(incident);

                        }
                    }

                }
            }

            return reports;
        }

    }
}
