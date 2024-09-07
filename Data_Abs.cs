using System;
using System.Collections;
using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;

public class DataSO_Abs<T> : SerializedScriptableObject
{
    public T data;
    public virtual void SetData(T data)
    {
        this.data = data;
    }

    public virtual T GetData()
    {
        return data;
    }
}

public abstract class Data_Abs<T>
{
    public T data;
    public abstract void SetData(T data);
    public abstract T GetData();
}
public class Data_Int : Data_Abs<int>
{
    public override void SetData(int data)
    {
        this.data = data;
    }

    public override int GetData()
    {
        return data;
    }
}
