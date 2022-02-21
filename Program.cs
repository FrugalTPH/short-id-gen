using System;
using _n = Nanoid.Nanoid;
using TextCopy;


namespace short_id_gen
{
    class Program
    {
        static void Main(string[] args)
        {
            var id = _n.Generate("023456789ABCDEFGHJKLMNPQRSTUVWXYZ", 6);

            ClipboardService.SetText(id.Insert(3, "-"));
        }
    }
}
