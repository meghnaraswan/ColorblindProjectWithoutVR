using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleTriggeBox : MonoBehaviour
{
    public void Start()
    {
    }
    //public ApplePieToggler applePieToggler;


    //public void OnTriggerEnter()
    //{
    //    if (gameConductor.PieIsReady == true)
    //    {
    //        applePieToggler.rend.enabled = true;
    //    }
    //}

    public GameConductor gameConductor;

    public ApplePieToggler applePieToggler;

    public TotalAppleText totalAppleText;
    public RedAppleText redAppleText;

    private Color m_oldColor = Color.white;

    void OnTriggerEnter(Collider other)
    {
        GameObject gameObject = other.gameObject;
        Debug.Log("OnTriggerEnter: " + gameObject.ToString());
        if (gameObject.CompareTag("RedApple"))
        {
            gameObject.GetComponent<RedAppleData>().isRed = true;
            gameConductor.addRedCount();
            Debug.Log("Red: Total:" + gameConductor.TotalCountDisplay + "||" + gameConductor.RedCountDisplay);
            DisplayOnCanvas();
        }
        else if (gameObject.CompareTag("GreenApple"))
        {
            gameObject.GetComponent<RedAppleData>().isRed = false;
            gameConductor.addGreenCount();
            Debug.Log("Green: Total:" + gameConductor.TotalCountDisplay + "||" + gameConductor.RedCountDisplay);
            DisplayOnCanvas();
        }
        else
        {
            Debug.Log("No Tag");
        }
        ShowPie();
    }

    void OnTriggerExit(Collider other)
    {
        GameObject gameObject = other.gameObject;
        Debug.Log("OnTriggerExit: " + gameObject.ToString());

        if (gameObject.CompareTag("RedApple"))
        {
            gameObject.GetComponent<RedAppleData>().isRed = true;
            gameConductor.subtractRedCount();
            Debug.Log("Red: Total:" + gameConductor.TotalCountDisplay + "::" + gameConductor.RedCountDisplay);
            DisplayOnCanvas();
        }
        else if (gameObject.CompareTag("GreenApple"))
        {
            gameObject.GetComponent<RedAppleData>().isRed = false;
            gameConductor.subtractGreenCount();
            Debug.Log("Green: Total:" + gameConductor.TotalCountDisplay + "::" + gameConductor.RedCountDisplay);
            DisplayOnCanvas();
        }
    }

    void DisplayOnCanvas()
    {
        totalAppleText.DisplayToCanvasText();
        redAppleText.DisplayToCanvasText();
    }

    void ShowPie()
    {
        if (gameConductor.IsPieReady())
        {
            Renderer triggerRenderer = GetComponent<Renderer>();
            m_oldColor = triggerRenderer.material.color;
            triggerRenderer.material.color = Color.yellow;
            applePieToggler.rend.enabled = true;
        }
        else
        {
            Renderer triggerRenderer = GetComponent<Renderer>();
            triggerRenderer.material.color = m_oldColor;
            applePieToggler.rend.enabled = false;
        }
    }
}
