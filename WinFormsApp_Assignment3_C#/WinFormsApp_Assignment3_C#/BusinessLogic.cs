// BusinessLogic.cs
using System.Collections.Generic;
using System.Linq;

namespace WinFormsApp_Assignment3_C_
{
    public class BusinessLogic
    {
        private DataAccess dataAccess;

        public BusinessLogic(string filePath)
        {
            dataAccess = new DataAccess(filePath);
        }

        public List<string[]> GetAllRecords()
        {
            return dataAccess.LoadData();
        }

        public void AddRecord(string[] record)
        {
            var records = GetAllRecords();
            records.Add(record);
            dataAccess.SaveData(records);
        }

        public void UpdateRecord(string studentId, string[] newRecord)
        {
            var records = GetAllRecords();
            var recordToUpdate = records.FirstOrDefault(r => r.Length > 0 && r[0] == studentId);
            if (recordToUpdate != null)
            {
                int index = records.IndexOf(recordToUpdate);
                records[index] = newRecord;
                dataAccess.SaveData(records);
            }
        }
        public bool ValidateLogin(string username, string password)
        {
            var records = GetAllRecords();
            // Username case-insensitive comparison, password case-sensitive comparison
            return records.Any(record => record.Length >= 2
                                         && record[0].Equals(username, StringComparison.OrdinalIgnoreCase)
                                         && record[1] == password);
        }

        public void DeleteRecord(string studentId)
        {
            var records = GetAllRecords();
            var recordToDelete = records.FirstOrDefault(r => r.Length > 0 && r[0] == studentId);
            if (recordToDelete != null)
            {
                records.Remove(recordToDelete);
                dataAccess.SaveData(records);
            }
        }
    }
}
