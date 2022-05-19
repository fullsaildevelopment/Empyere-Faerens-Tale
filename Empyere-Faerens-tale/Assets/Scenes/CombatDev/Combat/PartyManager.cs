using UnityEngine;

public enum PCNPC
{
    PC,
    NPC
}
public class PartyManager : MonoBehaviour
{
    public Party party;
    [SerializeField] public CharacterManager[] characterManagerArr;
    [SerializeField] public PCNPC PcNpc;

    private void Awake()
    {
        int i = 0;
        foreach (Character c in party.active_characters)
        {
            characterManagerArr[i].character = c;
            characterManagerArr[i].update();

            //Debug.Log(characterManagerArr[i].character.Name);
            i++;
        }
    }

    public void update()
    {
        int i = 0;
        foreach (Character c in party.active_characters)
        {
            if(PcNpc == PCNPC.PC)
            {
                characterManagerArr[i].character = GameObject.Find("BattleManager").GetComponent<BattleHeart>().allypartyManager.party.active_characters[i];
            }
            if(PcNpc == PCNPC.NPC)
            {
                characterManagerArr[i].character = GameObject.Find("BattleManager").GetComponent<BattleHeart>().enemypartyManager.party.active_characters[i];
            }
            characterManagerArr[i].update();
            i++;
        }
    }
    public void attack(Character target, Character caster)
    {
        //Debug.Log("Attacking");
        target.CurrentHealth -= (int)caster.attack.modifier * caster.Attack;
        //GameObject.Find("BattleManager").GetComponent<BattleHeart>().heartbeat();

    }
}