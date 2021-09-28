using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
using UnityEngine.Audio;
using System.Threading.Tasks;
using System;
using System.Linq;

public class Controller : MonoBehaviour
{
    //Variables
    public string playerName = "";
    public InputField playername;
    public TMP_Text playernametext;
    public int chips = 0;
    public TMP_Text chipstext;
    public AudioMixer mixer;
    public int Bet = 10;
    public int WinAmount= 0;
    public string WinBet;
    public static string int1, int2, int3, int4;
    List<string> bets = new List<string>(); //Keep track of player bets in roulette

    //Functions
    public void Start()
    {
        LoadChips();
        LoadplayerName();
        playernametext.text = playerName;
        chipstext.text = chips.ToString();
    }
    public void Update()
    {
        SetWinBet();
        GetWinBet();
        Setint1();
        Setint2();
        Setint3();
        Setint4();
        Getint1();
        Getint2();
        Getint3();
        Getint4();
        LoadChips();
        chipstext.text = chips.ToString();
    }
      
    public void ResetList() //Clear
    {
        bets.Clear();
    }

    /*public void PrintList() //Used for testing
    {
        foreach (string var in bets)
        {
            Debug.Log(var);
        }
    }*/

    public async void CheckListWin() //Calculate roulette winnings
    {
        await Task.Delay(5000); //Time delay to wait for results
        if (bets.Contains(WinBet) == true)
        {
            Debug.Log("You Won: " + (Bet * WinAmount)+ " Coins!");
            chips = chips + (Bet * WinAmount);
            SaveChips();
        }
    }
    public string Getint1()
    {
        return int1;
    }
    public string Getint2()
    {
        return int2;
    }
    public string Getint3()
    {
        return int3;
    }
    public string Getint4()
    {
        return int4;
    }
    public void Setint1()
    {
        int1 = Slots.test1;
    }
    public void Setint2()
    {
        int2 = Slots.test2;
    }
    public void Setint3()
    {
        int3 = Slots.test3;
    }
    public void Setint4()
    {
        int4 = Slots.test4;
    }
    public string GetWinBet()
    {
        return WinBet;
    }
    public void SetWinBet()
    {
        WinBet = pointer.LastWin;
    }
    public void OnGameSave()
    {
        SaveplayerName();
        SaveChips();
    }
    // Save and update player information
    public void SaveplayerName()
    {
        playerName = playername.text;
        PlayerPrefs.SetString("Player Name", playerName);
    }
    public void LoadplayerName()
    {
        playerName = PlayerPrefs.GetString("Player Name");

    }
    public void SaveChips()
    {
        PlayerPrefs.SetInt("Chips", chips);

    }
    public void LoadChips()
    {
        chips = PlayerPrefs.GetInt("Chips");

    }
    //Functions for player to choose amount to bet on games
    public void ChangeBet10()
    {
        Bet = 10;
    }
    public void ChangeBet20()
    {
        Bet = 20;
    }
    public void ChangeBet50()
    {
        Bet = 50;
    }
    public void ChangeBet100()
    {
        Bet = 100;
    }
    public async void SlotsBet()
    {
        await Task.Delay(1000); //Time delay to prevent spamming bets
        chips = chips - Bet;
        SaveChips();
    }
 
