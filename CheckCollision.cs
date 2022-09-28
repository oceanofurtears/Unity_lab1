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
            Debug.Log("�����");
            collision.gameObject.GetComponent<Renderer>().material.SetColor("_Color", Color.green);
        }

        if (collision.gameObject.name == "Plane") {
            Debug.Log("���������");
            Destroy(gameObject);
        }
    }

    private void OnCollisionExit(Collision collision){
        if (collision.gameObject.name == "Cube") {
            Debug.Log("����");
            collision.gameObject.GetComponent<Renderer>().material.SetColor("_Color", Color.red);
        }
    }
}
