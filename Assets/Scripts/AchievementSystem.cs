using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace OtherObserverPattern
{
    public class AchievementSystem : Observer
    {
        private void Start()
        {
            PlayerPrefs.DeleteAll();
            //this could also be done when the pois are created in some poi spawner/manager class
            foreach(var poi in FindObjectOfType<PointOfInterest>())
            {
                poi.RegisterObserver(this);
            }
        }
        public override void OnNotify(object value, NotificationType notificationType)
        {
            if (notificationType == NotificationType.AchievementUnlocked)
            {
                string achievementKey = "achivement-" + value;
                if (PlayerPrefs.GetInt(achievementKey) == 1)
                {
                    return;
                }
                PlayerPrefs.SetInt(achievementKey, 1);
                Debug.Log("Unlocked " + value);
                //send some stuff off to steam
            }
        }
    }
    public enum NotificationType
    {
        AchievementUnlocked
    }
}
