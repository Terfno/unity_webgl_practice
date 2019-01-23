using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button : MonoBehaviour {
	public void OnClick(){
		Debug.Log("Button Click!");
        Vector3 tmp = GameObject.Find("tama").transform.position;
        GameObject.Find("tama").transform.position = new Vector3(tmp.x, tmp.y = 3.42f, tmp.z);
    }
}
