using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using UnityEngine;

public class Serializer
{
    public string filePath;
    private string lastSave = "lastSave.xml";

    public Serializer()
    {
    }

    public Serializer(string path)
    {
        filePath = path;
    }

    public void SerializeUser(User user)
    {
        StreamWriter sw = new StreamWriter(filePath);

        System.Xml.Serialization.XmlSerializer x = new System.Xml.Serialization.XmlSerializer(user.GetType());
        x.Serialize(sw, user);

        sw.Close();

        sw = new StreamWriter(lastSave);

        System.Xml.Serialization.XmlSerializer y = new System.Xml.Serialization.XmlSerializer(user.GetType());
        y.Serialize(sw, user);

        sw.Close();
    }

    public void DeserializeUser(out User userOut)
    {
        StreamReader sr = new StreamReader(filePath);

        User user = new User();

        System.Xml.Serialization.XmlSerializer x = new System.Xml.Serialization.XmlSerializer(user.GetType());
        user = (User)x.Deserialize(sr);
        sr.Close();

        userOut = user;
    }

    public void DeserializeLast(out User user)
    {
        StreamReader sr = new StreamReader(lastSave);

        User tempUser = new User();

        System.Xml.Serialization.XmlSerializer x = new System.Xml.Serialization.XmlSerializer(tempUser.GetType());
        tempUser = (User)x.Deserialize(sr);
        sr.Close();

        user = tempUser;
    }

    public void SerializeCharacter(Character character)
    {
        string path = "Characters/" + character.Name + ".xml";

        StreamWriter sw = new StreamWriter(path);

        System.Xml.Serialization.XmlSerializer x = new System.Xml.Serialization.XmlSerializer(character.GetType());
        x.Serialize(sw, character);

        sw.Close();
        sw = new StreamWriter(path);

        System.Xml.Serialization.XmlSerializer y = new System.Xml.Serialization.XmlSerializer(character.GetType());
        y.Serialize(sw, character);

        sw.Close();
    }

    public void DeserializeCharacter(string characterName, out Character character)
    {
        string path = "Characters/" + characterName + ".xml";

        StreamReader sr = new StreamReader(path);

        Character Char = new Character();

        System.Xml.Serialization.XmlSerializer x = new System.Xml.Serialization.XmlSerializer(Char.GetType());
        Char = (Character)x.Deserialize(sr);
        sr.Close();

        character = Char;
    }
    public void SerializeEnemy(Enemy character)
    {
        string path = "Enemies/" + character.Name + ".xml";

        StreamWriter sw = new StreamWriter(path);

        System.Xml.Serialization.XmlSerializer x = new System.Xml.Serialization.XmlSerializer(character.GetType());
        x.Serialize(sw, character);

        sw.Close();
        sw = new StreamWriter(path);

        System.Xml.Serialization.XmlSerializer y = new System.Xml.Serialization.XmlSerializer(character.GetType());
        y.Serialize(sw, character);

        sw.Close();
    }

    public void DeserializeEnemy(string characterName, out Enemy character)
    {
        string path = "Enemies/" + characterName + ".xml";

        StreamReader sr = new StreamReader(path);

        Enemy Char = new Enemy();

        System.Xml.Serialization.XmlSerializer x = new System.Xml.Serialization.XmlSerializer(Char.GetType());
        Char = (Enemy)x.Deserialize(sr);
        sr.Close();

        character = Char;
    }

/*    public void SerializeItem(Item item)
    {
        string path = "Items/" + item.Name + ".xml";

        StreamWriter sw = new StreamWriter(path);

        System.Xml.Serialization.XmlSerializer x = new System.Xml.Serialization.XmlSerializer(item.GetType());
        x.Serialize(sw, item);

        sw.Close();
        sw = new StreamWriter(path);

        System.Xml.Serialization.XmlSerializer y = new System.Xml.Serialization.XmlSerializer(item.GetType());
        y.Serialize(sw, item);

        sw.Close();
    }*/

    public void DeserializeItem(string itemName, out Item item)
    {
        string path = "Items/" + itemName + ".xml";

        StreamReader sr = new StreamReader(path);

        Item obj = new Item();

        System.Xml.Serialization.XmlSerializer x = new System.Xml.Serialization.XmlSerializer(obj.GetType());
        obj = (Item)x.Deserialize(sr);
        sr.Close();

        item = obj;
    }

    public void DeserializeItemFull(string itemName, out Item item)
    {
        string path = itemName;

        StreamReader sr = new StreamReader(path);

        Item obj = new Item();

        System.Xml.Serialization.XmlSerializer x = new System.Xml.Serialization.XmlSerializer(obj.GetType());
        obj = (Item)x.Deserialize(sr);
        sr.Close();

        item = obj;
    }

    public void SerializeEquipment(Equipment equipment)
    {
        string path = "Equipment/" + equipment.Name + ".xml";

        StreamWriter sw = new StreamWriter(path);

        System.Xml.Serialization.XmlSerializer x = new System.Xml.Serialization.XmlSerializer(equipment.GetType());
        x.Serialize(sw, equipment);

        sw.Close();
        sw = new StreamWriter(path);

        System.Xml.Serialization.XmlSerializer y = new System.Xml.Serialization.XmlSerializer(equipment.GetType());
        y.Serialize(sw, equipment);

        sw.Close();
    }

    public void DeserializeEquipment(string equipmentName, out Equipment equipment)
    {
        string path = "Equipment/" + equipmentName + ".xml";

        StreamReader sr = new StreamReader(path);

        Equipment Equip = new Equipment();

        System.Xml.Serialization.XmlSerializer x = new System.Xml.Serialization.XmlSerializer(Equip.GetType());
        Equip = (Equipment)x.Deserialize(sr);
        sr.Close();

        equipment = Equip;
    }

    public void DeserializeEquipmentFull(string equipmentName, out Equipment equipment)
    {
        string path = equipmentName;

        StreamReader sr = new StreamReader(path);

        Equipment Equip = new Equipment();

        System.Xml.Serialization.XmlSerializer x = new System.Xml.Serialization.XmlSerializer(Equip.GetType());
        Equip = (Equipment)x.Deserialize(sr);
        sr.Close();

        equipment = Equip;
    }

    public void SerializeSkill(Skill skill)
    {
        string path = "Skills/" + skill.name + ".xml";

        StreamWriter sw = new StreamWriter(path);

        System.Xml.Serialization.XmlSerializer x = new System.Xml.Serialization.XmlSerializer(skill.GetType());
        x.Serialize(sw, skill);

        sw.Close();
        sw = new StreamWriter(path);

        System.Xml.Serialization.XmlSerializer y = new System.Xml.Serialization.XmlSerializer(skill.GetType());
        y.Serialize(sw, skill);

        sw.Close();
    }

    public void DeserializeSkill(string skillName, out Skill skill)
    {
        string path = "Skills/" + skillName + ".xml";

        StreamReader sr = new StreamReader(path);

        Skill sk = new Skill();

        System.Xml.Serialization.XmlSerializer x = new System.Xml.Serialization.XmlSerializer(sk.GetType());
        sk = (Skill)x.Deserialize(sr);
        sr.Close();

        skill = sk;
    }

    public void DeserializeSkillFull(string skillName, out Skill skill)
    {
        string path = skillName;

        StreamReader sr = new StreamReader(path);

        Skill sk = new Skill();

        System.Xml.Serialization.XmlSerializer x = new System.Xml.Serialization.XmlSerializer(sk.GetType());
        sk = (Skill)x.Deserialize(sr);
        sr.Close();

        skill = sk;
    }
}