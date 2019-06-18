using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickButton : MonoBehaviour
{
    
     public void OnClick(){
        //gold = gold + goldperClick;
        int goldperClick = DataController.GetInstance().GetGoldPerClick();
        DataController.GetInstance().AddGold(goldperClick);
    }

}
