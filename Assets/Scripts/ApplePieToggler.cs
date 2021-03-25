using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApplePieToggler : MonoBehaviour
{
    public void ToggleVisiblity()
    {
        Renderer rend = gameObject.GetComponent<Renderer>();

        if (rend.enabled)
        {
            rend.enabled = false;
        }
        else
        {
            rend.enabled = true;
        }
    }
}
