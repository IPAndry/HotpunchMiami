using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{
    public Animator menu;
    bool isOpened = false;

    public void ShowMenu()
    {
        if (isOpened == false)
        {
            menu.Play("ShopShow");
            isOpened = true;
        }
        else if (isOpened == true)
        {
            //menu.StopPlayback();
            menu.Play("HideShop");
            isOpened = false;
        }
        
    }
}
