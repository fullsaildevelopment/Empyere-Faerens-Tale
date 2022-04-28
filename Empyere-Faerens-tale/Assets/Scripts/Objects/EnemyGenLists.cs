using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public enum Location
{
    Plains,
    None
}

public class EnemyGenLists : MonoBehaviour
{
    public Party generatedEnemies = new Party();
    public List<Enemy> plains = new List<Enemy>();
    [SerializeField] public Location location;

    public void GenerateCombat()
    {
        GameObject.Find("GameController").GetComponent<EnemyGenLists>().location = location;
        Party p = new Party();
        
        switch(location)
        {
            case Location.Plains:
                plains = GameObject.Find("GameController").GetComponent<EnemyGenLists>().plains;
                System.Random random = new System.Random();
                int i = 0;
                Serializer serializer = new Serializer();
                foreach(Character cha in p.active_characters)
                {
                    Enemy c = new Enemy();
                    int a = random.Next(0, plains.Count);
                    serializer.DeserializeEnemy(plains[a].Name, out c);
                    c.sprite = plains[a].sprite;

                    p.active_characters[i] = c;
                    i++;
                    //Debug.Log(random.Next(0, plains.Count));
                }
                GameObject.Find("GameController").GetComponent<EnemyGenLists>().generatedEnemies = p;
                break;
            default:
                Debug.LogError("GenerateCombat Broke. EnemyGenLists.cs Switch(location)");
                break;
                
        }
        SceneManager.LoadScene(13, LoadSceneMode.Single);
    }

}
