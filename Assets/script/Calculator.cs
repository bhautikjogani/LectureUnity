using System.Linq;
using UnityEngine;
using UnityEngine.UI;

enum Equation
{
    PLUS, MINUS
}

public class Calculator : MonoBehaviour
{

    //public Text temp123;
    [SerializeField] Text temp123;

    string firstValue = "";
    Equation equation;

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

    public void clickPlus()
    {
        firstValue = temp123.text;
        temp123.text = "";
        equation = Equation.PLUS;
    }

    public void clickMinus()
    {
        firstValue = temp123.text;
        temp123.text = "";
        equation = Equation.PLUS;
    }

    public void answer()
    {
        int a = int.Parse(firstValue);
        int b = int.Parse(temp123.text);
        if (equation == Equation.PLUS)
        {
            int total = a + b;
            temp123.text = total.ToString();
        }
        else if (equation == Equation.MINUS)
        {
            int total = a - b;
            temp123.text = total.ToString();
        }
    }

}


