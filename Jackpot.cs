using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jackpot : MonoBehaviour
{
    //Variables for Images
    public Sprite jackpotImage;
    public Sprite empty;

    // Update is called once per frame
    void Update() //Show Jackpot when occurs, otherwise no image
    {
        if (Controller.int1 == "1" && Controller.int2 == "1" && Controller.int3 == "1" && Controller.int4 == "1")
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = jackpotImage;
        }
        else
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = empty;
        }
 
    }
}
