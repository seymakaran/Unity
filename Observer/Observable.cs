using System.Collections.Generic;

namespace Karan.Unity.Util.Generic
{
    public class Observable
    {
        protected List<IObserver> Observers = new List<IObserver>();

        public void Notify()
        {            
            Observers.ForEach(o => o.DoAction());
        }

        virtual public void Attach(IObserver observer)
        {
            //...
            Observers.Add(observer);
        }

        virtual public void Detach(IObserver observer)
        {
            //...
            Observers.Remove(observer);
        }        
    }
}
