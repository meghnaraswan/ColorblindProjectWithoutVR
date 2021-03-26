using UnityEngine;
using UnityEngine.SceneManagement;

public class GameConductor : MonoBehaviour
{
    static int MAX_TOTAL_COUNT = 3;

    private int redCount = 0;
    private int greenCount = 0;

    public GameObject completeLevelUI;

    public GameObject sorryUI;

    public int TotalCount
    {
        get { return this.greenCount + this.redCount; }
    }

    public bool addRedCount()
    {
        if (TotalCount == MAX_TOTAL_COUNT)
        {
            return false;
        }
        else
        {
            this.redCount++;
            return true;
        }
    }

    public bool subtractRedCount()
    {
        if (TotalCount == 0)
        {
            return false;
        }
        else
        {
            this.redCount--;
            return true;
        }
    }

    public bool addGreenCount()
    {
        if (TotalCount == MAX_TOTAL_COUNT)
        {
            return false;
        }
        else
        {
            this.greenCount++;
            return true;
        }
    }

    public bool subtractGreenCount()
    {
        if (TotalCount == 0)
        {
            return false;
        }
        else
        {
            this.greenCount--;
            return true;
        }
    }

    public string TotalCountDisplay
    {
        get { return "Total: " + this.TotalCount.ToString() + "/" + GameConductor.MAX_TOTAL_COUNT.ToString(); }
    }

    public string RedCountDisplay
    {
        get { return "Red: " + this.redCount.ToString(); }
    }

    public bool IsPieReady()
    {
        return (redCount == MAX_TOTAL_COUNT);
    }

    public bool IsBucketFull()
    {
        return (TotalCount == MAX_TOTAL_COUNT);
    }

    public void CompleteLevel()
    {
        completeLevelUI.SetActive(true);
    }

    public void SorryMessage()
    {
        sorryUI.SetActive(true);
    }
}
