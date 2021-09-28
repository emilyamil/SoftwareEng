using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
using TMPro;
using System.Threading.Tasks;


public class Slots : MonoBehaviour
{
    //Variables
    public TMP_Text symbol1, symbol2, symbol3, symbol4;
    public string symbol1s, symbol2s, symbol3s, symbol4s;
    public string result;
    public GameObject Lever;
    int ran1, ran2, ran3, ran4;
    public static string test1, test2, test3, test4;

    //Functions
    public void Start()
    {
        // Empty upon launching game
        symbol1.text = "";
        symbol2.text = "";
        symbol3.text = "";
        symbol4.text = "";
    }

    public void Update()
    {
        //Keep variables constantly updated
        test1 = ran1.ToString();
        test2 = ran2.ToString();
        test3 = ran3.ToString();
        test4 = ran3.ToString();
    }

    public async void Pull_Lever()
    {
        //When player clicks to pull lever
        await Task.Delay(1000); //Time delay to force wait

        //Generate random results
        ran1 = Random.Range(1, 5);
        ran2 = Random.Range(1, 5);
        ran3 = Random.Range(1, 5);
        ran4 = Random.Range(1, 5);

        //Send to strings for later comparison
        symbol1.text = ran1.ToString();
        symbol1s = symbol1.ToString();
        symbol2.text = ran2.ToString();
        symbol2s = symbol2.ToString();
        symbol3.text = ran3.ToString();
        symbol3s = symbol3.ToString();
        symbol4.text = ran4.ToString();
        symbol4s = symbol4.ToString();
    }
}
