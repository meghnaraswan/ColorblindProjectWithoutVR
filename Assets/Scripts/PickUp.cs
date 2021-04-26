using UnityEngine;

public class PickUp : MonoBehaviour
{
    public Transform dest;
    public float speed;

    private bool on_the_move = false;
    // Update is called once per frame
    private void Update()
    {
        if (on_the_move)
        {
            float step = 0.5f; //speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, dest.position, step);
            //        this.transform.position = dest.position;
            if(transform.position == dest.position)
            {
                on_the_move = false;
            }
        }
    }

    void OnMouseDown()
    {
        on_the_move = true;
        GetComponent<Rigidbody>().freezeRotation = true;
        GetComponent<Rigidbody>().useGravity = false;
        this.transform.parent = GameObject.Find("Destination").transform;

        ////GetComponent<BoxCollider>().enabled = false;
        //GetComponent<Rigidbody>().freezeRotation = true;
        //GetComponent<Rigidbody>().useGravity = false;
        ////float step = speed * Time.deltaTime;
        ////Vector3 delta = new Vector3(0, 5, 0);
        ////this.transform.position = Vector3.MoveTowards(transform.position, dest.position, step);

        //float step = speed * Time.deltaTime;
        //transform.position = Vector3.MoveTowards(transform.position, dest.position, step);


        //this.transform.position = dest.position;
        //this.transform.parent = GameObject.Find("Destination").transform;
    }

    void OnMouseUp()
    {
        on_the_move = false;
        this.transform.parent = null;
        GetComponent<Rigidbody>().useGravity = true;
        GetComponent<Rigidbody>().freezeRotation = false;
        //GetComponent<BoxCollider>().enabled = true;
    }
}
