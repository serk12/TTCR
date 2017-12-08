using System.Collections;
using UnityEngine;

public class Mover : MonoBehaviour {

    private float x;
    private float y;
    private float z;

    private void Start() {
        x = transform.position[0];
        y = transform.position[1];
        z = transform.position[2];
    }

    void OnCollisionEnter (Collision col){
        transform.position = new Vector3 (x+10f, y, z);
        print("tocado");
    }
}
