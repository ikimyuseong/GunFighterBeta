using UnityEngine;

public class BombAction : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
    }
}
