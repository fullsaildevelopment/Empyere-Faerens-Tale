using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class popInvDebug : MonoBehaviour
{
    public void popInv()
    {
        Inventory inv = GameObject.Find("GameController").GetComponent<GameUser>().user.inventory;
        #region adding items
        //Serializer sz = new Serializer();
        Equipment sword = new Equipment();
        sword.Name = "Copper Sword";
        sword.ObjectType = Identiy.Equipment;
        Item item = new Item();
        item.Name = "Bomb";
        item.ObjectType = Identiy.Item;
        inv.ObjectList = new List<BaseObject>();
        inv.ObjectList.Add(item);
        inv.ObjectList.Add(item);
        inv.ObjectList.Add(sword);
        //item.Name = "Testing";
        Equipment e = new Equipment();
        e.ObjectType = Identiy.Equipment;
        e.Name = "Tester Equip";
        inv.ObjectList.Add(e);
        SceneManager.LoadScene(11, LoadSceneMode.Single);
        #endregion
        
    }
}
