using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Util
{

    // Function for setting new layers on GameObject
    public static void SetLayerRecursively(GameObject obj, int _newLayer)
    {
        if (obj == null)
            return;

        obj.layer = _newLayer;

        foreach (Transform _child in obj.transform)
        {
            if (obj == null)
                return;

            SetLayerRecursively(_child.gameObject, _newLayer);
        }

    }
}
