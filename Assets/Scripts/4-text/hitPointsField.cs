using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hitPointsField : MonoBehaviour
{
    private TextMesh textField;
    private int number = 3;
    void Start()
    {
        textField = GetComponent<TextMesh>();
        if (!textField)
            throw new MissingComponentException("Object must contain a TextMeshPro field!");
    }





    public void SetNumber(int newNumber)
    {
        this.number = newNumber;
        this.textField.text = "HIT POINTS: " + number.ToString();
    }

    public int getNumber()
    {
        return this.number;
    }
}
