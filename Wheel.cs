using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;

public class Wheel : MonoBehaviour
{
    //Variables
    public bool spin = true;
    private float Speed;
    public float maxSpeed = 300;
    public GameObject pointer;

    //Functions
    public void Start()
    {
        pointer.GetComponent<BoxCollider>().enabled = false;
        Speed = maxSpeed;
    }

    public void Update()
    {
        SpinWheel();
    }

    public void SpinWheel()
    {
        transform.Rotate(0, 0, Speed * Time.deltaTime);
        if (spin == false && Speed > 0)
        {
            Stop();
        }
    }

    public async void Stop()
    {
        //Delay stop to discourage cheating
        spin = false;
        await Task.Delay(3000);
        --Speed; //Slowly decrease speed
        if (Speed <= 0)
        {
            pointer.GetComponent<BoxCollider>().enabled = true;
            Speed = 0; //Ball stops spinning
            spin = false;
        }
    }

    public async void Reset()
    {
        //Delay reset to discourage cheating
        await Task.Delay(2000);
        spin = true; //Set ball to start spinning again
        pointer.GetComponent<BoxCollider>().enabled = false;
        Speed = maxSpeed;  
    }
}
