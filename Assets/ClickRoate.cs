using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickRotate : MonoBehaviour
{
    Transform tfCube;
    private float durationTime = 6;  // 计时器所持续的时间
    private float aTimer = 0;
    bool haveClick = false;

    void Start()
    {
        tfCube = GameObject.Find("Cube").GetComponent<Transform>();
    }

    void Update()
    {
        if (haveClick)
        {
            aTimer += Time.deltaTime;  // 当点击之后就开始计时
            tfCube.Rotate(Vector3.up, 60 * Time.deltaTime);// 物体开始旋转

            // 当计时器的时间达到了规定的时间就开始停止
            if (aTimer >= durationTime)
            {

                haveClick = false;
                aTimer = 0;
            }
        }
    }

    /// <summary>
    /// 点击之后开始执行该函数，必须将该函数设置为公有的属性
    /// </summary>
    public void IsClick()
    {
        haveClick = true;
    }
}