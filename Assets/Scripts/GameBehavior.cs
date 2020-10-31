using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameBehavior : MonoBehaviour
{
    private uint health_Marble = 100;
    private uint goals_reached = 0;

    public uint HealthMarble{
        get {return health_Marble; }
        set { health_Marble = value; }
    }

    public uint Goals{
        get {return goals_reached; }
        set { goals_reached = value; }
    }

}
