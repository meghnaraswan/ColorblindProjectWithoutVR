using UnityEngine;

public class CollectionWidget : MonoBehaviour
{
    //public string BatteryCount;
    static int MAX_COUNT = 5;

    private int currentCount = 0;

    public int CurrentCount
    {
        get { return this.currentCount; }
        set { this.currentCount = value; }
    }

    public void addCount()
    {
        this.currentCount++;
    }

    public void subCount()
    {
        this.currentCount--;
    }

    public string CurrentCountDisplay
    {
        get { return CurrentCount.ToString() + "/" + CollectionWidget.MAX_COUNT.ToString(); }
    }

    //public string SetCollectibleText()
    //{
    //    BatteryCount = CurrentCount.ToString();
    //    BatteryCount += "/5";
    //    return BatteryCount;
    //}
}
