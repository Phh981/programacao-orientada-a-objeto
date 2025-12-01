using Newtonsoft.Json;
using SistemaCambio;

HttpClient cliente = new HttpClient();

Console.WriteLine("  SISTEMA DE CÂMBIO ");
Console.WriteLine("Consultando cotação do Dólar...");

try
{
    string url = "https://economia.awesomeapi.com.br/last/USD-BRL";

    HttpResponseMessage resposta = await cliente.GetAsync(url);

    resposta.EnsureSuccessStatusCode();

    string jsonResposta = await resposta.Content.ReadAsStringAsync();
    var dados = JsonConvert.DeserializeObject<dynamic>(jsonResposta);

    string jsonDolar = dados["USDBRl"].ToString();
    Moeda? dolar = JsonConvert.DeserializeObject<Moeda>(jsonDolar);

    if (dolar != null) 
    {
    dolar.ExibirDetalhes();
    }
}
catch (Exception erro)
{
    Console.WriteLine($"Deu ruim: {erro.Message}");
}