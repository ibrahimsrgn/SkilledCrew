using UnityEngine;

public class PlayerAim : MonoBehaviour
{
    [SerializeField] private Transform firePoint;
    [SerializeField] private Transform fireRod;
    private void Update()
    {
        // Fare pozisyonunu dünya koordinatlarına çeviriyoruz
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        // 2D ortamda sadece z eksenini dikkate almak için z'yi sıfırlıyoruz
        mousePosition.z = 0;

        // Dönüşüm için yön vektörünü hesaplıyoruz
        Vector2 lookDir = (mousePosition - fireRod.position).normalized;

        // Yön vektörünü kullanarak dönüşümü uyguluyoruz
        fireRod.rotation = Quaternion.FromToRotation(Vector2.right, lookDir);
    }
}
