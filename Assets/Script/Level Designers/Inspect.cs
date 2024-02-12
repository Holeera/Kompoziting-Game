using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(BoxCollider2D))]
public class Inspect : MonoBehaviour
{
    public bool inTrigger;
    public bool displayText;
    public GameObject tekst;
    bool EPressed = false;

    [SerializeField] GameObject NadjaTeskt1;
    [SerializeField] GameObject NadjaTeskt2;
    [SerializeField] GameObject NadjaTeskt3;
    [SerializeField] GameObject NadjaTeskt4;

    public GameObject tekstPressE;
    int count = 0;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))

        {
            inTrigger = true;
            tekstPressE.SetActive(true);

        }

        
    }

    private void HandleNadja()
    {
        if (EPressed)
        {
            if (this.gameObject.name == "Coworker Trigger")
            {
                switch (count)
                {
                    case 0:
                        NadjaTeskt4.SetActive(false);
                        NadjaTeskt3.SetActive(false);
                        NadjaTeskt2.SetActive(false);
                        NadjaTeskt1.SetActive(true);
                        count += 1;
                        EPressed = false;
                        break;
                    case 1:
                        NadjaTeskt1.SetActive(false);
                        NadjaTeskt4.SetActive(false);
                        NadjaTeskt3.SetActive(false);
                        NadjaTeskt2.SetActive(true);
                        count += 1;
                        EPressed = false;
                        break;
                    case 2:
                        NadjaTeskt2.SetActive(false);
                        NadjaTeskt4.SetActive(false);
                        NadjaTeskt1.SetActive(false);
                        NadjaTeskt3.SetActive(true);
                        count += 1;
                        EPressed = false;
                        break;
                    case 3:
                        NadjaTeskt3.SetActive(false);
                        NadjaTeskt1.SetActive(false);
                        NadjaTeskt2.SetActive(false);
                        NadjaTeskt4.SetActive(true);
                        count = 0;
                        EPressed = false;
                        break;
                }
            }
            else if (this.gameObject.name != "Coworker Trigger")
            {
                tekstPressE.SetActive(true);
            }
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            inTrigger = false;
            tekst.SetActive(false);
            tekstPressE.SetActive(false);
            EPressed = false;

        }
    }

    void Start()
    {
        tekst.SetActive(false);
        tekstPressE.SetActive(false);
    }

    void Update()
    {
        if (inTrigger)
        {
            if (Input.GetKeyDown(KeyCode.E) & !EPressed)
            {
                // make it the oppsite of whatever it was

                tekst.SetActive(true);
                EPressed = true;
                HandleNadja();
                ScriptInfrastructure.instance.GetComponent<AudioSource>().Play();
            }



        }

        // this will only show text if your in the trigger and you toggled displayText to true.
    }

}

