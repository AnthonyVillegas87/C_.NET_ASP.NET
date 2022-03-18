using System;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace  ConsoleApplication1
{
    
    public class Program
    {
        public string Debtor;
        public string DebtorSsn;
        public string DebtorAddress1;
        public string DebtorAddress2;
        public string DebtorAddress3;
        public string DebtorCounty;
        public string DebtorEmail;
        public string DateOfBirth;
        public int DebtorCellPhone;
        public string Spouse;
        public string SpouseSsn;
        public string SpouseAddress1;
        public string SpouseAddress2;
        public string SpouseAddress3;
        public string SpouseCounty;
        public string SpouseEmail;
        public string SpouseDateOfBirth;
        public int SpouseCellPhone;
        public int Chapter;
        public string TypeofDebtor;
        public long BarId;
        public bool IsActive;

        private void DeserializeObject(string filename)
        {
            Console.WriteLine("Reading with XmlReader");
            
            //Create an instance of XmlSerializer specifying type
            XmlSerializer serializer = new XmlSerializer(typeof(Program));

            // To read our XML Document
            FileStream fileStream = new FileStream(filename, FileMode.Open);
            XmlReader reader = XmlReader.Create(fileStream);
            
            //Declare our object of the type to deserialize
            Program debtor = (Program) serializer.Deserialize(reader);
            fileStream.Close();
            
            //Write out our properties
            Console.Write(
                debtor.Debtor + "\t" +
                debtor.DebtorSsn + "\t" +
                debtor.DebtorAddress1 + "\t" +
                debtor.DebtorAddress2 + "\t" +
                debtor.DebtorAddress3 + "\t" +
                debtor.DebtorCounty + "\t" +
                debtor.DebtorEmail + "\t" +
                debtor.DateOfBirth + "\t" +
                debtor.DebtorCellPhone + "\t" +
                debtor.Spouse + "\t" +
                debtor.SpouseSsn + "\t" + 
                debtor.SpouseAddress1 + "\t" +
                debtor.SpouseAddress2 + "\t" + 
                debtor.SpouseAddress3 + "\t" +
                debtor.SpouseCounty + "\t" +
                debtor.SpouseEmail + "\t" +
                debtor.SpouseDateOfBirth + "\t" +
                debtor.SpouseCellPhone + "\t" +
                debtor.Chapter + "\t" +
                debtor.TypeofDebtor + "\t" +
                debtor.BarId + "\t" +
                debtor.IsActive
            );

        }
        public static void Main(string[] args)
        {
            Program app = new Program();
            app.DeserializeObject("form2.xml");
        }
    }
    
    
    
    
    
    
    
    
    
    
    
    
    
}