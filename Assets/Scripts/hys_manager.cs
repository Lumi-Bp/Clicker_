using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class hys_manager : MonoBehaviour
{
    public TextMeshProUGUI priceText;
    public TextMeshProUGUI countText;
    public float bakeOffset = 2;
    public int cookies = 1;
    public int count = 0;
    public float price = 10;
    public Clicker clicker;
    // Start is called before the first frame update
    void Start()
    {
        priceText.text = $"price: {price}";
        countText.text = count.ToString() ;
        InvokeRepeating(nameof(Bake), 0, bakeOffset);
    }
    void Bake()
    {
        if(count == 0) return;
        clicker.Clicks += count * cookies;
    }
    public void Buy() {
        int roundedprice = Mathf.CeilToInt(price);
    if(clicker.Clicks >= roundedprice)
        {
            clicker.Clicks -= roundedprice;
            count++;
            countText.text = count.ToString() ;
            price *= 1.2f;
            priceText.text = $"price: {Mathf.CeilToInt(price)}";
        }
            }

    // Update is called once per frame
    void Update()
    {
        
    }
}