    //All Roulette Betting Functions
    //------------------------------------------------------------------------------------------------------------
    //All 35:1 Bets
    public void ZeroZero()
    {
        chips = chips - Bet;
        SaveChips();
        WinAmount = 35;
        bets.Add("00");       
    }
    public void Zero()
    {
        chips = chips - Bet;
        SaveChips();
        WinAmount = 35;
        bets.Add("0");
    }
    public void One()
    {
        chips = chips - Bet;
        SaveChips();
        WinAmount = 35;
        bets.Add("1");
    }
    public void Two()
    {
        chips = chips - Bet;
        SaveChips();
        WinAmount = 35;
        bets.Add("2");
    }
    public void Three()
    {
        chips = chips - Bet;
        SaveChips();
        WinAmount = 35;
        bets.Add("3");
    }
    public void Four()
    {
        chips = chips - Bet;
        SaveChips();
        WinAmount = 35;
        bets.Add("4");
    }
    public void Five()
    {
        chips = chips - Bet;
        SaveChips();
        WinAmount = 35;
        bets.Add("5");
    }
    public void Six()
    {
        chips = chips - Bet;
        SaveChips();
        WinAmount = 35;
        bets.Add("6");
    }
    public void Seven()
    {
        chips = chips - Bet;
        SaveChips();
        WinAmount = 35;
        bets.Add("7");
    }
    public void Eight()
    {
        chips = chips - Bet;
        SaveChips();
        WinAmount = 35;
        bets.Add("8");
    }
    public void Nine()
    {
        chips = chips - Bet;
        SaveChips();
        WinAmount = 35;
        bets.Add("9");
    }
    public void Ten()
    {
        chips = chips - Bet;
        SaveChips();
        WinAmount = 35;
        bets.Add("10");
    }
    public void Eleven()
    {
        chips = chips - Bet;
        SaveChips();
        WinAmount = 35;
        bets.Add("11");
    }
    public void Twelve()
    {
        chips = chips - Bet;
        SaveChips();
        WinAmount = 35;
        bets.Add("12");
    }
    public void Thirteen()
    {
        chips = chips - Bet;
        SaveChips();
        WinAmount = 35;
        bets.Add("13");
    }
    public void Fourteen()
    {
        chips = chips - Bet;
        SaveChips();
        WinAmount = 35;
        bets.Add("14");
    }
    public void Fifteen()
    {
        chips = chips - Bet;
        SaveChips();
        WinAmount = 35;
        bets.Add("15");
    }
    public void Sixteen()
    {
        chips = chips - Bet;
        SaveChips();
        WinAmount = 35;
        bets.Add("16");
    }
    public void Seventeen()
    {
        chips = chips - Bet;
        SaveChips();
        WinAmount = 35;
        bets.Add("17");
    }
    public void Eightteen()
    {
        chips = chips - Bet;
        SaveChips();
        WinAmount = 35;
        bets.Add("18");
    }
    public void NineTeen()
    {
        chips = chips - Bet;
        SaveChips();
        WinAmount = 35;
        bets.Add("19");
    }
    public void Twenty()
    {
        chips = chips - Bet;
        SaveChips();
        WinAmount = 35;
        bets.Add("20");
    }
    public void TwentyOne()
    {
        chips = chips - Bet;
        SaveChips();
        WinAmount = 35;
        bets.Add("21");
    }
    public void TwentyTwo()
    {
        chips = chips - Bet;
        SaveChips();
        WinAmount = 35;
        bets.Add("22");
    }
    public void TwentyThree()
    {
        chips = chips - Bet;
        SaveChips();
        WinAmount = 35;
        bets.Add("23");
    }
    public void TwentyFour()
    {
        chips = chips - Bet;
        SaveChips();
        WinAmount = 35;
        bets.Add("24");
    }
    public void TwentyFive()
    {
        chips = chips - Bet;
        SaveChips();
        WinAmount = 35;
        bets.Add("25");
    }
    public void TwentySix()
    {
        chips = chips - Bet;
        SaveChips();
        WinAmount = 35;
        bets.Add("26");
    }
    public void TwentySeven()
    {
        chips = chips - Bet;
        SaveChips();
        WinAmount = 35;
        bets.Add("27");
    }
    public void TwentyEight()
    {
        chips = chips - Bet;
        SaveChips();
        WinAmount = 35;
        bets.Add("28");
    }
    public void TwentyNine()
    {
        chips = chips - Bet;
        SaveChips();
        WinAmount = 35;
        bets.Add("29");
    }
    public void Thirty()
    {
        chips = chips - Bet;
        SaveChips();
        WinAmount = 35;
        bets.Add("30");
    }
    public void ThirtyOne()
    {
        chips = chips - Bet;
        SaveChips();
        WinAmount = 35;
        bets.Add("31");
    }
    public void ThirtyTwo()
    {
        chips = chips - Bet;
        SaveChips();
        WinAmount = 35;
        bets.Add("32");
    }
    public void ThirtyThree()
    {
        chips = chips - Bet;
        SaveChips();
        WinAmount = 35;
        bets.Add("33");
    }
    public void ThirtyFour()
    {
        chips = chips - Bet;
        SaveChips();
        WinAmount = 35;
        bets.Add("34");
    }
    public void ThirtyFive()
    {
        chips = chips - Bet;
        SaveChips();
        WinAmount = 35;
        bets.Add("35");
    }
    public void ThirtySix()
    {
        chips = chips - Bet;
        SaveChips();
        WinAmount = 35;
        bets.Add("36");
    }
    //All 2:1 Bets
    public void TwoToOneTop() //Betting all top row
    {
        chips = chips - Bet;
        SaveChips();
        WinAmount = 3;
        bets.Add("3");
        bets.Add("6");
        bets.Add("9");
        bets.Add("12");
        bets.Add("15");
        bets.Add("18");
        bets.Add("21");
        bets.Add("24");
        bets.Add("27");
        bets.Add("30");
        bets.Add("33");
        bets.Add("36");
    }
    public void TwoToOneMiddle() //Betting all middle row
    {
        chips = chips - Bet;
        SaveChips();
        WinAmount = 3;
        bets.Add("2");
        bets.Add("5");
        bets.Add("8");
        bets.Add("11");
        bets.Add("14");
        bets.Add("17");
        bets.Add("20");
        bets.Add("23");
        bets.Add("26");
        bets.Add("29");
        bets.Add("32");
        bets.Add("35");
    }
    public void TwoToOneBottom() //Betting all bottom row
    {
        chips = chips - Bet;
        SaveChips();
        WinAmount = 3;
        bets.Add("1");
        bets.Add("4");
        bets.Add("7");
        bets.Add("10");
        bets.Add("13");
        bets.Add("16");
        bets.Add("19");
        bets.Add("22");
        bets.Add("25");
        bets.Add("28");
        bets.Add("31");
        bets.Add("34");
    }
    public void FirstTwelve() //Betting 1-12
    {
        chips = chips - Bet;
        SaveChips();
        WinAmount = 3;
        bets.Add("1");
        bets.Add("2");
        bets.Add("3");
        bets.Add("4");
        bets.Add("5");
        bets.Add("6");
        bets.Add("7");
        bets.Add("8");
        bets.Add("9");
        bets.Add("10");
        bets.Add("11");
        bets.Add("12");
    }
    public void SecondTwelve() //Betting 13-24
    {
        chips = chips - Bet;
        SaveChips();
        WinAmount = 3;
        bets.Add("13");
        bets.Add("14");
        bets.Add("15");
        bets.Add("16");
        bets.Add("17");
        bets.Add("18");
        bets.Add("19");
        bets.Add("20");
        bets.Add("21");
        bets.Add("22");
        bets.Add("23");
        bets.Add("24");
    }
    public void ThirdTwelve() //Betting 25-36
    {
        chips = chips - Bet;
        SaveChips();
        WinAmount = 3;
        bets.Add("25");
        bets.Add("26");
        bets.Add("27");
        bets.Add("28");
        bets.Add("29");
        bets.Add("30");
        bets.Add("31");
        bets.Add("32");
        bets.Add("33");
        bets.Add("34");
        bets.Add("35");
        bets.Add("36");
    }
    //All 1:1 Bets
    public void OneToEightTeen() //Betting 1-18
    {
        chips = chips - Bet;
        SaveChips();
        WinAmount = 2;
        bets.Add("1");
        bets.Add("2");
        bets.Add("3");
        bets.Add("4");
        bets.Add("5");
        bets.Add("6");
        bets.Add("7");
        bets.Add("8");
        bets.Add("9");
        bets.Add("10");
        bets.Add("11");
        bets.Add("12");
        bets.Add("13");
        bets.Add("14");
        bets.Add("15");
        bets.Add("16");
        bets.Add("17");
        bets.Add("18");
    }
    public void NineteentoThirtySix() //Betting 19-36
    {
        chips = chips - Bet;
        SaveChips();
        WinAmount = 2;
        bets.Add("19");
        bets.Add("20");
        bets.Add("21");
        bets.Add("22");
        bets.Add("23");
        bets.Add("24");
        bets.Add("25");
        bets.Add("26");
        bets.Add("27");
        bets.Add("28");
        bets.Add("29");
        bets.Add("30");
        bets.Add("31");
        bets.Add("32");
        bets.Add("33");
        bets.Add("34");
        bets.Add("35");
        bets.Add("36");
    }
    public void Even() //Betting all even numbers
    {
        chips = chips - Bet;
        SaveChips();
        WinAmount = 2;
        bets.Add("2");
        bets.Add("4");
        bets.Add("6");
        bets.Add("8");
        bets.Add("10");
        bets.Add("12");
        bets.Add("14");
        bets.Add("16");
        bets.Add("18");
        bets.Add("20");
        bets.Add("22");
        bets.Add("24");
        bets.Add("26");
        bets.Add("28");
        bets.Add("30");
        bets.Add("32");
        bets.Add("34");
        bets.Add("36");
    }
    public void Odds() //Betting all odd numbers
    {
        chips = chips - Bet;
        SaveChips();
        WinAmount = 2;
        bets.Add("1");
        bets.Add("3");
        bets.Add("5");
        bets.Add("7");
        bets.Add("9");
        bets.Add("11");
        bets.Add("13");
        bets.Add("15");
        bets.Add("17");
        bets.Add("19");
        bets.Add("21");
        bets.Add("23");
        bets.Add("25");
        bets.Add("27");
        bets.Add("29");
        bets.Add("31");
        bets.Add("33");
        bets.Add("35");
    }
    public void Red() //Betting all red spaces
    {
        chips = chips - Bet;
        SaveChips();
        WinAmount = 2;
        bets.Add("1");
        bets.Add("3");
        bets.Add("5");
        bets.Add("7");
        bets.Add("9");
        bets.Add("12");
        bets.Add("14");
        bets.Add("16");
        bets.Add("18");
        bets.Add("19");
        bets.Add("21");
        bets.Add("23");
        bets.Add("25");
        bets.Add("27");
        bets.Add("30");
        bets.Add("32");
        bets.Add("34");
        bets.Add("36");
    }
    public void Black() //Betting all black spaces
    {
        chips = chips - Bet;
        SaveChips();
        WinAmount = 2;
        bets.Add("2");
        bets.Add("4");
        bets.Add("6");
        bets.Add("8");
        bets.Add("10");
        bets.Add("11");
        bets.Add("13");
        bets.Add("15");
        bets.Add("17");
        bets.Add("20");
        bets.Add("22");
        bets.Add("24");
        bets.Add("26");
        bets.Add("28");
        bets.Add("29");
        bets.Add("31");
        bets.Add("33");
        bets.Add("35");
    }

