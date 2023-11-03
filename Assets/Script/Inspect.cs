using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;

public class Inspect : MonoBehaviour
{
    public bool inTrigger;
    public bool displayText;
    public GameObject tekst;
    bool Epressed = false;
   

    public GameObject tekstPressE;





    void OnTriggerEnter2D(Collider2D other)
    {
        inTrigger = true;
        tekstPressE.SetActive(true);
        
    }

    void OnTriggerExit2D(Collider2D other)
    {
        inTrigger = false;
        tekst.SetActive(false);
        tekstPressE.SetActive(false);
        Epressed = false;
        
    }


    private void Start()
    {
        tekst.SetActive(false);
        tekstPressE.SetActive(false);
    }

    void Update()


    {
        

        if (inTrigger)
        {
            if (Input.GetKeyDown(KeyCode.E) & !Epressed)
            {
                // make it the oppsite of whatever it was
                
                tekst.SetActive(true);
                Epressed = true;

            }

            if (Epressed)
            { tekstPressE.SetActive(false);
            }

            // this will only show text if your in the trigger and you toggled displayText to true.
    }

    }
}
