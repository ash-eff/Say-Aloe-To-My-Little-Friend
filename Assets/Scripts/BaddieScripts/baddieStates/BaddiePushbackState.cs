﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaddiePushbackState : State<BaddieController>
{
    public override void EnterState(BaddieController baddie)
    {
        Debug.Log("Push State");
    }

    public override void ExitState(BaddieController baddie)
    {
    }

    public override void UpdateState(BaddieController baddie)
    {
        baddie.IsGameOver();
        baddie.CheckScreenPos();
        Walk(baddie);
    }

    public override void FixedUpdateState(BaddieController baddie)
    {
    }

    void Walk(BaddieController baddie)
    {
        float step = baddie.Speed * Time.deltaTime;
        baddie.transform.position = Vector2.MoveTowards(baddie.transform.position, baddie.Target, step);
    }
}
