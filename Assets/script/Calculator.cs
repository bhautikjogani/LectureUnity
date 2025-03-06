using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class Calculator : MonoBehaviour
{

    //public Text temp123;
    [SerializeField] Text temp123;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //temp123.text = "welcome";
    }

    public void click1()
    {
        temp123.text += "1";
    }

    public void click2()
    {
        temp123.text = temp123.text + "2";
    }

    public void click3()
    {
        temp123.text = temp123.text.Concat("2").ToString();
    }

    public void click(string text)
    {
        temp123.text += text;
    }

}


