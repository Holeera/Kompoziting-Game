using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;
using Yarn.Analysis;
using Yarn.Compiler;
using Yarn.Markup;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(BoxCollider2D))]
public class Interact : MonoBehaviour
{
    public DialogueRunner dialogueRunner;

    private void OnTriggerEnter2D(Collider2D col)
    {
        switch (this.name)
        {
            case "Cup":
                dialogueRunner.Stop();
                dialogueRunner.StartDialogue("Cup");
                break;

            case "Mug":
                dialogueRunner.Stop();
                dialogueRunner.StartDialogue("Mug");
                break;

            case "Glass":
                dialogueRunner.Stop();
                dialogueRunner.StartDialogue("Glass");
                break;

            case "Bottle":
                dialogueRunner.Stop();
                dialogueRunner.StartDialogue("Bottle");
                break;

            default: break;
        }
    }

    private void OnTriggerExit2D(Collider2D col)
    {
        dialogueRunner.Stop();
    }
}
