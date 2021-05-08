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
      LButtonDown();
    }

    if (Input.GetKeyDown(KeyCode.RightArrow))
    {
      RButtonDown();
    }
  }

  public void LButtonDown()
  {
    transform.Translate(-moveSpeed, 0, 0);
  }

  public void RButtonDown()
  {
    transform.Translate(moveSpeed, 0, 0);
  }
}
