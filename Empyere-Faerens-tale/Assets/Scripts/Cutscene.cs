using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//[System.Serializable]
public class Cutscene 
{
    [TextArea(3,10)]
    public Dialog[] dialogs;
    public Vector3[] positions;
    public bool[]   flags;
}


