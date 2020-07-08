using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class Grid : MonoBehaviour
{
    public List<Panel> grid;

    public GameObject redPanel;
    public GameObject bluePanel;

    private void Start() {
        grid = AssignGrid(); 
    }

    public List<Panel> AssignGrid() {
        RenderPanels(GetPanelPositions());

        var result = GetPanelPositions()
            .Select(x => ToIntVector2(x))
            .Select(x => new Panel(x, null, x.x > 0))
            .ToList();

        return result;
    }

    public void RenderPanels(List<Vector2> panels) {
        panels.ForEach(panel => {
            if (panel.x < 0) {
                Instantiate(redPanel, new Vector3(panel.x, panel.y, 0), new Quaternion(0, 0, 0, 0));
            }
            else {
                Instantiate(bluePanel, new Vector3(panel.x, panel.y, 0), new Quaternion(0, 0, 0, 0));
            }
        });
    }

    public static IntVector2 ToIntVector2(Vector2 vec) {
        var newVec = new IntVector2(0, 0);

        if (vec.x == -1.0f) newVec.x = 0;
        else if (vec.x == -0.6f) newVec.x = 1;
        else if (vec.x == -0.2f) newVec.x = 2;
        else if (vec.x ==  0.2f) newVec.x = 3;
        else if (vec.x ==  0.6f) newVec.x = 4;
        else if (vec.x ==  1.0f) newVec.x = 5;
        
        if (vec.y == 0) newVec.y = 0;
        else if (vec.y == -0.24f) newVec.y = 1;
        else if (vec.y == -0.48f) newVec.y = 2;

        return newVec;
    }

    public static List<Vector2> GetPanelPositions() {
	    var xs = new List<float> { -1f, -0.6f, -0.2f, 0.2f, 0.6f, 1f };
	    var ys = new List<float> { 0, -0.24f, -0.48f };

	    var results = (
		    from x in xs
		    from y in ys
		    select new Vector2(x, y)
	    );
	
	    return results
		    .OrderBy(v => v.x)
		    .OrderByDescending(v => v.y)
		    .ToList();
    }
}