using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scriptImage1 : MonoBehaviour
{

    public bool isClick = false;
    public mainscrupt mainScrip;
    public coins coins;
    public bool startButClick = false;
    public int winNam = 0;
    public Image img;
    public Image coin10, coin20, coin30;
    public Text winText;
  //  public int numCoins;
   // public  bool isWin10Coins = false;
 //   public  bool isWin20Coins = false;
  //  public  bool isWin30Coins = false;


    // Start is called before the first frame update
    void Start()
    {

    }
   public void ClickOnImg1()
    {
        print("pic1");
       // img.GetComponent<Image>().color = Color.cyan;
        string name = img.sprite.name;
        print(name);
        //print(img.transform.position);
        if (coins.clickCoin10)
        {
          coin10.transform.position = img.transform.position;
          coin10.rectTransform.sizeDelta = new Vector2(50,50);
        }
        if (coins.clickCoin20)
        {
            coin20.transform.position = img.transform.position;
            coin20.rectTransform.sizeDelta = new Vector2(50, 50);
        }
        if (coins.clickCoin30)
        {
            coin30.transform.position = img.transform.position;
            coin30.rectTransform.sizeDelta = new Vector2(50, 50);
        }

    }
    // Update is called once per frame
    void Update()
    {

        winNam = mainScrip.finalAngle;
       // print(winNam);
        if (mainScrip.buttonClick)
        {
            startButClick = true;
            print("bla");
        }

        // if (img.color == Color.cyan && img.sprite.name == mainScrip.winNum )
        //    print("karin" + img.sprite.name);
        // if (Input.GetMouseButtonDown(0))
        //  {
        //     print("chake1");
        //     isClick = true;
        // }
       // if (!mainScrip.isSpin)
       // {
            if (coin10.transform.position == img.transform.position && img.sprite.name == mainScrip.winNum)
            {
                print("coin10 " + img.sprite.name);
                winText.text = "You Win On 10 Coins";
                mainScrip.isWin10Coins = true;
                //mainScrip.numCoins += 10;
               // print(numCoins);
            }

            if (coin20.transform.position == img.transform.position && img.sprite.name == mainScrip.winNum)
            {
                print("coin20 " + img.sprite.name);
                winText.text = "You Win On 20 Coins";
                mainScrip.isWin20Coins = true;
               //  mainScrip.numCoins += 20;
               //  print(numCoins);
            }


            if (coin30.transform.position == img.transform.position && img.sprite.name == mainScrip.winNum)
            {
                print("coin30 " + img.sprite.name);
                winText.text = "You Win On 30 Coins";
                mainScrip.isWin30Coins = true;
                //mainScrip.numCoins += 30;
                 // print(numCoins);
            }
      //  }

    }
}
