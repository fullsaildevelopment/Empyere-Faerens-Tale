using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Party
{
    //Contains the 3 Active characters
    public Character[] active_characters = new Character[3];
    //Selected Character for any needed reason
    Character selected = new Character();

    //List of all characters obtained
    public List<Character> characters = new List<Character>();

    #region Constructors
    public Party()
    {

    }
    public Party(Character[] activeChars, List<Character> allCharacters)
    {
        active_characters = activeChars;
        characters = allCharacters;
    }
    #endregion

    #region Functions
    //Input is in normal order starting at 1.
    public void SelectCharacter(int i)
    {
        selected = active_characters[i - 1];
    }
    public Character GetSelectedCharacter()
    {
        return selected;
    }
    //Give only an array of length 3! Returns blank characters otherwise!
    public Character[] SetActives(Character[] characters)
    {
        if(characters.Length > 3)
        {
            Character[] chars = new Character[3];
            return chars;
        }
        active_characters = characters;
        return active_characters;
    }
    //Replaces 1 character in active party. Input is in normal order starting at 1.
    public Character[] ReplaceActive(Character character, int i)
    {
        active_characters[i-1] = character;
        return active_characters;
    }
    //Removes 1 character from active party. Input is in normal order starting at 1.
    public Character[] RemoveActive(int i)
    {
        active_characters[i-1] = new Character();
        return active_characters;
    }
/*    //Returns Equipment of Selected Character in an array. Armor first.
    public Equipment[] GetSelectedEquip()
    {
        Equipment[] equip = new Equipment[2];
        equip[0] = selected.Armor;
        equip[1] = selected.Weapon;
        return equip;
    }
    //Sets Selected Character's Armor and returns the Character
    public Character SetSelectedArmor(Equipment armor)
    {
        selected.Armor = armor;
        return selected;
    }
    //Sets Selected Character's Weapon and returns the Character
    public Character SetSelectedWeapon(Equipment weapon)
    {
        selected.Weapon = weapon;
        return selected;
    }*/

    #endregion

}
