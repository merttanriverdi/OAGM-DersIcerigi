#region Header

// CameraController.cs
// Developed by Taygun Savas
// taygun.savas@triflesgames.com

#endregion

using UnityEngine;

public class CameraController : MonoBehaviour
{
    private Vector3 _followOffset;

    [SerializeField] private Transform _target;

    private void Start()
    {
        _followOffset = transform.position - _target.position;
    }

    private void LateUpdate()
    {
        transform.position = _target.position + _followOffset;
    }
}