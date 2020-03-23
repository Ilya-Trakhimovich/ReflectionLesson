using System;

namespace PluginReader
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonInfo per = new PersonInfo("Gena", "Queue", new DateTime(2000,2,29), "+37529-111-22-33", "DJ");
            per.GetBiogrphy();
            PersonInfo p = new PersonInfo(null, null, new DateTime(), null,null);
            p.GetBiogrphy();
        }
    }
}
