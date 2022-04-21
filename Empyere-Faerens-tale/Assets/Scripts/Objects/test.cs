using UnityEngine;

public class test : MonoBehaviour
{
    [SerializeField] public Sprite rinsprite;
    [SerializeField] public Sprite samsprite;
    [SerializeField] public Sprite slime;
    [SerializeField] public Sprite blueslime;
    [SerializeField] public Sprite goldslime;
    private void Awake()
    {
        Serializer sz = new Serializer();

        /*List<Skill> rinlist = new List<Skill>();
        List<Skill> samlist = new List<Skill>();*/

        Character Rin = new Character();
        sz.DeserializeCharacter("Rin", out Rin);
        Rin.sprite = rinsprite;

        /*Rin.MaxHealth = 100;
        Rin.CurrentHealth = 100;
        Rin.CurrentMagic = 50;
        Rin.Speed = 20;
        Rin.Attack = 20;
        Rin.Defense = 15;
        Rin.Magic = 50;
        Rin.MagicDefense = 20;
        Rin.Name = "Rin";
        sz.SerializeCharacter(Rin);*/

        Character Sam = new Character();
        sz.DeserializeCharacter("Sam", out Sam);
        Sam.sprite = samsprite;

        /*sz.SerializeCharacter(Sam);*/

        /*Sam.MaxHealth = 250;
        Sam.CurrentHealth = 250;
        Sam.CurrentMagic = 30;
        Sam.Speed = 10;
        Sam.Attack = 10;
        Sam.Defense = 30;
        Sam.Magic = 30;
        Sam.MagicDefense = 30;
        Sam.Name = "Sam";*/

        /*Skill rin1 = new Skill();
        Skill rin2 = new Skill();
        Skill rin3 = new Skill();

        Skill sam1 = new Skill();
        Skill sam2 = new Skill();
        Skill sam3 = new Skill();

        Skill faid = new Skill();*/

        /*sz.DeserializeSkill("First Aid", out faid);
        sz.DeserializeSkill("Cleave", out rin1);
        sz.DeserializeSkill("Pierce", out rin2);
        sz.DeserializeSkill("Ice", out rin3);

        sz.DeserializeSkill("Earth", out sam1);
        sz.DeserializeSkill("White Wind", out sam2);
        sz.DeserializeSkill("Slash", out sam3);

        Sam.skillList.Add(sam1);
        Sam.skillList.Add(sam2);
        Sam.skillList.Add(sam3);
        Sam.skillList.Add(faid);

        Rin.skillList.Add(rin1);
        Rin.skillList.Add(rin2);
        Rin.skillList.Add(rin3);
        Rin.skillList.Add(faid);*/

        /*foreach (Skill skill in Sam.skillList)
        {
            Debug.Log(skill.name);
        }
        foreach(Skill skill in Rin.skillList)
        {
            Debug.Log(skill.name);
        }*/

        /*sz.SerializeCharacter(Rin);
        sz.SerializeCharacter(Sam);*/

        Enemy Slime = new Enemy();
        Enemy WaterSlime = new Enemy();
        Enemy GoldSlime = new Enemy();

        /*Slime.MaxHealth = 50;
        Slime.CurrentHealth = 50;
        Slime.CurrentMagic = 20;
        Slime.Speed = 5;
        Slime.Attack = 5;
        Slime.Defense = 10;
        Slime.Magic = 20;
        Slime.MagicDefense = 10;
        Slime.Name = "Slime";

        WaterSlime.MaxHealth = 30;
        WaterSlime.CurrentHealth = 30;
        WaterSlime.CurrentMagic = 30;
        WaterSlime.Speed = 5;
        WaterSlime.Attack = 4;
        WaterSlime.Defense = 10;
        WaterSlime.Magic = 30;
        WaterSlime.MagicDefense = 10;
        WaterSlime.Name = "Water Slime";

        GoldSlime.MaxHealth = 30;
        GoldSlime.CurrentHealth = 50;
        GoldSlime.CurrentMagic = 20;
        GoldSlime.Speed = 5;
        GoldSlime.Attack = 5;
        GoldSlime.Defense = 10;
        GoldSlime.Magic = 20;
        GoldSlime.MagicDefense = 10;
        GoldSlime.Name = "Gold Slime";

        Skill water = new Skill();
        sz.DeserializeSkill("Water", out water);

        Skill bless = new Skill();
        sz.DeserializeSkill("Bless", out bless);

        Skill pierce = new Skill();
        sz.DeserializeSkill("Pierce", out pierce);

        WaterSlime.skillList.Add(water);
        Slime.skillList.Add(pierce);
        GoldSlime.skillList.Add(bless);*/

        sz.DeserializeEnemy("Slime", out Slime);
        sz.DeserializeEnemy("Water Slime", out WaterSlime);
        sz.DeserializeEnemy("Gold Slime", out GoldSlime);
        Slime.sprite = slime;
        WaterSlime.sprite = blueslime;
        GoldSlime.sprite = goldslime;
        /*sz.SerializeEnemy(WaterSlime);
        sz.SerializeEnemy(Slime);
        sz.SerializeEnemy(GoldSlime);*/

        Character[] chars = { Rin, Sam, new Character() };

        GameObject.Find("GameController").GetComponent<GameUser>().user.party.SetActives(chars);
        //GameObject.Find("GameController").GetComponent<GameUser>().user.party.SelectCharacter(1);
        //Debug.Log(GameObject.Find("GameController").GetComponent<GameUser>().user.party.GetSelectedCharacter().Name);

        GameObject.Find("GameController").GetComponent<EnemyGenLists>().plains.Add(Slime);
        GameObject.Find("GameController").GetComponent<EnemyGenLists>().plains.Add(GoldSlime);
        GameObject.Find("GameController").GetComponent<EnemyGenLists>().plains.Add(WaterSlime);
    }
}