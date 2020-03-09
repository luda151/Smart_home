﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Dapper;


namespace Smart_home.Models
{
    public class SqlDotazy
    {
        public static string GetConnectionString(string connectionName = "Smart_home_Context")
        {
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=db1;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            return connectionString;
            //return ConfigurationManager.ConnectionStrings[connectionName].ConnectionString;
        }

        public static List<T> LoadData<T>(string sql)
        {
            using (IDbConnection cnn = new SqlConnection(GetConnectionString()))
            {
                return cnn.Query<T>(sql).ToList();
            }
        }

        public static int SaveData<T>(string sql, T data)
        {
            using (IDbConnection cnn = new SqlConnection(GetConnectionString()))
            {
                return cnn.Execute(sql, data);
            }
        }

        //public static int Create(int id, string nazev, string rok, string zanr)
        //{
        //    FilmModel data = new FilmModel
        //    {
        //        Id = id,
        //        Nazev = nazev,
        //        Rok = rok,
        //        Zanr = zanr
        //    };

        //    string sql = @"insert into dbo.Movies (Id, Nazev, Rok, Zanr)
        //                  values (@Id, @Nazev, @Rok, @Zanr);";

        //    return DataAcces.SaveData(sql, data);
        //}

        public static List<TeplotaModel> LoadTeplota()
        {
            string sql = @"select Id, Nazev, Rok, Zanr
                          from dbo.Movies;";
            return LoadData<TeplotaModel>(sql);
        }


        //public static List<FilmModel> ChangeFilm()
        //{
        //    string sql = @"update Id, Nazev, Rok, Zanr
        //                  form dbo.Movies;";
        //    return DataAcces.LoadData<FilmModel>(sql);
        //}
        //public static List<FilmModel> DeleteFilm()
        //{
        //    string sql = @"delete Id, Nazev, Rok, Zanr
        //                  form dbo.Movies;";
        //    return DataAcces.LoadData<FilmModel>(sql);
        //}
    }
}
