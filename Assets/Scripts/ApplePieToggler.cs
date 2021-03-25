using UnityEngine;

public class ApplePieToggler : MonoBehaviour
{
    public Renderer rend; // = gameObject.GetComponent<Renderer>();

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
        rend = gameObject.GetComponent<Renderer>();
        rend.enabled = false;
    }
}
