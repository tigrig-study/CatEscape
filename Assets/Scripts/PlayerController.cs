using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
  [SerializeField] float moveSpeed = 3;

  private void Update()
  {

    if (Input.GetKeyDown(KeyCode.LeftArrow))
    {
      transform.Translate(-moveSpeed, 0, 0);
    }

    if (Input.GetKeyDown(KeyCode.RightArrow))
    {
      transform.Translate(moveSpeed, 0, 0);
    }
  }
}
