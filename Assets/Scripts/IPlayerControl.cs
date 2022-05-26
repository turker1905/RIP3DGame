using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IPlayerControl 
{
    public float HorizontalAxis { get; }
    public float VerticalAxis { get;  }
    public float JumpAxis { get;  }

}
