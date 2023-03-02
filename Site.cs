using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ПЗ7_Ч2 {
    public class Site : Observable {
        private List<Observer> administrators;
        private double reliability;
        public Site(double reliability) {
            administrators = new List<Observer>();
            this.reliability = reliability;
        }
        public void AddObserver(Observer admin) {
            administrators.Add(admin);
        }
        public void RemoveObserver(Observer admin) {
            administrators.Remove(admin);
        }
        private int _error = 403;
        public void NotifyObservers() {
            _error++;
            foreach (Observer admin in administrators) {
                admin.Update("На сайте обнаружен сбой, код ошибки: \t " + _error + "\n");
            }
        }

        public void DoSite() {
            Random rand = new Random();
            if (rand.NextDouble() > reliability) {
                NotifyObservers();
            }
        }
    }
}