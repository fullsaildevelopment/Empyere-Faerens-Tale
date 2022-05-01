using UnityEngine;
using UnityEngine.UI;

public class ShopManager : MonoBehaviour
{
    public static ShopManager instance;

    public int coins = 300;
    public Upgrade[] upgrades;

    public Text coinText;
    public GameObject shopUI;
    public Transform shopContent;
    public GameObject itemPrefab;
    public Player player;
    
    
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);
    }
    private void Start()
    {
        foreach (Upgrade upgrade in upgrades)
        {
            //checking the item boxes in the shop and loading them full of stuff :) 
            GameObject item = Instantiate(itemPrefab, shopContent);
            upgrade.itemRef = item;
            foreach(Transform child in item.transform)
            {
                if (child.gameObject.name == "Quantity")
                {
                    child.gameObject.GetComponent<Text>().text = upgrade.quantity.ToString();

                }
                else if (child.gameObject.name == "Cost")
                {
                    child.gameObject.GetComponent<Text>().text ="$" + upgrade.cost.ToString();
                }
                else if(child.gameObject.name =="Name")
                {
                    child.gameObject.GetComponent<Text>().text = upgrade.name;
                }
                else if (child.gameObject.name == "Image")
                {
                    child.gameObject.GetComponent<Image>().sprite = upgrade.image;
                }
            }
            //buying stuff :D 

            item.GetComponent<Button>().onClick.AddListener(() =>
            {
                BuyUpgrade(upgrade);
            });
        }
    }
    public void BuyUpgrade(Upgrade upgrade)
    {
        //this applies any upgrades we have :) 
        if (coins >= upgrade.cost)
        {
            coins -= upgrade.cost;
            upgrade.quantity++;
            upgrade.itemRef.transform.GetChild(0).GetComponent<Text>().text = upgrade.quantity.ToString();
            ApplyUpgrade(upgrade);

            //connecting to currency in user 
           
        }
       
    }
    public void ApplyUpgrade(Upgrade upgrade)
    {
        switch(upgrade.name)
        {
            case "Speed" :
                player.PlayerSpeed += 2f;
                break;
            default:
                Debug.Log("No upgrade avail :(");
                break;





        }
       
    }
    public void ToggleShop()
    {
        shopUI.SetActive(!shopUI.activeSelf);

    }
    private void OnGUI()
    {
        coinText.text = "Coins:"+ coins.ToString();


    }
}
//upgrade :D
[System.Serializable]
public class Upgrade
{
    public string name;
    public int cost;
    public Sprite image;
    [HideInInspector] public int quantity;
    [HideInInspector] public GameObject itemRef;
    
}