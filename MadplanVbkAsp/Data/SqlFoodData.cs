using MadplanVbkAsp.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MadplanVbkAsp.Models;
using System.Reflection;
using System.IO;
using System.Text;
using CsvHelper;

namespace MadplanVbkAsp.Data
{
    public class SqlFoodData : IFoodData
    {
        private SqlDbContext _db;

        public SqlFoodData(SqlDbContext db)
        {
            _db = db;
        }

        public void Add(Food newFood)
        {
            throw new NotImplementedException();
        }

        public Food Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Food> GetAll()
        {
            if (!_db.Foods.Any())
            {
                var assembly = typeof(SqlFoodData).GetTypeInfo().Assembly;

                Stream stream = assembly.GetManifestResourceStream("MadplanVbkAsp.Resources.FoodDatabase.csv");

                string text;

                // Der bruges Encoding.GetEncoding("iso-8859-1") for at den læser ÆØÅ korrekt
                using (var reader = new System.IO.StreamReader(stream, Encoding.GetEncoding("iso-8859-1")))
                {
                    text = reader.ReadToEnd();
                }

                TextReader sr = new StringReader(text);

                var csv = new CsvReader(sr);
                csv.Configuration.Delimiter = ";";

                int counter = 0;

                while (csv.Read())
                {
                    if (counter > 0)
                    {
                        _db.Foods.Add(new Food
                        {
                            Name = csv.GetField<string>(0),
                            EnergiKj = csv.GetField<string>(3),
                            EnergiKcal = csv.GetField<string>(4)
                        });
                    }

                    counter++;
                }

                _db.SaveChanges();
            }

            var list = _db.Foods;

            return list;
        }
    }
}
