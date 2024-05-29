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
            string path2File = "C://Users//cross//source//repos//WpfDolgozat//CsvReader//Data//CsvSource//8.csv";
            string catchName = "Jennifer";
            Connector4Dtb.ImportFromCsv(path2File, catchName);
        }

    }
}
