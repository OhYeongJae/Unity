using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataController : MonoBehaviour
{
    private static DataController instance;  
    public static DataController GetInstance()
    {
        if(instance == null)
        {
            instance = FindObjectOfType<DataController>();

            if(instance == null)
            {
                GameObject container = new GameObject("DataController");
                instance = container.AddComponent<DataController>();
            }
        }
        return instance;
    }

    private ItemButton[] itemButtons;


    private int m_gold = 0;
    private int m_goldPerClick = 0;

    void Awake(){ // 게임 시작시 실행되는 함수
       // KEY : VALUE
        m_gold = PlayerPrefs.GetInt("Gold");
        m_goldPerClick = PlayerPrefs.GetInt("GoldPerClick",1); // (KEY, 기본값) 기본값 없으면 0

        itemButtons = FindObjectsOfType<ItemButton>();
    }

    public void SetGold(int newGold){
        m_gold = newGold;
        PlayerPrefs.SetInt("Gold", m_gold);
    }
    public void AddGold(int newGold){
        m_gold += newGold;
        SetGold(m_gold);
    }
    public void SubGold(int newGold){
        m_gold -= newGold;
        SetGold(m_gold);
    }
    public int GetGold(){
        return m_gold;
    }
    public int GetGoldPerClick(){
        return m_goldPerClick;
    }

    public void SetGoldPerClick(int newGoldPerClick){
        m_goldPerClick = newGoldPerClick;
        PlayerPrefs.SetInt("GoldPerClick",m_goldPerClick);
    }

    public void AddGoldPerClick(int newGoldPerClick){
        m_goldPerClick += newGoldPerClick;
        SetGoldPerClick(m_goldPerClick);
    }
    public void LoadUpgradeButton(UpgradeButton upgradeButton)
    {
        string key = upgradeButton.upgradeName;

        upgradeButton.level = PlayerPrefs.GetInt(key + "_level",1);
        upgradeButton.goldByUpgrade = PlayerPrefs.GetInt(key + "_goldByUpgrade",
        upgradeButton.startGoldByUpgrade);
        upgradeButton.currentCost = PlayerPrefs.GetInt(key+ "_const", 
        upgradeButton.startCurrentCost);
    }
        public void SaveUpgradeButton(UpgradeButton upgradeButton)
    {
          string key = upgradeButton.upgradeName;

         PlayerPrefs.SetInt(key + "_level",upgradeButton.level);
         PlayerPrefs.SetInt(key + "_goldByUpgrade",upgradeButton.goldByUpgrade);
         PlayerPrefs.SetInt(key+ "_const", upgradeButton.currentCost);
    }

    public void LoadItemButton(ItemButton itemButton)
    {
        string Key = itemButton.itemName;

        itemButton.level = PlayerPrefs.GetInt(Key+ "_level");
        itemButton.currentCost = PlayerPrefs.GetInt(Key+ "_cost",itemButton.startCurrentcost);
        itemButton.goldPerSec = PlayerPrefs.GetInt(Key + "_goldByUpgrade");
        if(PlayerPrefs.GetInt(Key + "_isPurchased")==1)
        {
            itemButton.isPurchased = true;
        }
        else
        {
             itemButton.isPurchased = false;
        }
    }
    public void SaveItemButton(ItemButton itemButton)
    {
                string Key = itemButton.itemName;

        PlayerPrefs.SetInt(Key+ "_level",itemButton.level);
        PlayerPrefs.SetInt(Key+ "_cost",itemButton.currentCost);
        PlayerPrefs.SetInt(Key + "_goldByUpgrade",itemButton.goldPerSec);
        if(itemButton.isPurchased == true)
        {
            PlayerPrefs.SetInt(Key + "_isPurchased",1);
        }
        else
        {
            PlayerPrefs.SetInt(Key + "_isPurchased",0);
        }
    }

    public int GetGoldPerSec(){
        int goldPerSec = 0;
        for(int i =0 ; i<itemButtons.Length ; i++){
            goldPerSec += itemButtons[i].goldPerSec;
        }
        return goldPerSec;
    }
}
