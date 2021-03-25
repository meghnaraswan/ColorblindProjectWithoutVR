using UnityEngine;

public class CollectionWidget : MonoBehaviour
{
    public static string BatteryCount;
    public static int CurrentCount
    {
        get { return CurrentCount; }
        set { CurrentCount = value; }
    }
    string SetCollectibleText()
    {
        BatteryCount = CurrentCount.ToString();
        BatteryCount += "/5";
        return BatteryCount;
    }
}
