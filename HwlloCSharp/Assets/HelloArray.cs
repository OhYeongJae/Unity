using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloArray : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        int[] scores = new int[10];
        
        scores[0] = 90;
        scores[1] = 40;
        scores[2] = 70;

        for(int i = 0 ; i < 10 ; i++)
        {
            scores[i] = i*10;
        }
          for(int i = 0 ; i < 10 ; i++)
        {
           Debug.Log(i + "번째 점수 : " + scores[i]);
        }
    }


}
