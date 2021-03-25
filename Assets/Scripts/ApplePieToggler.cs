using UnityEngine;

public class ApplePieToggler : MonoBehaviour
{
    public void Start()
    {
        //Renderer rend = gameObject.GetComponent<Renderer>();

        //if (rend.enabled)
        //{
        //    rend.enabled = false;
        //}
        //else
        //{
        //    rend.enabled = true;
        //}
        Renderer rend = gameObject.GetComponent<Renderer>();
        rend.enabled = false;
    }
}
