using UnityEngine;
namespace OtherObserverPattern
{
    public class PointOfInterest : Subject
    {
        [SerializeField]
        private string poiName;
        private void OnTriggerEnter(Collider other)
        {
            Notify(poiName, NotificationType.AchievementUnlocked);
        }
    }
}

