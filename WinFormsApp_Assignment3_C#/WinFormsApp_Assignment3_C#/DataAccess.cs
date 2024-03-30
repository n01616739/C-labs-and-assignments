// DataAccess.cs
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace WinFormsApp_Assignment3_C_
{
    public class DataAccess
    {
        private string filePath;

        public DataAccess(string filePath)
        {
            this.filePath = filePath;
        }

        public List<string[]> LoadData()
        {
            var lines = File.ReadAllLines(filePath);
            return lines.Select(line => line.Split(',')).ToList();
        }

        public void SaveData(IEnumerable<string[]> data)
        {
            var lines = data.Select(parts => string.Join(",", parts));
            File.WriteAllLines(filePath, lines);
        }
    }
}
