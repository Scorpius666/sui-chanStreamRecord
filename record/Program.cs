using System;

namespace record
{
    class Program
    {
        static void Main(string[] args)
        {
            Stream stream1 = new Stream();
            stream1.Name = "重大发表！原创曲披露！";
            DateTime dateTime = DateTime.Parse("2020, 6, 15");
            stream1.Date = dateTime;
            stream1.Type = 1;
        
            Console.WriteLine(stream1);
        }
    }
}
class Stream
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
