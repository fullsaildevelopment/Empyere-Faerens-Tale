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
        switch(location)
        {
            case Location.Plains:
                plains = GameObject.Find("GameController").GetComponent<EnemyGenLists>().plains;
                System.Random random = new System.Random();
                int i = 0;
                foreach(Character cha in generatedEnemies.active_characters)
                {
                    generatedEnemies.active_characters[i] = plains[random.Next(0, plains.Count)];
                    i++;
                    Debug.Log(random.Next(0, plains.Count));
                }
                GameObject.Find("GameController").GetComponent<EnemyGenLists>().generatedEnemies = generatedEnemies;
                break;
            default:
                Debug.LogError("GenerateCombat Broke. EnemyGenLists.cs Switch(location)");
                break;
                
        }
        SceneManager.LoadScene(13, LoadSceneMode.Single);
    }

}
