using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FArrayStack : fStack {

    public int stackPointer = 0;
    public float[] stackElements;

    void Start ()
    {
        stackElements = new float[10];
    }

    override public void Push(float number)
    {
        if (stackPointer >= 0 &&  stackPointer < 10)
        {
            stackElements[stackPointer] = number;
            stackPointer++;
        }
    }

    public override float Pop()
    {
        if(stackPointer > 0)
        stackPointer--;
        return stackElements[stackPointer];
    }

    public override float Count()
    {
        return stackPointer;
    }

    public override void Clear()
    {
        stackPointer = 0;
    }
}
