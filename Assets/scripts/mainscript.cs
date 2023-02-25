using UnityEngine.EventSystems;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//using System;


public class mainscrupt : MonoBehaviour
{
    //readonly bool check1 = scriptImage1.isClick;
    private float speed = 600;
    public bool isSpin = false;
    bool finishRound = false;
    public int finalAngle;
    public int section = 10;
    float totalAngle;
    public string[] prizeName;
   // public Text winText;
    public Text numWinText;
    public Text coinSumText;
    public Button startButton;
    public bool buttonClick = false;
    public string winNum;

    public int numCoins;
    public bool isWin10Coins = false;
    public bool isWin20Coins = false;
    public bool isWin30Coins = false;


    // Start is called before the first frame update
    void Start()
    {
        //coinsNumText = GetComponent<Text>();
       // coinsNumText.text = numCoins.ToString();
        // scriptImage1.isClick = true;
        totalAngle = 360 / section;
        speed = Random.Range(450, 700);
        Button btn = startButton.GetComponent<Button>();
        btn.onClick.AddListener(StartBut);

    }

    // Update is called once per frame
    void Update()
    {
        coinSumText.text = "Coins: " + numCoins;

        if (buttonClick)
         {
            isSpin = true;
           Rotete();

          }
        // finalAngle = Mathf.RoundToInt(transform.eulerAngles.z);
        //print(finalAngle);
        

        //if(check1)
       // print("true1");
    

        // if (Input.GetMouseButtonDown(0))
        //   {
        //     Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        //   RaycastHit hit;

        // if (Physics.Raycast(ray, out hit))
        //{
        //  Debug.Log(hit.transform.gameObject.name);
        //}
        //}



    }

    public void Rotete()
    {
       transform.Rotate(Vector3.forward , speed * Time.deltaTime);
        //  transform.Rotate(0, 0, speed * Time.deltaTime);
        if (finishRound)
        {
            if (isWin10Coins)
                numCoins += 10;
            if (isWin20Coins)
                numCoins += 20;
            if (isWin30Coins)
                numCoins += 30;
            buttonClick = false;
        }
        if (isSpin && speed > 0)
        {
            Stop();

        }
    }

    void Stop()
    {
        speed--;
        if (speed <= 0)
        {
 
            Winning();
          //  buttonClick = false;





            
            //isSpin = false;
        }
    }

    void Winning()
    {
        //if (Mathf.RoundToInt(transform.eulerAngles.z) % totalAngle != 0)
        //   transform.Rotate(0, 0, totalAngle / 2);

        finalAngle = Mathf.RoundToInt(transform.eulerAngles.z);

        print(finalAngle);

        //   for(int i = 0; i<section; i++)
        //  {
        //    if (finalAngle == i * totalAngle)
        //      print(prizeName[i]);
        //}

        for (int i = 0; i < section; i++)
        {
            if ((finalAngle >= i * totalAngle) && finalAngle < (totalAngle + i * totalAngle))
            {
                print(prizeName[i]);
                // winText.text = "The win number is:";
                winNum = prizeName[i];
                numWinText.text = winNum;
                finishRound = true;
            }

        }
    }

    public void StartBut()
    {
        buttonClick = true;
        speed = Random.Range(450, 700);
        //print("bla");
        finishRound = false;
        isWin10Coins = false;
        isWin20Coins = false;
        isWin30Coins = false;
        winNum = "";
    }
}
