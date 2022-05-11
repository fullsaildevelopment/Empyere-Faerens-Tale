using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;

public class gameController : MonoBehaviour
{

    //public User currentUser = new User();

    //public List<Equipment> equip = new List<Equipment>();
    public List<ITEMS > items = new List<ITEMS>();

    public void Awake()
    {
        //string[] equipFiles;
        string[] itemFiles;

        //equiFiles = Directory.GetFiles("Equipment", "*.xml")
        itemFiles = Directory.GetFiles("Items", "*.xml");
        Serializer sz = new Serializer();

        //foreach(string str in equipFiles) {}
        /*foreach (string file in itemFiles)
        {
            ITEMS item = new ITEMS();
            sz.DeserializeItemFull(file, out item);
            items.Add(item);
        }
*/
        //TODO: Change current scene managaement script. 
        //SceneManager.LoadScene(1, LoadSceneMode.Additive);

    }

    //User management if needed
    /*
     * public User GetUser()
     * {
     *      return currentUser;
     * }
     * public void SetUser(User user)
     * {
     *      currenUser = user;
     * }
     */

}