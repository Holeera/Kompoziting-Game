using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(BoxCollider2D))]
public class InspectChangeLevel : MonoBehaviour
{
    public bool inTrigger;
    public bool displayText;
    public GameObject tekst;
    bool EPressed = false;

    public GameObject tekstPressE;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))

        {
            inTrigger = true;
            tekstPressE.SetActive(true);

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

    private void Start()
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

                EPressed = true;
                SceneManager.LoadScene("!End");

            }

            // this will only show text if your in the trigger and you toggled displayText to true.
        }

    }
}
