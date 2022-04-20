using System;

public class Equipment : BaseObject
{
    #region Members

    //public Identiy ObjectType;
    //This will be used to add to character stats temporarily
    public int boost;

    //This will be sourced from a dictionary in global namespace
    public string boostType;

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

    public string GetBoostType()
    {
        return boostType;
    }

    public void SetBoostType(string type)
    {
        boostType = type;
    }

    #endregion Getters Setters

    public Equipment()
    {
        ObjectType = Identiy.Equipment;
        boost = 0;
        boostType = "Null";
        Name = "Null";
    }
}