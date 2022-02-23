using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCreation : MonoBehaviour
{
    List<Item> items = new List<Item>();

    private void Awake()
    {
        #region Item Creation
        Item potion = new Item();
        potion.Name = "Potion";
        potion.Type = "Heal";
        potion.Points = .25f;
        potion.price = 10;
        items.Add(potion);

        Item hipotion = new Item();
        hipotion.Name = "Hi-Potion";
        hipotion.Type = "Heal";
        hipotion.Points = .50f;
        hipotion.price = 25;
        items.Add(hipotion);

        Item Xpotion = new Item();
        Xpotion.Name = "X-Potion";
        Xpotion.Type = "Heal";
        Xpotion.Points = 1.00f;
        Xpotion.price = 75;
        items.Add(Xpotion);

        Item ether = new Item();
        ether.Name = "Ether";
        ether.Type = "Mana";
        ether.Points = 35;
        ether.price = 15;
        items.Add(ether);

        Item turboether = new Item();
        turboether.Name = "Turbo-Ether";
        turboether.Type = "Mana";
        turboether.Points = 100;
        turboether.price = 75;
        items.Add(turboether);

        Item Elixir = new Item();
        Elixir.Name = "Elixir";
        Elixir.Type = "Full";
        Elixir.Points = 1.00f;
        Elixir.price = 150;
        items.Add(Elixir);

        Item TurboElixir = new Item();
        TurboElixir.Name = "Turbo-Elixir";
        TurboElixir.Type = "Full Party";
        TurboElixir.Points = 1.00f;
        TurboElixir.price = 325;
        items.Add(TurboElixir);

        Item icegem = new Item();
        icegem.Name = "Ice Gem";
        icegem.Type = "Damage Ice";
        icegem.Points = .2f;
        icegem.price = 20;
        items.Add(icegem);

        Item firegem = new Item();
        firegem.Name = "Fire Gem";
        firegem.Type = "Damage Fire";
        firegem.Points = .2f;
        firegem.price = 20;
        items.Add(firegem);

        Item watergem = new Item();
        watergem.Name = "Water Gem";
        watergem.Type = "Damage Water";
        watergem.Points = .2f;
        watergem.price = 20;
        items.Add(watergem);

        Item bomb = new Item();
        bomb.Name = "Bomb";
        bomb.Type = "Damage Pure";
        bomb.Points = .15f;
        bomb.price = 20;
        items.Add(bomb);
        #endregion
    }

    public void createitems()
    {
        foreach(Item item in items)
        {
            Serializer sz = new Serializer();
            sz.SerializeItem(item);
        }
    }

}
