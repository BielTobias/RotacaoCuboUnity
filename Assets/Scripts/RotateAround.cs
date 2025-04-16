using UnityEngine;
using UnityEngine.UIElements;

public class RotateAround : MonoBehaviour
{

    public float speed; //vou arrumando e editando no proprio unity
    public Transform target;
    public Vector3 rotationAxis = Vector3.up;

    public void Start()
    {
        if (target != null) return;
        target = transform;
        Debug.LogWarning("Alvo não atribuído. Usando o próprio objeto como alvo.");

    }
    private void Update()
    {

        if (target != transform)
        {
            transform.RotateAround(
                target.position,
                rotationAxis.normalized, 
                speed * Time.deltaTime);
        }

        transform.Rotate(
        Vector3.up * speed * Time.deltaTime); // rotação local
    }

}


