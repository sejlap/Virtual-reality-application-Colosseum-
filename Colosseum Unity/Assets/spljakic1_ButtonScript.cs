using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spljakic1_ButtonScript : MonoBehaviour {

 




    public GameObject Panel;


    public void OpenPanel()
    {

        if (Panel != null)
        {
            bool isActive = Panel.activeSelf;

            Panel.SetActive(!isActive);
        }

    }


    public void izlaz()
    { 
         Application.Quit();
    }
}
