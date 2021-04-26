using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformTrigger : MonoBehaviour
{
    private Color m_oldColor = Color.white;

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("OnTriggerEnter: " + gameObject.ToString());
        Renderer triggerRenderer = GetComponent<Renderer>();
        m_oldColor = triggerRenderer.material.color;
        triggerRenderer.material.color = Color.yellow;
    }

    void OnTriggerExit(Collider other)
    {
        Debug.Log("OnTriggerExit: " + gameObject.ToString());
        Renderer triggerRenderer = GetComponent<Renderer>();
        triggerRenderer.material.color = m_oldColor;
    }
}
