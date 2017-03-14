using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class graphicsSettingsBehaviour : MonoBehaviour {


    static string[] names;
    List<string> nameslist = new List<string>();
    public Dropdown graphicsOptions;
    public Text selectedGraphics;

    void Start()
    {
        names = QualitySettings.names;
        nameslist = names.OfType<string>().ToList();
        populateList();
        graphicsControl();
    }

    public void graphicsControl()
    {
        int index = graphicsOptions.value;

        selectedGraphics.text = nameslist[index];
        if (index == 0)
        {

            QualitySettings.SetQualityLevel(index, true);

        }
        if (index == 1)
        {
            QualitySettings.SetQualityLevel(index, true);


        }
        if (index == 2)
        {
            QualitySettings.SetQualityLevel(index, true);


        }
        if (index == 3)
        {
            QualitySettings.SetQualityLevel(index, true);


        }
        if (index == 4)
        {
            QualitySettings.SetQualityLevel(index, true);


        }
        if (index == 5)
        {
            QualitySettings.SetQualityLevel(index, true);


        }
    }

    void populateList()
    {
        graphicsOptions.AddOptions(nameslist);
    }

}
