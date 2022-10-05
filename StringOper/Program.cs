using System;
using System.Text;

namespace StringOper // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args) {
            /*string tmpXML = new string("\"Hallo\t\n\"");

            string tmpXML1 = new string("C:/tmp/uu.txt")
                ;

            string tmpXML2 = @"C:\tmp\uu.txt";

            string tmpXML3 = $"XX={tmpXML} asdf {tmpXML2}";

            string tpGG = tmpXML + tmpXML1;

            StringBuilder b = new StringBuilder();
            b.Append("sussy");
            b.Replace("ss", "nn");*/

            string tmpXML = @"<xml>
                <school>
                    <schoolClass name='2aAPC'>
                        <student>Trocken Günther</student>
                        <student>Schuster Franz</student>
                        <student>Mayr Hans</student>
                    </schoolClass>
                </school>
            </xml>";

            ParseXML(tmpXML);
        }

        static void ParseXML(string xml) {
            if (string.IsNullOrEmpty(xml) || string.IsNullOrWhiteSpace(xml)) return;

            
        }
    }
}