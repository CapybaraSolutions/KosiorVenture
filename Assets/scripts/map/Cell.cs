using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public abstract class Cell  {

    private Image m_Texture;
    private float m_Resistance;
    public Image Texture
    {
        get
        {
            return m_Texture;
        }

        set
        {
            m_Texture = value;
        }
    }

    public float Resistance
    {
        get
        {
            return m_Resistance;
        }

        set
        {
            m_Resistance = value;
        }
    }
}
