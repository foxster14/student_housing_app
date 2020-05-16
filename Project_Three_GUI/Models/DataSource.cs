using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Three_GUI.Models
{
    class DataSource
    {
        const string PATH = @"C:\Users\foxsarh\Desktop\Residents.csv";

        FileStream infile;
        FileStream outFile;
        StreamReader read;
        StreamWriter writer;
        string primer;
        string[] superBowlData;
    }
}
