using UnityEngine;

public class CameraMover : MonoBehaviour
{
    [SerializeField] private Transform target; // Целевой объект, за которым будет следовать камера
    [SerializeField] private float smoothSpeed = 0.125f; // Скорость сглаживания
    [SerializeField] private Vector3 offset; // Смещение камеры относительно целевого объекта

    private void LateUpdate()
    {
        if (target != null)
        {
            // Вычисляем желаемую позицию камеры
            Vector3 desiredPosition = target.position + offset;

            // Интерполяция между текущей позицией камеры и желаемой позицией
            Vector3 smoothedPosition = Vector3.Lerp(transform.position, new Vector3(desiredPosition.x, transform.position.y, transform.position.z), smoothSpeed);

            // Обновляем позицию камеры
            transform.position = smoothedPosition;
        }
    }
}
