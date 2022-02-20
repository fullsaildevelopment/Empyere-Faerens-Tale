using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{

    public Text nameText;
    public Text dialogueText;
    private Queue<string> sentences;
    public Animator animator;
    float typingSpeed = 10;
    // Start is called before the first frame update
    void Start()
    {
        sentences = new Queue<string>();
        animator = GetComponent<Animator>();
    }
    public void StartDialogue (Dialog dialogue)
    {
        animator.SetBool("isOpen",true);
        nameText.text = dialogue.name;
        
        sentences.Clear();
        foreach (string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }
        DisplayNextSentence();

        //Time.timeScale = 0;
        //while (sentences.Count !=0)
        {
            if(Input.GetAxis("Jump") !=0)
            {
                DisplayNextSentence();
            }
        }
    }
    public void DisplayNextSentence()
    {
        if(sentences.Count==0)
        {
            EndDialogue();
            return;
        }
        
            string sentence = sentences.Dequeue();
            Debug.Log(sentence);
            StopAllCoroutines();
            //StartCoroutine(TypeSentence(sentence));
            dialogueText.text = sentence;
        
    }
    IEnumerator TypeSentence (string sentence){
        dialogueText.text = "";
        foreach(char letter in sentence.ToCharArray())
        {
            dialogueText.text += letter;
            yield return new WaitForSecondsRealtime(typingSpeed);
        }
    }
    public void EndDialogue()
    {
                animator.SetBool("isOpen",false);

        Debug.Log("Conversation Over");
        //Time.timeScale = 1;
    }

    
}
