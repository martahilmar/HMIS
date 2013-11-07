using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HMIS.BaseInterfaces
{
    public abstract class Subject
    {
        List<IObserver> _listObservers = new List<IObserver>();

        public void NotifyObservers()
        {
            foreach (IObserver obs in _listObservers)
            {
                obs.UpdateView();
            }
        }
    }
}
