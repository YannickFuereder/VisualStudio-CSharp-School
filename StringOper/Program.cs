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

                if (tmpPos == -1) continue;

                tmpPos += studentStart.Length;
                int tmpEndPos = xml.IndexOf(studentEnd, tmpPos);

                if (tmpEndPos == -1) {
                    tmpPos = -1;
                    continue;
                }

                string tmpName = xml.Substring(tmpPos, tmpEndPos - tmpPos);

                tmpPos = tmpEndPos + studentEnd.Length;

                if (!ExtractNames(tmpName, out string tmpLastName, out string tmpFirstName)) continue;

                Console.WriteLine($"Nachname={tmpLastName} Vorname={tmpFirstName}");



            } while (tmpPos != -1);

        }

        static bool ExtractNames(string value, out string lastName, out string firstName) {
            value = value.Trim();

            if (string.IsNullOrWhiteSpace(value)) {
                lastName = string.Empty;
                firstName = string.Empty;
                return false;
            }
            
            string[] tmpValues = value.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            if (tmpValues.Length < 2) {
                lastName = string.Empty;
                firstName = string.Empty;
                return false;
            }

            lastName = tmpValues[0];
            firstName = tmpValues[1];

            return true;
        }
    }
}