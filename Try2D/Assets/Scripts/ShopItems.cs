using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopItems : MonoBehaviour
{
    public static bool hammer = false;
    public GameObject hammerImage;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            hammer = true;
        }

        
    }

    public void HammerBuy()
    {
        if (ClickSystem.clicks >= 100 && hammer == false)
        {
            ClickSystem.clicks -= 100;
            hammer = true;
            Instantiate(hammerImage);
        }
    }
}
