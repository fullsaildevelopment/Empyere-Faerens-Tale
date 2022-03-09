using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseBehavior : MonoBehaviour
{
    // Start is called before the first frame update
    bool invOpen;
    bool equipOpen;
    bool questOpen;
    bool istriggered;
    GameObject invPanel;
    GameObject equipPanel;
    GameObject questPanel;

    void Start()
    {
        invOpen = false;
        equipOpen = false;
        questOpen = false;
        invPanel = GameObject.Find("Inventory");
        equipPanel = GameObject.Find("Equipment");
        questPanel = GameObject.Find("Quests");
        istriggered = false;
    }

    // Update is called once per frame
    void Update()
    {
        Animator animator = GetComponent<Animator>();

        if (Input.GetKeyDown(KeyCode.Tab) && !istriggered)
        {
            istriggered = true;
            animator.SetTrigger("Show");
        }
        else if (Input.GetKeyDown(KeyCode.Tab) && istriggered)
        {
            istriggered = false;
            animator.SetTrigger("Hide");
        }
    }
    public void ChangePanel(int panelnum)
    {
        if (panelnum == 3)
        {
            invPanel.GetComponent<RectTransform>().localScale.Set(1, 0, 1);
            invPanel.transform.localScale.Set(1, 0, 1);
            equipPanel.transform.localScale.Set(1, 0, 1);
            questPanel.transform.localScale.Set(1, 1, 1);
            Debug.Log("Changing to Quests");
        }
        else if (panelnum == 2)
        {
            invPanel.transform.localScale.Set(1, 0, 1);
            equipPanel.transform.localScale.Set(1, 1, 1);
            questPanel.transform.localScale.Set(1, 0, 1);
            Debug.Log("Changing to Equipment");
        }
        else
        {
            invPanel.transform.localScale.Set(1, 1, 1);
            equipPanel.transform.localScale.Set(1, 0, 1);
            questPanel.transform.localScale.Set(1, 0, 1);
            Debug.Log("Changing to Inventory");
        }
    }
}