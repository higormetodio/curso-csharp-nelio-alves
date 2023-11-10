using System.Diagnostics;
using System.Globalization;
using System.Runtime.InteropServices;

string pathSource = @"C:\dev\NelioAlves\Arquivos\Resultado\source.csv";
string pathTarget = @"C:\dev\NelioAlves\Arquivos\Resultado\target.csv";
string texts = "TV LED,1290.99,1;Video Game Chair,350.50,3;Iphone X,900.00,2;Samsung Galaxy 9,850.00,2";

try
{
    string[] lines = texts.Split(";");

    using (StreamWriter streamSource = File.AppendText(pathSource))
    {
        foreach (string line in lines)
        {
            streamSource.WriteLine(line);
        }
    }

    string[] targetLines = File.ReadAllLines(pathSource);

    using (StreamWriter streamTarget = File.AppendText(pathTarget))
    {
        foreach (string targetLine in targetLines)
        {
            string[] campos = targetLine.Split(',');
            double valor = double.Parse(campos[1], CultureInfo.InvariantCulture);
            double quantidade = double.Parse(campos[2]);
            double total = valor * quantidade;
            string linhaTexto = campos[0] + ", " + total.ToString("F2", CultureInfo.InvariantCulture);

            streamTarget.WriteLine(linhaTexto);
        }
    }
}
catch (IOException e)
{
    Console.Write($"Ocorreu um erro: {e.Message}");
}
