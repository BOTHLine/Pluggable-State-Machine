using UnityEngine;

public class BoolCondition : Condition
{
    public BoolReference _Value;

    public ComparisonOperator _ComparisonOperator;

    public BoolReference _ComparisonValue;

    public override bool IsTrue { get { return _Value.Value == _ComparisonValue.Value; } }
}