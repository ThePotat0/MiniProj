using UnityEngine;

public class SinMover : MonoBehaviour
{
    [SerializeField] private float _t = 0;
    [SerializeField] private float _amp = 0.25f;
    [SerializeField] private float _freq = 0.2f;
    [SerializeField] private float _offset = 0;
    private Vector3 _strartPos;

    private void Start()
    {
        _strartPos = transform.position;
    }

    private void Update()
    {
        _t = _t + Time.deltaTime;
        _offset = _amp * Mathf.Sin(_t * _freq);

        transform.position = _strartPos + new Vector3(0, _offset, 0);
    }
}
