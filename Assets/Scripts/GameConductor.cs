//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;

public class GameConductor : MonoBehaviour
{
    static int MAX_TOTAL_COUNT = 3;

    private int redCount = 0;
    private int greenCount = 0;

    public int TotalCount
    {
        get { return this.greenCount + this.redCount; }
    }

    public void addRedCount()
    {
        this.redCount++;
    }

    public void subtractRedCount()
    {
        this.redCount--;
    }

    public void addGreenCount()
    {
        this.greenCount++;
    }

    public void subtractGreenCount()
    {
        this.greenCount--;
    }

    public string TotalCountDisplay
    {
        get { return "Total: " + this.TotalCount.ToString() + "/" + GameConductor.MAX_TOTAL_COUNT.ToString(); }
    }

    public string RedCountDisplay
    {
        get { return "Red: " + this.redCount.ToString(); }
    }


}
