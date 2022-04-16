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
    [SerializeField] public float typingSpeed = .0100f;
    float original;
    public Animator icon;
    bool toggle = false;
    // Start is called before the first frame update
    /*
        private void Update() {
                if(Input.GetKeyDown(KeyCode.F)||Input.GetKeyDown(KeyCode.Space)||Input.GetMouseButtonDown(1))
                {
                    toggle = !toggle;
                    Debug.Log("Toggled");
                }
                
                if(toggle)
                {
                    typingSpeed = .001f;
                }
                else{
                    typingSpeed = original;
                }

    }
    */
    void Start()
    {
        sentences = new Queue<string>();
        animator = GetComponent<Animator>();
        original = typingSpeed;
        icon = GameObject.Find("dialogueIcon").GetComponent<Animator>();
    }
    
    
    
        public void StartDialogue(Dialog dialogue)
        {


            animator.SetBool("isOpen", true);
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
                if (Input.GetAxis("Jump") != 0)
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
            icon.SetTrigger("NotDone");
            
            string sentence = sentences.Dequeue();
            Debug.Log(sentence);
            StopAllCoroutines();
            StartCoroutine(TypeSentence(sentence));
            //dialogueText.text = sentence;
        
    }
    IEnumerator TypeSentence (string sentence){
        dialogueText.text = "";
        foreach(char letter in sentence.ToCharArray())
        {
            dialogueText.text += letter;
            yield return new WaitForSecondsRealtime(typingSpeed);
        }
        icon.ResetTrigger("NotDone");
        icon.SetTrigger("IsDone");
    }
    public void EndDialogue()
    {
                animator.SetBool("isOpen",false);

        Debug.Log("Conversation Over");
        //Time.timeScale = 1;
    }

    
}
