using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIMannager : MonoBehaviour
{
   public Text goldDisplayer;
   public Text goldPerDisplayer;
   public Text goldPerSecDisplayer;
   void Update(){ // 1프레임당 1실행
        goldDisplayer.text = "GOLD: " + DataController.Instance.gold;
        goldPerDisplayer.text = "Add GOLD: " +DataController.Instance.goldPerClick;
        goldPerSecDisplayer.text = "GOLD PER SEC : " + DataController.Instance.GetGoldPerSec();
   }

}
