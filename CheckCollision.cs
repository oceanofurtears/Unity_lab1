using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckCollision : MonoBehaviour
{

    void Start() {

    }

    void Update() {

    }

    private void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.name == "Cube") {
            Debug.Log("Вошло");
            collision.gameObject.GetComponent<Renderer>().material.SetColor("_Color", Color.green);
        }

        if (collision.gameObject.name == "Plane") {
            Debug.Log("Сломалось");
            Destroy(gameObject);
        }
    }

    private void OnCollisionExit(Collision collision){
        if (collision.gameObject.name == "Cube") {
            Debug.Log("Ушло");
            collision.gameObject.GetComponent<Renderer>().material.SetColor("_Color", Color.red);
        }
    }
}
