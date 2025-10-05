using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

[System.Serializable]
public class StoreItem
{
    public string name;
    public int cost;
    public Sprite icon;
}

public class StoreManager : MonoBehaviour
{
    public List<StoreItem> items;
    public Transform contentPanel;
    public GameObject itemPrefab;
    public Text currencyText;

    private int playerCoins = 500;

    void Start()
    {
        UpdateCurrency();
        if(items == null) return;
        foreach (var item in items)
        {
            if(itemPrefab == null || contentPanel == null) break;
            GameObject obj = Instantiate(itemPrefab, contentPanel);
            var nameTF = obj.transform.Find("Name")?.GetComponent<Text>();
            var costTF = obj.transform.Find("Cost")?.GetComponent<Text>();
            var iconImg = obj.transform.Find("Icon")?.GetComponent<Image>();
            var buyBtn = obj.transform.Find("BuyButton")?.GetComponent<Button>();

            if(nameTF) nameTF.text = item.name;
            if(costTF) costTF.text = item.cost.ToString();
            if(iconImg && item.icon) iconImg.sprite = item.icon;
            if(buyBtn) buyBtn.onClick.AddListener(() => Buy(item));
        }
    }

    void Buy(StoreItem item)
    {
        if (playerCoins >= item.cost)
        {
            playerCoins -= item.cost;
            UpdateCurrency();
            Debug.Log($"Purchased: {item.name}");
        }
        else
        {
            Debug.Log("Not enough coins!");
        }
    }

    void UpdateCurrency()
    {
        if(currencyText) currencyText.text = $"Coins: {playerCoins}";
    }
}
