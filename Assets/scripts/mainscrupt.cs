using UnityEngine.EventSystems;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//using System;


public class mainscript : MonoBehaviour
{
    //readonly bool check1 = scriptImage1.isClick;
    private float speed = 0;
    public bool isSpin = false;

    public int finalAngle;
    public int section = 10;
    float totalAngle;
    public string[] prizeName;
    public Text winText;
    public Text numWinText;
    public Button startButton;
    public bool buttonClick = false;
    public string winNum;

    public scriptImage1 scripIM;
    
    // Start is called before the first frame update
    void Start()
    {

       // scriptImage1.isClick = true;
        isSpin = true;
        totalAngle = 360 / section;
        speed = Random.Range(450, 700);
        Button btn = startButton.GetComponent<Button>();
        btn.onClick.AddListener(StartBut);

    }

    // Update is called once per frame
    void Update()
    {
        if (scripIM.isClick)
            print("reuw");

         if (buttonClick)
         {
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
            speed = 0;
            Winning();
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
                numWinText.text = prizeName[i];
                winNum = prizeName[i];
            }

        }
    }

    void StartBut()
    {
        buttonClick = true;
        print("bla");
    }
}
