using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitFactory : MonoBehaviour {

    Dictionary<string, GameObject> dic = new Dictionary<string, GameObject>();
    public GameObject marine3;

    public GameObject getMarine(string name)
    {
        if (!dic.ContainsKey(name))
        {
            float x = (float)Random.Range(-10, 11);
            float z = (float)Random.Range(-10, 11);
            Vector3 pos = new Vector3(x, 1.0f, z);

            //Marine obj = new Marine(name);
            GameObject obj = Instantiate(marine3, pos, Quaternion.identity);
            obj.GetComponent<Marine3>().setName(name);
            dic.Add(name, obj);
        }
        return dic[name];
    }
}

