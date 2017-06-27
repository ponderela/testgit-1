using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using org.apache.pdfbox.pdmodel.interactive.digitalsignature.;
using org.apache.pdfbox.encryption;
using org.apache.pdfbox.util;
using PDFBox;
using System.Reflection;

namespace PDFBox
{
    class Program
    {
        static void Main(string[] args)
        {           
            string input = "C:\\Users\\pragasit-ETDA\\Documents\\Visual Studio 2015\\Projects\\PDFBox\\PDFBox\\resource\\in\\test.pdf";

            
            byte[] inputFile = File.ReadAllBytes(input);
            MemoryStream ms = new MemoryStream(inputFile);

            PDDocument doc = PDDocument.load(input);           



        }
    }
}
