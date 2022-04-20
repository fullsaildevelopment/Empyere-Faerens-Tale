using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    private void Awake()
    {
        Character Rin = new Character();
        Rin.MaxHealth = 100;
        Rin.CurrentHealth = 100;
        Rin.CurrentMagic = 50;
        Rin.Speed = 20;
        Rin.Attack = 20;
        Rin.Defense = 15;
        Rin.Magic = 50;
        Rin.MagicDefense = 20;
        Rin.Name = "Rin";
        
        Character Sam = new Character();
        Sam.MaxHealth = 250;
        Sam.CurrentHealth = 250;
        Sam.CurrentMagic = 30;
        Sam.Speed = 10;
        Sam.Attack = 10;
        Sam.Defense = 30;
        Sam.Magic = 30;
        Sam.MagicDefense = 30;
        Sam.Name = "Sam";

    }
}
