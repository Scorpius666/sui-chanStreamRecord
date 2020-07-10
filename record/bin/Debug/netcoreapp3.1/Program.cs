using Newtonsoft.Json;
using SquirrelFramework.Domain.Model;
using SquirrelFramework.Repository;
using System;

namespace record
{
    class Program
    {
        static void Main(string[] args)
        {
            Stream stream1 = new Stream();
            stream1.Name = "重大发表！原创曲披露！";
           // DateTime dateTime = DateTime.Parse("2020, 6, 15");
            //stream1.Date = dateTime;
            stream1.Type = 1;
            StreamCurdRepository database = new StreamCurdRepository();
            database.Add(stream1);
            Console.WriteLine(stream1);
            Console.WriteLine(JsonConvert.SerializeObject(database.GetAll()));
        }
    }
}
class StreamCurdRepository : RepositoryBase<Stream> { }
class Stream : DomainModel
{
    public Stream()
    {

    }
    public string Name;
    public DateTime Date;
    public int Type;
    public string StreamChannl;
    public int Level;
}
