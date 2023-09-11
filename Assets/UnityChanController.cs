using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnityChanController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //マウスがクリックされた場合
        if (Input.GetMouseButtonDown(0))
        {
            //Animationコンポーネントを取得し”jumpTrigger"をtrueにする
            GetComponent<Animator>().SetTrigger("JumpTrigger");
        }
    }
}
