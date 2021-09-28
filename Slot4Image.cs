using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slot4Image : MonoBehaviour
{
    //Variables for Images
    public Sprite Diamond;
    public Sprite Lemon;
    public Sprite Cherry;
    public Sprite SevenSlot;

    void Update() //Change images when slots spin
    {
        if (Controller.int4 == "1")
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = Diamond;
        }
        if (Controller.int4 == "2")
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = Lemon;
        }
        if (Controller.int4 == "3")
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = Cherry;
        }
        if (Controller.int4 == "4")
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = SevenSlot;
        }
    }
}
