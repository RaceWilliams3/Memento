using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    private Vector3 rot;

    private Vector3 scale;

    [SerializeField]
    private Transform trans;

    public Memento Save()
    {
        return new Memento(rot, scale);
    }

    public void Restore(Memento mem)
    {
        rot = mem.getRot();
        scale = mem.getScale();

        trans.localScale = scale;
        trans.eulerAngles = rot;
    }

    public void UpdateCube(Vector3 nRot, Vector3 nScale)
    {
        rot = nRot;
        scale = nScale;

        Debug.Log("Updated");
        trans.localScale = scale;
        trans.eulerAngles = rot;
    }
}

public class Memento
{
    private Vector3 rot;

    private Vector3 scale;

    public Memento(Vector3 r, Vector3 s)
    {
        rot = r;
        scale = s;
    }

    public Vector3 getRot() { return rot; }
    public Vector3 getScale() { return scale; }
}