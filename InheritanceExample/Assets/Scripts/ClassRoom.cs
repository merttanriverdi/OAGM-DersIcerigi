#region Header
// ClassRoom.cs
// Developed by Taygun Savas
// taygun.savas@triflesgames.com
#endregion

using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ClassRoom : MonoBehaviour
{
    public List<Student> Students;
    public GameObject studentPrefab;
    private float _xOffset = 3f;

    private void Start()
    {
        for (int i = 0; i < Students.Count; i++)
        {
            SetupStudent(i,Students[i].Name,Students[i].StudentId,Students[i].StudentColor);
        }
    }

    private void SetupStudent(int x, string studentName, int studentId, Color targetColor)
    {
        Vector3 position = new Vector3(x * _xOffset, 0,0);
        GameObject studentObject = Instantiate(studentPrefab, position, 
            Quaternion.identity,transform);
        studentObject.name = studentName;
        string title = studentName + " - " + studentId;
        TextMeshProUGUI studentTextMesh = studentObject.GetComponentInChildren<TextMeshProUGUI>();
        studentTextMesh.text = title;
        studentTextMesh.color = targetColor;
    }
}