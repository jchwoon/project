using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIPopup : UIBase
{
    public virtual void Init()
    {
        Managers.UIManager.SetCanvas(gameObject, true);
    }
}
