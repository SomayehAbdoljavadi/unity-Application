using UnityEngine;
using UnityEngine.UI;


public class Button : MonoBehaviour {

	private string Name;
	public Text ButtonText;
	public ScrollView ScrollView;

    public string ReferencedFile;



	public void SetName(string name)
	{
		Name = name;
		ButtonText.text = name;


    }
	public void Button_Click()
	{
	    ScrollView.ButtonClicked(Name);

	}
} 



