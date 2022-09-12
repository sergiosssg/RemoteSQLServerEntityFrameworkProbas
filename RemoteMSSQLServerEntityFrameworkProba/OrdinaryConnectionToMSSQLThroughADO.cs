﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteMSSQLServerEntityFrameworkProba
{
    public partial class OrdinaryConnectionToMSSQLThroughADO
    {
        static public void AccomplishSelectTo_TEL_VID_CONNECT()
        {
            Console.WriteLine("Start program");


            using (SqlConnection sqlCon = new SqlConnection(DBFacilities.GetConnectionString()))
            {
                string sqlCmdExTableCheck = @"SELECT *  FROM [SM].[phone].[TEL_VID_CONNECT]";

                using (SqlCommand sqlCmd = new SqlCommand(sqlCmdExTableCheck, sqlCon))
                {
                    try
                    {
                        ConnectionState conState = sqlCon.State;

                        Console.WriteLine(conState);

                        sqlCon.Open();

                        Console.WriteLine("connection open successfully");

                        conState = sqlCon.State;

                        Console.WriteLine(conState);

                        using (SqlDataReader reader = sqlCmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Console.WriteLine(String.Format("{0}, {1}, {2}",
                                    reader[0], reader[1], reader[2]));
                            }
                        }
                        sqlCon.Close();
                        Console.WriteLine("connection closed successfully");
                    }
                    catch (SqlException se)
                    {
                        ;
                    }

                    Console.WriteLine("end of program");
                }
            }
        }
    }
}
