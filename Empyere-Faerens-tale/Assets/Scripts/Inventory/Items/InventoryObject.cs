using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using UnityEditor;

[CreateAssetMenu(fileName = "New Inventory", menuName = "Inventory System/Inventory")]
public class InventoryObject : ScriptableObject, ISerializationCallbackReceiver
{
    private  ItemDatabaseObject database;
    public List<InventorySlot> Container = new List<InventorySlot>();
    //public string savePath;
    private void OnEnable()
    {
#if UNITY_EDITOR
        database = (ItemDatabaseObject)AssetDatabase.LoadAssetAtPath("Assets/Resources/Database.asset",typeof (ItemDatabaseObject));
#else
        database = Resources.Load<ItemDatabaseObject>("Database");
#endif
    }

    public void AddItem(ItemObject _item, int _amount)
    {
        //bool ihaveit = false;
        for (int i = 0; i < Container.Count; i++)
        {
            if (Container[i].item == _item)
            {
                Container[i].AddAmount(_amount);
                
                return;
            }
        }
        //if (!ihaveit)
        
            Container.Add(new InventorySlot(database.GetId[_item], _item, _amount));
        
    }
    public void Save()
    {
        /*string saveData = JsonUtility.ToJson(this, true);
        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Create(string.Concat(Application.persistentDataPath, savePath));
        bf.Serialize(file, saveData);
        file.Close();*/
        BinaryFormatter formatters = new BinaryFormatter();
        string saveData = JsonUtility.ToJson(this, true);
        FileStream file = File.Create(string.Concat(Application.persistentDataPath + "/player.imloading"));
        formatters.Serialize(file, saveData);
        file.Close();

    }
    public void Load()
    {
        if (File.Exists(string.Concat(Application.persistentDataPath + "/player.imloading")))
        {
            BinaryFormatter formatters = new BinaryFormatter();
            FileStream file = File.Open(string.Concat(Application.persistentDataPath + "/player.imloading"), FileMode.Open);
            JsonUtility.FromJsonOverwrite(formatters.Deserialize(file).ToString(), this);
            file.Close();
        }
    }
    public void OnAfterDeserialize()
    {
       
        for (int i = 0; i < Container.Count; i++)
        
            Container[i].item = database.GetItem[Container[i].ID];
        
    }
    public void OnBeforeSerialize()
    {

    }
}
[System.Serializable]
public class InventorySlot
{
    public int ID;
    public ItemObject item;
    public int amount;
    public InventorySlot(int _id, ItemObject _item, int _amount)
    {
        ID = _id;
        item = _item;
        amount = _amount;
    }
    public void AddAmount(int value)
    {
        amount += value;
    }
}
