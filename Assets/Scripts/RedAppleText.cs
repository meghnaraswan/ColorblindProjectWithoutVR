using UnityEngine;
using UnityEngine.UI;

public class RedAppleText : MonoBehaviour
{
    public Text canvasDisplayText;
    public GameConductor gameConductor;

    public void DisplayToCanvasText()
    {
        canvasDisplayText.text = gameConductor.RedCountDisplay;
    }

    private void Start()
    {
        //Debug.Log(gameConductor.RedCountDisplay);
        this.DisplayToCanvasText();
    }
}
