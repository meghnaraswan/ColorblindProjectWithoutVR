using UnityEngine;
using UnityEngine.UI;

public class TotalAppleText : MonoBehaviour
{
    public Text canvasDisplayText;
    public GameConductor gameConductor;

    public void DisplayToCanvasText()
    {
        canvasDisplayText.text = gameConductor.TotalCountDisplay;
    }

    private void Start()
    {
        this.DisplayToCanvasText();
    }

}