    //-----------------------------------------------------------------------------------------------------------
    //Slots Win Conditions
    public async void CalResults()
    {
        await Task.Delay(1200);

        //Debug.Log(int1); Used for testing
        //Debug.Log(int2);
        //Debug.Log(int3);
        //Debug.Log(int4);

        //4/4 Jackpot Bets
        if (int1 == "1" && int2 == "1" && int3 == "1" && int4 == "1")
        {
            chips = chips + (Bet * 1000);
            SaveChips();
        }

        else if (int1 == "2" && int2 == "2" && int3 == "2" && int4 == "2")
        {
            chips = chips + (Bet * 500);
            SaveChips();
        }
        else if (int1 == "3" && int2 == "3" && int3 == "3" && int4 == "3")
        {
            chips = chips + (Bet * 500);
            SaveChips();

        }
        else if (int1 == "4" && int2 == "4" && int3 == "4" && int4 == "4")
        {
            chips = chips + (Bet * 500);
            SaveChips();

        }
        // 3/4 Bets
        else if (int1 == "1" && int2 == "1" && int3 == "1")
        {
            chips = chips + (Bet * 50);
                SaveChips();
        }
        else if (int1 == "2" && int2 == "2" && int3 == "2")
        {
            chips = chips + (Bet * 50);
                SaveChips(); 
        }
        else if (int1 == "3" && int2 == "3" && int3 == "3")
        {
            chips = chips + (Bet * 50);
                SaveChips();
        }
        else if (int1 == "4" && int2 == "4" && int3 == "4")
        {
            chips = chips + (Bet * 50);
            SaveChips();
        }
        else if (int2 == "1" && int3 == "1" && int4 == "1")
        {
            chips = chips + (Bet * 50);
                SaveChips();
        }
        else if (int2 == "2" && int3 == "2" && int4 == "2")
        {
            chips = chips + (Bet * 50);
                SaveChips();
        }
        else if (int2 == "3" && int3 == "3" && int4 == "3")
        {
            chips = chips + (Bet * 50);
                SaveChips();
        }
        else if (int2 == "4" && int3 == "4" && int4 == "4")
        {
            chips = chips + (Bet * 50);
            SaveChips();
        }
        /* Too easy to win so for now keep it out of the game.
        else if (int1 == "1" && int3 == "1" && int4 == "1")
        {
            chips = chips + (Bet * 100);
                SaveChips();
        }
        else if (int1 == "2" && int3 == "2" && int4 == "2")
        {
            chips = chips + (Bet * 100);
                SaveChips();
        }
        else if (int1 == "3" && int3 == "3" && int4 == "3")
        {
            chips = chips + (Bet * 100);
                SaveChips();
        }
        else if (int1 == "4" && int3 == "4" && int4 == "4")
        {
            chips = chips + (Bet * 100);
            SaveChips();
        }
        else if (int1 == "1" && int2 == "1" && int4 == "1")
        {
            chips = chips + (Bet * 100);
                SaveChips();
        }
        else if (int1 == "2" && int2 == "2" && int4 == "2")
        {
            chips = chips + (Bet * 100);
                SaveChips();
        }
        else if (int1 == "3" && int2 == "3" && int4 == "3")
        {
            chips = chips + (Bet * 100);
                SaveChips();
        }
        else if (int1 == "4" && int2 == "4" && int4 == "4")
        {
            chips = chips + (Bet * 100);
            SaveChips();
        }
        // 2/4 bets
        /*
        else if (int1 == "1" && int2 == "1")
        {
            chips = chips + (Bet * 10);
                SaveChips();
        }
        else if (int1 == "2" && int2 == "2")
        {
            chips = chips + (Bet * 10);
                SaveChips();
        }
        else if (int1 == "3" && int2 == "3")
        {
            chips = chips + (Bet * 10);
                SaveChips();
        }
        else if (int1 == "1" && int3 == "1")
        {
            chips = chips + (Bet * 10);
                SaveChips();
        }
        else if (int1 == "2" && int3 == "2")
        {
            chips = chips + (Bet * 10);
                SaveChips();
        }
        else if (int1 == "3" && int3 == "3")
        {
            chips = chips + (Bet * 10);
                SaveChips();
        }
        else if (int1 == "1" && int4 == "1")
        {
            chips = chips + (Bet * 10);
                    SaveChips();
        }
        else if (int1 == "2" && int4 == "2")
        {
            chips = chips + (Bet * 10);
                SaveChips();
        }
        else if (int1 == "3" && int4 == "3")
        {
            chips = chips + (Bet * 10);
                SaveChips();
        }
        else if (int2 == "1" && int3 == "1")
        {
            chips = chips + (Bet * 10);
                SaveChips();
        }
        else if (int2 == "2" && int3 == "2")
        {
            chips = chips + (Bet * 10);
                SaveChips();
        }
        else if (int2 == "3" && int3 == "3")
        {
            chips = chips + (Bet * 10);
                SaveChips();
        }
        else if (int2 == "1" && int4 == "1")
        {
            chips = chips + (Bet * 10);
                SaveChips();
        }
        else if (int2 == "2" && int4 == "2")
        {
            chips = chips + (Bet * 10);
                SaveChips();

        }
        else if (int2 == "3" && int4 == "3")
        {
            chips = chips + (Bet * 10);
                SaveChips();
        }
        else if (int3 == "1" && int4 == "1")
        {
            chips = chips + (Bet * 10);
                SaveChips();
        }
        else if (int3 == "2" && int4 == "2")
        {
            chips = chips + (Bet * 10);
                SaveChips();
        }
        else if (int3 == "3" && int4 == "3")
        {
            chips = chips + (Bet * 10);
                SaveChips();
        }
        */
    }

