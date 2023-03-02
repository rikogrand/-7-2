using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ПЗ7_Ч2 {
    public interface Observable {
        void AddObserver(Observer observer);
        void RemoveObserver(Observer observer);
        void NotifyObservers();
    }
}
