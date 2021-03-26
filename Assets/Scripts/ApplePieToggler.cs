using UnityEngine;

public class ApplePieToggler : MonoBehaviour
{
    public Renderer rend; // = gameObject.GetComponent<Renderer>();

    public void Start()
    {
        rend = gameObject.GetComponent<Renderer>();
        rend.enabled = false;
    }
}
