using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickSystem : MonoBehaviour
{
    public static float clicks;

    public float showClicks;

    public Text allClicksCounter;
    public Text allClicksCounterShadow;

    private void Update()
    {
        showClicks = Mathf.RoundToInt(clicks);
        allClicksCounter.text = showClicks.ToString();
        allClicksCounterShadow.text = showClicks.ToString();
    }
}
