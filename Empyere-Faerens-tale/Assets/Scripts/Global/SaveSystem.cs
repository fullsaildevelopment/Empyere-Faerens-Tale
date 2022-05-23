using System.IO;
using UnityEngine;
using System.Runtime.Serialization.Formatters.Binary;


public static class SaveSystem
{
    //saving data ^U ^ 
    public static void SavePlayer(Player player)
    {
        //setting up the file for where the saving stuff is stored
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/player.dontremovememcard";
        FileStream stream = new FileStream(path, FileMode.Create);
        PlayerData data = new PlayerData(player);
        formatter.Serialize(stream, data);

        //close the file 
        stream.Close();

    }
    

    //loading start

    public static PlayerData LoadPlayer()
    {
        string path = Application.persistentDataPath + "/player.dontremovememcard";
        //checking that the file exists
        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);
            PlayerData data = formatter.Deserialize(stream) as PlayerData;
            //close the stream 
            stream.Close();

            return data;


        }else
        {
            Debug.LogError("File not found in location" + path);
                return null;
        }


    }
};
