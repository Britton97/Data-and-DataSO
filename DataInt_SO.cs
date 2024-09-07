using System.Collections;
using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;

[InlineEditor]
[CreateAssetMenu(fileName = "DataInt_SO", menuName = "Data/DataInt_SO")]
public class DataInt_SO : DataSO_Abs<int>
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
