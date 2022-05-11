using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCreation : MonoBehaviour
{
    //List<ITEMS> items = new List<ITEMS>();
    List<Equipment> equip = new List<Equipment>();
    List<Skill> SkillList = new List<Skill>();

    private void Awake()
    {
/*        #region ITEMS Creation
        ITEMS potion = new ITEMS();
        potion.Name = "Potion";
        potion.Type = "Heal";
        potion.Points = .25f;
        potion.price = 10;
        items.Add(potion);

        ITEMS hipotion = new ITEMS();
        hipotion.Name = "Hi-Potion";
        hipotion.Type = "Heal";
        hipotion.Points = .50f;
        hipotion.price = 25;
        items.Add(hipotion);

        ITEMS Xpotion = new ITEMS();
        Xpotion.Name = "X-Potion";
        Xpotion.Type = "Heal";
        Xpotion.Points = 1.00f;
        Xpotion.price = 75;
        items.Add(Xpotion);

        ITEMS ether = new ITEMS();
        ether.Name = "Ether";
        ether.Type = "Mana";
        ether.Points = 35;
        ether.price = 15;
        items.Add(ether);

        ITEMS turboether = new ITEMS();
        turboether.Name = "Turbo-Ether";
        turboether.Type = "Mana";
        turboether.Points = 100;
        turboether.price = 75;
        items.Add(turboether);

        ITEMS Elixir = new ITEMS();
        Elixir.Name = "Elixir";
        Elixir.Type = "Full";
        Elixir.Points = 1.00f;
        Elixir.price = 150;
        items.Add(Elixir);

        ITEMS TurboElixir = new ITEMS();
        TurboElixir.Name = "Turbo-Elixir";
        TurboElixir.Type = "Full Party";
        TurboElixir.Points = 1.00f;
        TurboElixir.price = 325;
        items.Add(TurboElixir);

        ITEMS icegem = new ITEMS();
        icegem.Name = "Ice Gem";
        icegem.Type = "Damage Ice";
        icegem.Points = .2f;
        icegem.price = 20;
        items.Add(icegem);

        ITEMS firegem = new ITEMS();
        firegem.Name = "Fire Gem";
        firegem.Type = "Damage Fire";
        firegem.Points = .2f;
        firegem.price = 20;
        items.Add(firegem);

        ITEMS watergem = new ITEMS();
        watergem.Name = "Water Gem";
        watergem.Type = "Damage Water";
        watergem.Points = .2f;
        watergem.price = 20;
        items.Add(watergem);

        ITEMS bomb = new ITEMS();
        bomb.Name = "Bomb";
        bomb.Type = "Damage Pure";
        bomb.Points = .15f;
        bomb.price = 20;
        items.Add(bomb);
        #endregion
*/
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

        #region Skill Creation

        Skill firstaid = new Skill();
        firstaid.name = "First Aid";
        firstaid.type = SkillType.Heal;
        firstaid.damage = DamageType.None;
        firstaid.target = SkillTarget.Self;
        firstaid.statcheck = StatType.Magic;
        firstaid.modifier = .75f;
        firstaid.cost = 5;
        SkillList.Add(firstaid);

        Skill WhiteWind = new Skill();
        WhiteWind.name = "White Wind";
        WhiteWind.type = SkillType.Heal;
        WhiteWind.damage = DamageType.None;
        WhiteWind.target = SkillTarget.Party;
        WhiteWind.statcheck = StatType.Magic;
        WhiteWind.modifier = .5f;
        WhiteWind.cost = 20;
        SkillList.Add(WhiteWind);

        Skill Bless = new Skill();
        Bless.name = "Bless";
        Bless.type = SkillType.Heal;
        Bless.damage = DamageType.None;
        Bless.target = SkillTarget.Single;
        Bless.statcheck = StatType.Magic;
        Bless.modifier = 1f;
        Bless.cost = 10;
        SkillList.Add(Bless);

        Skill Cleave = new Skill();
        Cleave.name = "Cleave";
        Cleave.type = SkillType.Damage;
        Cleave.damage = DamageType.None;
        Cleave.target = SkillTarget.Party;
        Cleave.statcheck = StatType.Attack;
        Cleave.modifier = .4f;
        Cleave.cost = 15;
        SkillList.Add(Cleave);

        Skill Pierce = new Skill();
        Pierce.name = "Pierce";
        Pierce.type = SkillType.Damage;
        Pierce.damage = DamageType.Pure;
        Pierce.target = SkillTarget.Single;
        Pierce.statcheck = StatType.Attack;
        Pierce.modifier = .75f;
        Pierce.cost = 15;
        SkillList.Add(Pierce);

        Skill Slash = new Skill();
        Slash.name = "Slash";
        Slash.type = SkillType.Damage;
        Slash.damage = DamageType.None;
        Slash.target = SkillTarget.Single;
        Slash.statcheck = StatType.Attack;
        Slash.modifier = .85f;
        Slash.cost = 10;
        SkillList.Add(Slash);

        Skill CrossSlash = new Skill();
        CrossSlash.name = "Cross Slash";
        CrossSlash.type = SkillType.Damage;
        CrossSlash.damage = DamageType.Pure;
        CrossSlash.target = SkillTarget.Single;
        CrossSlash.statcheck = StatType.Attack;
        CrossSlash.modifier = 1.25f;
        CrossSlash.cost = 25;
        SkillList.Add(CrossSlash);

        Skill Fire = new Skill();
        Fire.name = "Fire";
        Fire.type = SkillType.Damage;
        Fire.damage = DamageType.Fire;
        Fire.target = SkillTarget.Single;
        Fire.statcheck = StatType.Magic;
        Fire.modifier = 1f;
        Fire.cost = 10;
        SkillList.Add(Fire);

        Skill FlameStorm = new Skill();
        FlameStorm.name = "Fire Storm";
        FlameStorm.type = SkillType.Damage;
        FlameStorm.damage = DamageType.Fire;
        FlameStorm.target = SkillTarget.Party;
        FlameStorm.statcheck = StatType.Magic;
        FlameStorm.modifier = .8f;
        FlameStorm.cost = 30;
        SkillList.Add(FlameStorm);

        Skill Water = new Skill();
        Water.name = "Water";
        Water.type = SkillType.Damage;
        Water.damage = DamageType.Water;
        Water.target = SkillTarget.Single;
        Water.statcheck = StatType.Magic;
        Water.modifier = 1f;
        Water.cost = 10;
        SkillList.Add(Water);

        Skill Flood = new Skill();
        Flood.name = "Flood";
        Flood.type = SkillType.Damage;
        Flood.damage = DamageType.Water;
        Flood.target = SkillTarget.Party;
        Flood.statcheck = StatType.Magic;
        Flood.modifier = .8f;
        Flood.cost = 30;
        SkillList.Add(Flood);

        Skill Earth = new Skill();
        Earth.name = "Earth";
        Earth.type = SkillType.Damage;
        Earth.damage = DamageType.Earth;
        Earth.target = SkillTarget.Single;
        Earth.statcheck = StatType.Magic;
        Earth.modifier = 1f;
        Earth.cost = 10;
        SkillList.Add(Earth);

        Skill Rumble = new Skill();
        Rumble.name = "Rumble";
        Rumble.type = SkillType.Damage;
        Rumble.damage = DamageType.Earth;
        Rumble.target = SkillTarget.Party;
        Rumble.statcheck = StatType.Magic;
        Rumble.modifier = .8f;
        Rumble.cost = 30;
        SkillList.Add(Rumble);

        Skill Ice = new Skill();
        Ice.name = "Ice";
        Ice.type = SkillType.Damage;
        Ice.damage = DamageType.Ice;
        Ice.target = SkillTarget.Single;
        Ice.statcheck = StatType.Magic;
        Ice.modifier = 1f;
        Ice.cost = 10;
        SkillList.Add(Ice);

        Skill Freeze = new Skill();
        Freeze.name = "Freezw";
        Freeze.type = SkillType.Damage;
        Freeze.damage = DamageType.Ice;
        Freeze.target = SkillTarget.Party;
        Freeze.statcheck = StatType.Magic;
        Freeze.modifier = .8f;
        Freeze.cost = 30;
        SkillList.Add(Freeze);

        Skill Flare = new Skill();
        Flare.name = "Flare";
        Flare.type = SkillType.Damage;
        Flare.damage = DamageType.Pure;
        Flare.target = SkillTarget.Single;
        Flare.modifier = 1.5f;
        Flare.cost = 35;
        SkillList.Add(Flare);



        //The support skils list will have a special handler and will be a subclass to skill. Below is an example of what it may look like as a Skill Object
        //This skill would be a fire type attack with a low damage and low cost. Right now if we were to have a support skill that deal damage and then 
        //heals based off that damage it would be impossible. A new class for support skills will be made off of Skill. This may also entail some unique classes
        //for special skills as well.
        Skill supportExample = new Skill();
        supportExample.name = "Example";
        supportExample.type = SkillType.Support;
        supportExample.damage = DamageType.Fire;
        supportExample.target = SkillTarget.Single;
        supportExample.statcheck = StatType.Attack;
        supportExample.modifier = .6f;
        supportExample.cost = 5;
        SkillList.Add(supportExample);

        #endregion
    }

    /*public void createitems()
    {
        foreach (ITEMS item in items)
        {
            Serializer sz = new Serializer();
            sz.SerializeItem(item);
        }
    }*/
    public void createequip()
    {
        foreach (Equipment equipment in equip)
        {
            Serializer sz = new Serializer();
            sz.SerializeEquipment(equipment);
        }
    }
    public void createskills()
    {
        foreach (Skill skill in SkillList)
        {
            Serializer sz = new Serializer();
            sz.SerializeSkill(skill);
        }
    }
}