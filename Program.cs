using System;

namespace ПЗ7_Ч2 {
    class Program {
        static void Main(string[] args) {
            Admin administrator1 = new Admin("Floppy");
            Admin administrator2 = new Admin("Bakugo");
            Site site = new Site(0.99);
            site.AddObserver(administrator1);
            site.AddObserver(administrator2);
            for (int i = 403; i < 503; i++) {
                site.DoSite();
            }
        }
    }
}

