using System.Collections;
using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;

[InlineEditor]
[CreateAssetMenu(fileName = "DataString_SO", menuName = "Data/DataString_SO")]
public class DataString_SO : DataSO_Abs<string>
{
    public override void SetData(string data)
    {
        this.data = data;
    }

    public override string GetData()
    {
        return data;
    }
}
