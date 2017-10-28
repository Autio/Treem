using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Creator : MonoBehaviour {
    public Transform unit;

    int x, z = 1;
    int y = 0;

	// Use this for initialization
	void Start () {
        create(new Vector3(1,0,0), true, false, true);	
	}
    
    void create(Vector3 pos, bool xSymmetry, bool ySymmetry, bool zSymmetry)
    {
            int x = Mathf.FloorToInt(pos.x);
            int y = Mathf.FloorToInt(pos.y);
            int z = Mathf.FloorToInt(pos.z);
            Transform t = Instantiate(unit, new Vector3(x, y, z), Quaternion.identity);
            t.parent = GameObject.Find("Main Camera").transform;

            if (xSymmetry)
            {
                t = Instantiate(unit, new Vector3(-x, y, z), Quaternion.identity);
                t.parent = GameObject.Find("Main Camera").transform;

            }
            if (ySymmetry)
            {
                t = Instantiate(unit, new Vector3(x, -y, z), Quaternion.identity);
                t.parent = GameObject.Find("Main Camera").transform;

            }
            if (ySymmetry)
            {
                t = Instantiate(unit, new Vector3(x, y, -z), Quaternion.identity);
                t.parent = GameObject.Find("Main Camera").transform;

            }
            
        }
    

	// Update is called once per frame
	void Update () {
		
	}
}
