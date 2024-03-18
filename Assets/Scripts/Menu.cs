using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{
    public GameObject[] food;
    int x; // active object
    bool info;

    public void openPizza()
    {
        for (int i = 0; i < food.Length; i++)
        {
            food[i].gameObject.SetActive(false);
        }
        food[0].gameObject.SetActive(true);
        if (info){
            food[1].gameObject.SetActive(true);
        }
        x = 1;
    }

    public void openFrenchFries() 
    {
        for (int i = 0; i < food.Length; i++)
        {
            food[i].gameObject.SetActive(false);
        }
        food[2].gameObject.SetActive(true);
        if (info){
            food[3].gameObject.SetActive(true);
        }
        x = 3;
    }

    public void showInfo() 
    {
        if (info){
            info = false;
            food[x].gameObject.SetActive(false);
        }
        else if (!info){
            info = true;
            food[x].gameObject.SetActive(true);
        }
        else{
            info = true;
            food[x].gameObject.SetActive(true);
        }
    }
}



// {
//     public GameObject pizza;
//     public GameObject french_fries;

//     public void openPizza()
//     {
//         pizza.gameObject.SetActive(true);
//         french_fries.gameObject.SetActive(false);
//     }

//     public void openFrenchFries()
//     {
//         french_fries.gameObject.SetActive(true);
//         pizza.gameObject.SetActive(false);
//     }
// }
