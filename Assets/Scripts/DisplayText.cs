using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayText : MonoBehaviour
{
    // Start is called before the first frame update

	private float displaytextint = 0;
	public Text displaytext;

    void Start()
    {
        displaytext.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SummonText(float SummonAmount)
    {
        if (SummonAmount == 1)
        {
            displaytext.text = "Bring the Emerald to the Large Room";
        }
        if (SummonAmount == 2)
        {
            displaytext.text = "Pull all of the Levers to spell the name of God";
        }
        if (SummonAmount == 0)
        {
            displaytext.text = "";
        }
    }
}
