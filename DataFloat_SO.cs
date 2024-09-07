using System.Collections;
using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;

[InlineEditor]
[CreateAssetMenu(fileName = "DataFloat_SO", menuName = "Data/DataFloat_SO")]
public class DataFloat_SO : DataSO_Abs<float>
{
    public override void SetData(float data)
    {
        this.data = data;
    }

    public override float GetData()
    {
        return data;
    }
}
