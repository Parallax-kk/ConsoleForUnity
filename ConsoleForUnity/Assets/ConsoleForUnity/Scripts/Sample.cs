using UnityEngine;
using UnityEngine.UI;

public class Sample : MonoBehaviour
{
    [SerializeField]
    private Text m_Text = null;

	void Start ()
    {
        m_Text.text = Console.LaunchConsole("ipconfig", "/all");
	}
}
