using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;


public class LifeBar : MonoBehaviour
{

    [SerializeField]
    [Range(0.0f, 100.0f)]
    public float Health; // valor entre 0~100
    public Image bar;
    // Start is called before the first frame update
    void Start()
    {
        Health = 100;
    }

    // Update is called once per frame
    void Update()
    {
        bar.fillAmount = Health/100;
    }
}
