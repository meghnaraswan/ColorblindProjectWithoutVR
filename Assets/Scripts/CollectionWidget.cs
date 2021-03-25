using UnityEngine;

public class CollectionWidget : MonoBehaviour
{
    public string BatteryCount;
    public int CurrentCount
    {
        get { return CurrentCount; }
        set { CurrentCount = value; }
    }
    public string SetCollectibleText()
    {
        BatteryCount = CurrentCount.ToString();
        BatteryCount += "/5";
        return BatteryCount;
    }
}
