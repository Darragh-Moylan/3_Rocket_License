using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour {

    Rigidbody rigidBody; //member variable
    AudioSource m_RocketThrust;

   // bool m_Play;
   // bool m_ToggleChange;

	// Use this for initialization
	void Start () {
        rigidBody = GetComponent<Rigidbody>();
        m_RocketThrust = GetComponent<AudioSource>();
    }
	
	// Update is called once per frame
	void Update () {
        ProcessInput();
	}

    private void ProcessInput()
    {
        if (Input.GetKey(KeyCode.Space)) // can thrust while rotating
        {
            rigidBody.AddRelativeForce(Vector3.up);
            if (!m_RocketThrust.isPlaying) // so it doesn't layer on top of each other
            {
                m_RocketThrust.Play();
            }
        }
        else
        {
            m_RocketThrust.Stop();
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.forward);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(-Vector3.forward);
        }
    }

    /*void PlaySound()
    {
        if (m_Play == true && m_ToggleChange == true)
        {
            m_RocketThrust.Play();
            m_ToggleChange = false;
        }
        if (m_Play == false && m_ToggleChange == true)
        {
            m_RocketThrust.Stop();
            m_ToggleChange = false;
        }
    }*/


}
