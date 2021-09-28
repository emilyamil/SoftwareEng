using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slot1Image : MonoBehaviour
{
    //Variables for Images
    public Sprite Diamond;
    public Sprite Lemon;
    public Sprite Cherry;
    public Sprite SevenSlot;

    void Update() //Change images when slots spin
    {
        if (Controller.int1 == "1")
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = Diamond;
        }
        if (Controller.int1 == "2")
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = Lemon;
        }
        if (Controller.int1 == "3")
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = Cherry;
        }
        if (Controller.int1 == "4")
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = SevenSlot;
        }
    }
}
