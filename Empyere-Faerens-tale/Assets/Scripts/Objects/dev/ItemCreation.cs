using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCreation : MonoBehaviour
{
    List<Item> items = new List<Item>();
    List<Equipment> equip = new List<Equipment>();

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

        #region Equipment Creation

            #region Weapons

        Equipment WoodenSword = new Equipment();
        WoodenSword.Name = "Wooden Sword";
        WoodenSword.boostType = "Attack";
        WoodenSword.boost = 3;
        equip.Add(WoodenSword);

        Equipment CopperSword = new Equipment();
        CopperSword.Name = "Copper Sword";
        CopperSword.boostType = "Attack";
        CopperSword.boost = 8;
        equip.Add(CopperSword);

        Equipment SteelSword = new Equipment();
        SteelSword.Name = "Steel Sword";
        SteelSword.boostType = "Attack";
        SteelSword.boost = 14;
        equip.Add(SteelSword);

        Equipment WoodBuckler = new Equipment();
        WoodBuckler.Name = "Wood Buckler";
        WoodBuckler.boostType = "Attack";
        WoodBuckler.boost = 5;
        equip.Add(WoodBuckler);

        Equipment StuddedShield = new Equipment();
        StuddedShield.Name = "Studded Shield";
        StuddedShield.boostType = "Attack";
        WoodBuckler.boost = 16;
        equip.Add(StuddedShield);

        Equipment TowerShield = new Equipment();
        TowerShield.Name = "Tower Shield";
        TowerShield.boostType = "Defense";
        TowerShield.boost = 16;
        equip.Add(TowerShield);

        #endregion
            #region Armors

        Equipment LeatherVest = new Equipment();
        LeatherVest.Name = "Leather Vest";
        LeatherVest.boostType = "Defense";
        LeatherVest.boost = 4;
        equip.Add(LeatherVest);

        Equipment ChainmailVest = new Equipment();
        ChainmailVest.Name = "Chainmail Vest";
        ChainmailVest.boostType = "Defense";
        ChainmailVest.boost = 9;
        equip.Add(ChainmailVest);

        Equipment SteelPlate = new Equipment();
        SteelPlate.Name = "Steel Plate";
        SteelPlate.boostType = "Defense";
        SteelPlate.boost = 16;
        equip.Add(SteelPlate);

        Equipment StiffLeatherGauntlents = new Equipment();
        StiffLeatherGauntlents.Name = "Stiff Leather Gauntlents";
        StiffLeatherGauntlents.boostType = "Defense";
        StiffLeatherGauntlents.boost = 6;
        equip.Add(StiffLeatherGauntlents);

        Equipment ReinforcedGauntlets = new Equipment();
        ReinforcedGauntlets.Name = "Reinforced Gauntlets";
        ReinforcedGauntlets.boostType = "Defense";
        ReinforcedGauntlets.boost = 13;
        equip.Add(ReinforcedGauntlets);

        Equipment SteelGauntlets = new Equipment();
        SteelGauntlets.Name = "Steel Gauntlets";
        SteelGauntlets.boostType = "Defense";
        SteelGauntlets.boost = 18;
        equip.Add(SteelGauntlets);

            #endregion

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
    public void createequip()
    {
        foreach(Equipment equipment in equip)
        {
            Serializer sz = new Serializer();
            sz.SerializeEquipment(equipment);
        }
    }

}
