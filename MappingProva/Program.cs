using Dapper.FluentMap;
using Dapper.FluentMap.Configuration;
using Dapper.FluentMap.Dommel;
using MappingProva.Entities;
using MappingProva.Mapping;
using MappingProva.Repository;
using System.Text.Json;

class Program
{
    static void Main()
    {
        Porto porto = new Porto() { IdInsieme = Insieme.Porto, Annullato = true, Id = 1, Descrizione = "prova"};
        Console.Write((porto.IdInsieme));

        //FluentMapper.Initialize(config =>
        //{
        //    config.AddMap(new PortoMap());
        //    config.ForDommel();
        //});
        //var rep = new PortoRepository();
        //var porti = rep.GetAll().ToArray();
        //foreach (var item in porti)
        //{
        //    string json = JsonSerializer.Serialize(item);
        //    Console.WriteLine(json);
        //}
    }
}