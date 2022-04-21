using UnityEngine;

public class PartyManager : MonoBehaviour
{
    public Party party;
    [SerializeField] private CharacterManager[] characterManagerArr;

    private void Awake()
    {
        int i = 0;
        foreach (Character c in party.active_characters)
        {
            characterManagerArr[i].character = c;
            characterManagerArr[i].update();

            Debug.Log(characterManagerArr[i].character.Name);
            i++;
        }
    }
}