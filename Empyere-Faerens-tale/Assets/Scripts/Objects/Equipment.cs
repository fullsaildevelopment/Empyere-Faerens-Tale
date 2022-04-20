using System;

public enum EquipType
{
    Armor,
    Weapon,
    None
}
public enum BoostType
{
    Attack,
    Speed,
    Magic,
    Defense,
    MagicDef,
    None
}

public class Equipment : BaseObject
{
    #region Members

    //public Identity ObjectType;
    //This will be used to add to character stats temporarily
    public int boost;

    //This will be sourced from a dictionary in global namespace
    public BoostType boostType;
    public EquipType equipType;

    public string Name;
    public int price;

    #endregion Members

    #region Getters Setters

    public int GetBoost()
    {
        return boost;
    }

    public void SetBoost(int interger)
    {
        boost = interger;
    }

    public BoostType GetBoostType()
    {
        return boostType;
    }

    public void SetBoostType(BoostType type)
    {
        boostType = type;
    }

    #endregion Getters Setters

    public Equipment()
    {
        ObjectType = Identity.Equipment;
        boost = 0;
        boostType = BoostType.None;
        equipType = EquipType.None;
        Name = "Null";
    }
}