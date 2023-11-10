const string path = @"C:\dev\NelioAlves\Dictionary\in.txt";

try
{
    Dictionary<string, int> contagem = new Dictionary<string, int>();
    string? lines;
    using StreamReader streamReader = new StreamReader(path);

    while ((lines = streamReader.ReadLine()) != null)
    {
        string[] valores = lines.Split(',');
        string key = valores[0];
        int value = Convert.ToInt32(valores[1]);

        if (contagem.ContainsKey(key))
        {
            contagem[key] += value;
        }
        else
        {
            contagem[key] = value;
        }
    }

    foreach (KeyValuePair<string, int> item in contagem)
    {
        Console.WriteLine($"{item.Key}: {item.Value}");
    }

    streamReader.Close();
}
catch (Exception e)
{
    Console.WriteLine($"Ocorreu uma exceção: {e.Message}");
}




