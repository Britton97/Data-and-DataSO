using System.Collections;
using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;

[InlineEditor]
[CreateAssetMenu(fileName = "DataStringList_SO", menuName = "Data/DataStringList_SO")]
public class DataStringList_SO : DataSO_Abs<List<string>>
{
    public override List<string> GetData()
    {
        return data;
    }

    public override void SetData(List<string> data)
    {
        this.data = data;
    }
}
