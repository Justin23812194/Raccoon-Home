using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlManager : MonoBehaviour
{
    public GameObject target;
    public float value;
    public Vector3 sizeChange;

    public void MoveLeft() {
        value -= 0.1f;
        target.transform.position = new Vector3(value, 1, -5.5f);
    }

    public void RotateLight() {
        target.transform.Rotate(0f, 20f, 0f);
    }

    public void Grow() {
        target.transform.localScale += sizeChange;
    }

    public void Reset() {
        target.transform.position = new Vector3(-0.6f, 1, -5.5f);
        target.transform.rotation = Quaternion.Euler(new Vector3(0, 0, 0));
        target.transform.localScale = new Vector3(0.45f, 0.45f, 0.45f);
        value = -0.6f;
    }
}
