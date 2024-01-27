using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Text1 : MonoBehaviour
{
    // Start is called before the first frame update
    private float timeleft2 = 15;
    public GameObject Text3;
	public Text starttext;
    void Start()
    {
        starttext.text = "";
		text1();
    }

    // Update is called once per frame
    void Update()
    {
        timeleft2 -= Time.deltaTime;
        if (timeleft2 < 10)
        {
            starttext.text = "You must complete all four Puzzles";
		}
		if (timeleft2 < 5)
		{
			starttext.text = "within these halls or you shall never escape";
		}
		if (timeleft2 < 0)
		{
			starttext.text = "";
		}
    }

	void text1()
	{
		starttext.text = "Welcome To the Realm Of the Gods";
	}
}
