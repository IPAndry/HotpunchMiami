using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClearClickSystem : MonoBehaviour
{
    public static int punchPower = 1;

    public static int clearClicks;

    public Text clearClicksCounter;

    private void OnMouseDown()
    {


        clearClicks++;
        
        ClickSystem.clicks++;

        if (ShopItems.hammer == true)
        {
            ClickSystem.clicks++;
            punchPower = 2;
        }

    }

    private void Update()
    {
        clearClicksCounter.text = clearClicks.ToString();
        //clearClicksCounterShadow.text = clearClicks.ToString();
    }
}
