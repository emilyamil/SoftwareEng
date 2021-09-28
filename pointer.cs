using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class pointer : MonoBehaviour
{
    public static string LastWin = "";
    public TMP_Text LastWintxt;

    void OnTriggerEnter(Collider col)
    {
        Debug.Log(col.gameObject.name + " Wins!");
        LastWin = col.gameObject.name;
        LastWintxt.text = LastWin;
    }
}
