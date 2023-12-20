using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace ExtensionMethods
{
    public static class DictionaryExtensions
    {
        public static DataTable ToDataTable<T>(this Dictionary<int, T> dictionary)
        {
            var dt = new DataTable();
            dictionary.Keys.ToList().ForEach(x => dt.Columns.Add(x.ToString(), typeof(T)));
            dt.Rows.Add(dictionary.Values.Cast<object>().ToArray());
            return dt;
        }

        public static void UpdateFromDataTable<T>(this Dictionary<int, T> dictionary,
            DataTable table)
        {
            if (table.Rows.Count == 1)
                table.Columns.Cast<DataColumn>().ToList().ForEach(x =>
                    dictionary[Convert.ToInt32(x.ColumnName)] = table.Rows[0].Field<T>(x.ColumnName));
        }
    }
}