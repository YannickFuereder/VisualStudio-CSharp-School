using System;
using System.Text;

namespace StringOper // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        const string studentStart = "<student>";
        const string studentEnd = "</student>";

        static void Main(string[] args) {
            /*string tmpXML = new string("\"Hallo\t\n\"");

            string tmpXML1 = new string("C:/tmp/uu.txt");

            string tmpXML2 = @"C:\tmp\uu.txt";

            string tmpXML3 = $"XX={tmpXML} asdf {tmpXML2}";

            string tpGG = tmpXML + tmpXML1;

            StringBuilder b = new StringBuilder();
            b.Append("sussy");
            b.Replace("ss", "nn");*/

            string tmpXML = @"<xml>
                <school>
                    <schoolClass name='2aAPC'>
                        <student>Mayr Hans</student>
                        <student> Schuster Franz</student>
                        <student> </student>
                    </schoolClass>
                </school>
            </xml>";

            ParseXML(tmpXML);
        }

        static void ParseXML(string xml) {
            if (string.IsNullOrEmpty(xml) || string.IsNullOrWhiteSpace(xml)) return;

            int tmpPos = 0;
            do {
                tmpPos = xml.IndexOf(studentStart, tmpPos);

                if (tmpPos != -1) {
                    tmpPos += studentStart.Length;
                    int tmpEndPos = xml.IndexOf(studentEnd, tmpPos);

                    if (tmpEndPos == -1) {
                        tmpPos = -1;
                    } else {
                        string tmpName = xml.Substring(tmpPos, tmpEndPos - tmpPos);
                        Console.WriteLine(tmpName);
                        tmpPos += studentStart.Length;
                    }

                }
                
            } while (tmpPos != -1);

        }
    }
}