using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using CsvReader.Data;
using Microsoft.EntityFrameworkCore;


namespace CsvReader
{
    public class Program
    {
        static void Main(string[] args) {
            string path2File = "C:/Temp/2.csv";
            string catchName = "James Bond";
            Connector4Dtb.ImportFromCsv(path2File, catchName);
        }

    }
}
