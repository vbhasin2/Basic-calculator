using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Calculator;

public class buttonHandler : MonoBehaviour
{

    public InputField num1;
    public InputField num2;
    public Text result;
    public Button addButton;
    public Button subButton;

    // Start is called before the first frame update
    void Start()
    {
        addButton.onClick.AddListener(add);
        subButton.onClick.AddListener(sub);
    }

    public void add()
    {
        int a = int.Parse(num1.text);
        int b = int.Parse(num2.text);
        //result.text = (a + b).ToString();
        Calculate cal = new Calculate();
        result.text = cal.Add(a, b).ToString();
    }

    public void sub()
    {
        int a = int.Parse(num1.text);
        int b = int.Parse(num2.text);
        //result.text = (a + b).ToString();
        Calculate cal = new Calculate();
        result.text = cal.Sub(a, b).ToString();
    }

    void Update()
    {
    }
}