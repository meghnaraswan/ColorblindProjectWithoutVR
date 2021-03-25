﻿//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;

public class ThrowObjects : MonoBehaviour
{
    public Transform player;
    public Transform playerCam;
    public float throwForce = 10;
    bool hasPlayer = false;
    bool beingCarried = false;
/*    public AudioClip[] soundToPlay;
    private AudioSource audio;
    public int dmg;*/
    private bool touched = false;
    public Rigidbody rb;

/*    void Start()
    {
        audio = GetComponent<AudioSource>();
    }*/

    void Update()
    {
        float dist = Vector3.Distance(gameObject.transform.position, player.position);
        hasPlayer = (dist <= 2.5f);
        //if (dist <= 2.5f)
        //{
        //    hasPlayer = true;
        //}
        //else
        //{
        //    hasPlayer = false;
        //}

        //if (hasPlayer && Input.GetButtonDown("Use"))
        //{
        //    //GetComponent<Rigidbody>().isKinematic = true;
        //    rb.isKinematic = true;
        //    transform.parent = playerCam;
        //    beingCarried = true;
        //}
        if (beingCarried)
        {
            if (touched)
            {
                //GetComponent<Rigidbody>().isKinematic = false;
                rb.isKinematic = false;
                transform.parent = null;
                beingCarried = false;
                touched = false;
            }
            if (Input.GetMouseButtonDown(0))
            {
                //GetComponent<Rigidbody>().isKinematic = false;
                rb.isKinematic = false;
                transform.parent = null;
                beingCarried = false;
                //GetComponent<Rigidbody>().AddForce(playerCam.forward * throwForce);
                //rb.AddForce(playerCam.forward * throwForce);
                /*                RandomAudio();*/
            }
            else if (Input.GetMouseButtonDown(1))
            {
                //GetComponent<Rigidbody>().isKinematic = false;
                rb.isKinematic = false;
                transform.parent = null;
                beingCarried = false;
            }
        }
    }
/*    void RandomAudio()
    {
        if (audio.isPlaying)
        {
            return;
        }
        audio.clip = soundToPlay[Random.Range(0, soundToPlay.Length)];
        audio.Play();

    }*/
    void OnTriggerEnter()
    {
        if (beingCarried)
        {
            touched = true;
        }
    }
}
