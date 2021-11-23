using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoClickSystem : MonoBehaviour
{
    public static int autoClicks;

    int clearClick;

    private void Update()
    {
        clearClick = ClearClickSystem.clearClicks;

        if (clearClick >= 10 &&
            clearClick <= 19)
        {
            AutoClick(1);
        }
        else if (clearClick >= 20 &&
                 clearClick <= 29)
        {
            AutoClick(2);
        }
        else if (clearClick >= 30 &&
                 clearClick <= 39)
        {
            AutoClick(3);
        }
        else if (clearClick >= 40 &&
                 clearClick <= 49)
        {
            AutoClick(4);
        }
        else if (clearClick >= 50)
        {
            AutoClick(5);
        }

    }

    public void AutoClick(int clearClicksNumber)
    {
        autoClicks = clearClicksNumber;
        ClickSystem.clicks += clearClicksNumber * Time.deltaTime;
    }
}
