using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Execute : MonoBehaviour
{
    public int i;
    public SelectorParent sp;
    public void exec()
    {
        sp.exec(i);
    }
}
