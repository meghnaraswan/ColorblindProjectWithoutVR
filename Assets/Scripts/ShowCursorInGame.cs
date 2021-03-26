using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowCursorInGame : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Before: Cursor.visible:" + Cursor.visible.ToString());
        Cursor.visible = true;
        Debug.Log("After: Cursor.visible:" + Cursor.visible.ToString());
    }
}
