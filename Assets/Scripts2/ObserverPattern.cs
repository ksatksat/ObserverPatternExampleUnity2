using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace ObserverPattern
{
    //invokes the notification method
    public class Subject : MonoBehaviour
    {
        //A list with observers that are waiting for something to happen
        List<Observer> observers = new List<Observer>();
        //send notifications if something has happened
        public void Notify()
        {
            for (int i = 0; i < observers.Count; i++)
            {
                //Notify all observers even though some may not be interested in what has happened
                //Each observer should check if it is interested in this event
                observers[i].OnNotify();
            }
        }
        //add observer to the list
        public void AddObserver(Observer observer)
        {
            observers.Add(observer);
        }
        //Remove observer from the list
        public void RemoveObserver(Observer observer)
        {
            
        }
    }
}
