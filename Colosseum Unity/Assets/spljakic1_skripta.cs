using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spljakic1_skripta : MonoBehaviour
{

    Ray ray;
    RaycastHit hit;

    public GameObject spljakic1_eagle;
    public GameObject spljakic1_eagle1;
    public GameObject spljakic1_eagle2;
    public GameObject spljakic1_video;
    public GameObject spljakic1_slike;
    public GameObject spljakic1_tekst;
  
    // Use this for initialization
    void Start()
    {
        spljakic1_video.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        spljakic1_slike.SetActive(false);
        spljakic1_tekst.SetActive(false);
      
        if (Physics.Raycast(ray, out hit))
        {
            if (hit.collider.gameObject.name == "spljakic1_eagle")
            {
                spljakic1_video.SetActive(true);
                spljakic1_slike.SetActive(false);
                spljakic1_tekst.SetActive(false);
            }
            if (hit.collider.gameObject.name == "spljakic1_eagle1")
            {
                spljakic1_tekst.SetActive(true);
                spljakic1_video.SetActive(false);
                spljakic1_slike.SetActive(false);
            }
            if (hit.collider.gameObject.name == "spljakic1_eagle2")
            {
                spljakic1_slike.SetActive(true);
                spljakic1_tekst.SetActive(false);
                spljakic1_video.SetActive(false);
            }

        } 
    }

}
   