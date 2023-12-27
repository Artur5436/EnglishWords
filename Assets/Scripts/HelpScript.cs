using UnityEngine;
using UnityEngine.UI;

public class HelpScript : MonoBehaviour {

  void Start() {
    GetComponent<Text>().text = Resources.Load<TextAsset>("Help").text;
  }

}
