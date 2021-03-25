using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstPersonCharacter : MonoBehaviour
{
    public int BatteryCount;

    public ApplePieToggler applePieToggler;

    public GameConductor gameConductor;

    public int finalBatteryCount = 5;

    public void ShowApplePie()
    {
        applePieToggler.rend.enabled = true;
    }

    public void CheckCollectible()
    {
        if(BatteryCount == finalBatteryCount)
        {
            ShowApplePie();
        }
    }

    public void CollectBattery()
    {
        gameConductor.addRedCount();
    }
}


