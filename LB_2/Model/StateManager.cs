using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using LB_2.Model.OperatorCompany;

namespace LB_2.Model
{
    public class StateManager
    {
        private static readonly BinaryFormatter _binFormat = new BinaryFormatter();
        
        public void SaveWholeState(Company objGraph, string fileName)
        {
            using (Stream fStream = new FileStream(fileName, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                _binFormat.Serialize(fStream, objGraph);
            }
        }
        
        public void RestoreWholeState(out Company curCompany, string fileName)
        {
            using (Stream fStream = File.OpenRead(fileName))
            {
                curCompany =
                    (Company)_binFormat.Deserialize(fStream);
            }
        }
    }
}