    //-----------------------------------------------------------------------------------------------------------
    //SceneManager Functions to launch different game scenes
    public void Play()
    {
        LoadplayerName();
        LoadChips();
        if (playerName == "") //Launch screen to create new player
        {
            SceneManager.LoadScene("NewPlayer");
        }
        else if (playerName != "") //Load name for returning players
        {

            SceneManager.LoadScene("CasinoFloor");
        }
    }
    public void NewPlayer()
    {
        SceneManager.LoadScene("NewPlayer");
    }
    public void CasinoFloor()
    {
        chips = 2000; //New players starting chip amount
        SaveChips();
        SaveplayerName();
        Debug.Log("Player Name is: " + playername.text);
        SceneManager.LoadScene("CasinoFloor");
    }
    public void CasinoFloor2()
    {       
        SceneManager.LoadScene("CasinoFloor");
    }
    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
    //Games
    public void Roulette()
    {
        SceneManager.LoadScene("Roulette");
    }
    public void Slot()
    {
        SceneManager.LoadScene("Slots");
    }
    public void BlackJack()
    {
        SceneManager.LoadScene("BlackJack");
    }
    //Help and How to Play
    public void Help()
    {
        SceneManager.LoadScene("Help");
    }
    public void HowToPlayRoulette()
    {
        SceneManager.LoadScene("HowToPlayRoulette");
    }
    public void HowToPlayBlackJack()
    {
        SceneManager.LoadScene("HowToPlayBlackJack");
    }
    public void HowToPlaySlots()
    {
        SceneManager.LoadScene("HowToPlaySlots");
    }
    //Settings
    public void SettingsRoulette()
    {
        SaveChips();
        SceneManager.LoadScene("Settings-Roulette");
    }
    public void SettingsBlackJack()
    {
        SaveChips();
        SceneManager.LoadScene("Settings-BlackJack");
    }
    public void SettingsSlots()
    {
        SaveChips();
        SceneManager.LoadScene("Settings-Slots");
    }
    public void Settings()
    {
        SceneManager.LoadScene("Settings");
    }
    //Quit application
    public void Quit()
    {
        Application.Quit();
    }
}

