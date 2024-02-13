using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScriptInfrastructure : MonoBehaviour
{
    public static ScriptInfrastructure instance;
    public Animator PlayerAnimator;
    public AudioClip PlayerFootsteps;
    public AudioClip PlayerInteract;

    public GameObject colorCamera;
    public GameObject monochromeCamera;

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {

    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            monochromeCamera.SetActive(false);
            colorCamera.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.O))
        {
            colorCamera.SetActive(false);
            monochromeCamera.SetActive(true);
        }
    }
}
