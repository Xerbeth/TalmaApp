using Airport.Domain.Common.Models;
using Airport.Domain.DAL.Repository.Interfaces;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Airport.Domain.DAL.Repository
{
    public class AirplanesTypesRepository : IAirplanesTypesRepository
    {
        private IConfiguration Configuration;
        private readonly string ConnectionString;
        public AirplanesTypesRepository(IConfiguration configuration)
        {
            Configuration = configuration;
            ConnectionString = Configuration.GetConnectionString("DefaultConnection");
        }

        public List<AirplanesTypesModel> GetAllAirplanesTypes()
        {
            List<AirplanesTypesModel> listAirplanesTypes = new List<AirplanesTypesModel>();
            string queryString = "SELECT * FROM dbo.AirplanesTypes;";
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        AirplanesTypesModel airplanesTypes = new AirplanesTypesModel();
                        airplanesTypes.Id = Int64.Parse(reader[0].ToString());
                        airplanesTypes.Name = reader[1].ToString();
                        airplanesTypes.Capacity = Int64.Parse(reader[2].ToString());
                        airplanesTypes.TopSpeed = (reader[3] == System.DBNull.Value) ? 0 : (decimal)reader[3];                        
                        airplanesTypes.MaximumWeight = (reader[4] == System.DBNull.Value) ? 0 : (decimal)reader[4];
                        airplanesTypes.Height = (reader[5] == System.DBNull.Value) ? 0 : (decimal)reader[5];
                        airplanesTypes.Lenght = (reader[6] == System.DBNull.Value) ? 0 : (decimal)reader[6];
                        airplanesTypes.Wingspan = (reader[7] == System.DBNull.Value) ? 0 : (decimal)reader[7];
                        listAirplanesTypes.Add(airplanesTypes);
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    throw new ArgumentException("Error 01: Ocurrió un error consultando la base de datos.");
                }
                return listAirplanesTypes;
            }
        }
    }
}
