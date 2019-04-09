using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CpSysLab1
{
    class Program
    {
        private static readonly string[] sampleTexts = new [] {"legion.txt", "naruto.txt", "tea.txt" };
        private static readonly string textDirectory = @"..\..\Texts\";
        private static readonly string[] sampleTexts1 = new[] { "legion64.txt", "naruto64.txt", "tea64.txt" };
        private static readonly string[] sampleTexts2 = new[] { "legion64.rar", "naruto64.rar", "tea64.rar" };
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            foreach (var fileName in sampleTexts)
            {
                Console.WriteLine($"{fileName} \n {TextAnalyzer.Analyze(textDirectory+fileName)} ");
            }

            string FilePath1 = @"..\..\Texts\legion.txt";
            string customEncodedPath = @"..\..\Texts\legion64.txt";
            Base64Encoder.Encode(FilePath1, customEncodedPath);

            string customEncoding = File.ReadAllText(customEncodedPath);
            string base64Encoding = Convert.ToBase64String(File.ReadAllBytes(FilePath1));
            Console.WriteLine($"Custom base64: {customEncoding } \n\nConvert.Base64: {base64Encoding}\n");

            string FilePath2 = @"..\..\Texts\naruto.txt";
            string customEncodedPath2 = @"..\..\Texts\naruto64.txt";
            Base64Encoder.Encode(FilePath2, customEncodedPath2);

            string customEncoding2 = File.ReadAllText(customEncodedPath2);
            string base64Encoding2 = Convert.ToBase64String(File.ReadAllBytes(FilePath2));
            Console.WriteLine($"Custom base64: {customEncoding2 } \n\nConvert.Base64: {base64Encoding2}\n");

            string FilePath3 = @"..\..\Texts\tea.txt";
            string customEncodedPath3 = @"..\..\Texts\tea64.txt";
            Base64Encoder.Encode(FilePath3, customEncodedPath3);

            string customEncoding3 = File.ReadAllText(customEncodedPath3);
            string base64Encoding3 = Convert.ToBase64String(File.ReadAllBytes(FilePath3));
            Console.WriteLine($"Custom base64: {customEncoding3 } \n\nConvert.Base64: {base64Encoding3}\n");

            foreach (var fileName in sampleTexts1)
            {
                Console.WriteLine($"{fileName} \n {TextAnalyzer.Analyze(textDirectory + fileName)} ");
            }

            foreach (var fileName in sampleTexts2)
            {
                Console.WriteLine($"{fileName} \n {TextAnalyzer.Analyze(textDirectory + fileName)} ");
            }

            Console.ReadKey();
        }
    }
}
