using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WizardDialogue : MonoBehaviour
{
    public DialogueScript dialogueManager;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D other){
        if(other.tag =="Player"){
            string[] dialogue={"Wizard:Sonic, wait! You must save the world before the villian gathers all the artifacts!",
            "Sonic:Where should I go?",
            "Wizard: You must be careful ! There are many obstacles on your journey and you must overcome them to find the artifacts.",
            "Sonic:You can count on me! I won't let him get the power!"};
            dialogueManager.setSentences(dialogue);
            dialogueManager.StartCoroutine(dialogueManager.TypeDialogue());
        }
    }
}
