using RentMeApp.Model;
using System.Collections.Generic;

using System.Data.SqlClient;

namespace RentMeApp.DAL
{
    /// <summary>
    /// The Data Access Layer for the Style entity 
    /// </summary>
    public class StyleDAL
	{
        /// <summary>
        /// Gets all styles.
        /// </summary>
        public List<Style> GetAllStyles()
		{
			List<Style> styles = new List<Style>();

			using (SqlConnection connection = RentMeDBConnection.GetConnection())
			{
				using (SqlCommand command = new SqlCommand("SELECT Style FROM Style", connection))
				{
					connection.Open();
					using (SqlDataReader reader = command.ExecuteReader())
					{
						while (reader.Read())
						{
							string styleName = reader.GetString(0);
							Style style = new Style(styleName);
							styles.Add(style);
						}
					}
				}
			}

			return styles;
		}
	}
}
