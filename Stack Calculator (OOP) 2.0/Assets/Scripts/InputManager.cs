using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputManager : MonoBehaviour {

    public fStack myStack;
    public FArrayStack arrayStack;

    public string input;
    public string buttonInput;

    private bool buttonPressed;
    public Text inputText;

    private void Start()
    {
        myStack = arrayStack;
    }

    private void Update()
    {
        if (buttonPressed)
        {
            if (buttonInput == "Enter" && inputText.text != "")
            {
                input = inputText.text;
                myStack.Push(float.Parse(input));
                buttonPressed = false;
                inputText.text = "";
            }

            if (buttonInput == "Pop")
            {
                print(myStack.Pop());
                buttonPressed = false;
            }

            if (buttonInput == "Clear")
            {
                myStack.Clear();
                buttonPressed = false;
            }

            if (buttonInput == "+")
            {
                float v1 = myStack.Pop();
                float v2 = myStack.Pop();
                myStack.Push(v2 + v1);
                buttonPressed = false;
            }

            if (buttonInput == "Count")
            {
                myStack.Count();
                print(myStack.Count());
                buttonPressed = false;
            }

            if (buttonInput != "Clear" && buttonInput != "+" && buttonInput != "=" && buttonInput != "Enter" && buttonInput != "Pop" && buttonInput != "Count")
            {
                inputText.text += buttonInput;
                buttonPressed = false;
            }
        }
	}

    public void ButtonPush()
    {
        buttonInput = gameObject.name;
        buttonPressed = true;
    }
}