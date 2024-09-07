using System.Collections;
using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;

[InlineEditor]
[CreateAssetMenu(fileName = "DataGameObject_SO", menuName = "Data/DataGameObject_SO")]
public class DataGameObject_SO : DataSO_Abs<GameObject>
{
    public override void SetData(GameObject data)
    {
        this.data = data;
    }

    public override GameObject GetData()
    {
        return data;
    }
}
