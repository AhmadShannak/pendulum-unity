using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pendulum : MonoBehaviour {
  LineRenderer pendulumRobe;

  private void Start() {
    pendulumRobe = this.GetComponent<LineRenderer>();
    
  }

  private void Update() {
    pendulumRobe.SetPosition(0, this.transform.position);
  }
}
