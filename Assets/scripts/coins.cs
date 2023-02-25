using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class coins : MonoBehaviour
{

    public bool clickCoin10 = false;
    public bool clickCoin20 = false;
    public bool clickCoin30 = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ClickOnCoin10()
    {
      clickCoin10 = true;
      clickCoin20 = false;
      clickCoin30 = false;
        print("click10");
    }

    public void ClickOnCoin20()
    {
        clickCoin10 = false;
        clickCoin20 = true;
        clickCoin30 = false;
        print("click20");
    }

    public void ClickOnCoin30()
    {
        clickCoin10 = false;
        clickCoin20 = false;
        clickCoin30 = true;
        print("click30");
    }
}
