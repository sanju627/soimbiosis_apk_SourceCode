using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuBuy : MonoBehaviour
{
    public int prize;
    public MenuImporter menuImporter;
    PlayfabManager database;
    [Space]
    public string databaseItem;
    public int value;

    // Start is called before the first frame update
    void Start()
    {
        database = GameObject.FindGameObjectWithTag("Database").GetComponent<PlayfabManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void BuyBTN()
    {
        if(prize <= menuImporter.money)
        {
            database.SendData(databaseItem, value.ToString());

            menuImporter.money -= prize;
            database.SendData("Coins", menuImporter.money.ToString());
        }
    }
}
