using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointScript : MonoBehaviour
{
    private GameObject pointtext;
    int score = 0;
    // Start is called before the first frame update
    void Start()
    {
        this.pointtext = GameObject.Find("Point");
        this.pointtext.GetComponent<Text>().text = score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "SmallStarTag")
        {
            score += 10;
            this.pointtext.GetComponent<Text>().text = score.ToString();
        }
        else if (collision.gameObject.tag == "LargeStarTag")
        {
            score += 20;
            this.pointtext.GetComponent<Text>().text = score.ToString();
        }
        else if (collision.gameObject.tag == "SmallCloudTag")
        {
            score += 30;
            this.pointtext.GetComponent<Text>().text = score.ToString();
        }
        else if (collision.gameObject.tag == "LargeCloudTag")
        {
            score += 40;
            this.pointtext.GetComponent<Text>().text = score.ToString();
        }

    }

}
