using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Caretaker : MonoBehaviour
{
    [Header("UI Elements")]

    public Slider xScale;
    public Slider yScale;
    public Slider zScale;

    public Slider xRot;
    public Slider yRot;
    public Slider zRot;

    [Header("Cube Controller")]

    public CubeController cube;

    private List<Memento> saves = new List<Memento>();

    public void OnUpdateButton()
    {
        cube.UpdateCube(new Vector3(xRot.value,yRot.value, zRot.value), new Vector3(xScale.value, yScale.value, zScale.value));
        saves.Add(cube.Save());
    }

    public void OnUndoButton()
    {
        cube.Restore(saves[saves.Count - 1]);
        saves.RemoveAt(saves.Count - 1);
    }


}
