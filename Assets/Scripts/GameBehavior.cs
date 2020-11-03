using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameBehavior : MonoBehaviour
{
    public string labelText = "Collect all 4 goals to win!";
    public int maxGoals = 4;

    private uint health_Marble = 100;
    private uint goals_reached = 0;

    public uint HealthMarble{
        get {return health_Marble; }
        set { health_Marble = value; }
    }

    public uint Goals
    {
        get { return goals_reached; }
        set
        {
            goals_reached = value;

            if (goals_reached == maxGoals)
            {
                labelText = "Awesome! You've got them all, you winner!";
            }
            else if (goals_reached == 1 || goals_reached == 3)
            {
                labelText = string.Format("Nice! Only {0} left to find!",
                    maxGoals - goals_reached);
            }
            else
            {
                labelText = string.Format("Super! Only {0} left to find!",
                    maxGoals - goals_reached);
            }

        }
    }

    private void OnGUI()
    {
        GUI.skin.label.fontSize = 24;
        GUI.skin.label.fontStyle = FontStyle.Bold;
        GUI.skin.box.fontStyle = FontStyle.Normal;

        GUI.Box(new Rect(20, 20, 150, 25), "");
        GUI.Box(new Rect(20, 20, 150, 25), "");
        GUI.Box(new Rect(20, 20, 150, 25),
            "Marble Health: " + health_Marble);

        GUI.Box(new Rect(20, 50, 150, 25), "");
        GUI.Box(new Rect(20, 50, 150, 25),"");
        GUI.Box(new Rect(20, 50, 150, 25),
            "Goals Collected: " + goals_reached);

        GUI.contentColor = new Color(0, 0, 0);

        GUI.Label(new Rect((Screen.width / 2) - 100,
            Screen.height - 50, 300, 50), labelText);

        GUI.contentColor = new Color(255, 255, 255);
    }

}
