using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class fStack : MonoBehaviour{

    public abstract void Push(float number);
    public abstract void Clear();
    public abstract float Pop();
    public abstract float Count();
}