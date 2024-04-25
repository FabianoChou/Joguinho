using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClearTImer : MonoBehaviour
{
    [SerializeField] Text timeText;
    float clearTime;
    
    void FixedUpdate()
    {
        clearTime += Time.fixedDeltaTime;
        timeText.text = clearTime.ToString();
    }
}
