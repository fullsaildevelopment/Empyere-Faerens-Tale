using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemuse : MonoBehaviour
{
    [SerializeField] CharacterContainer cc;
    Character character;

    public void useitem()
    {
        character = cc.character;
    }
}
