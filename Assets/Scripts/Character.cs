using UnityEngine;

public class Character : MonoBehaviour
{
    protected MoveBehaviour _mb;
    void Start()
    {
        _mb = GetComponent<MoveBehaviour>();
    }
}
