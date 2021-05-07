using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowController : MonoBehaviour
{
  [SerializeField] float speed = -0.1f;

  private void Update()
  {
    transform.Translate(0, speed, 0);

    if (transform.position.y < -5.0f)
    {
      Destroy(gameObject);
    }
  }
}
