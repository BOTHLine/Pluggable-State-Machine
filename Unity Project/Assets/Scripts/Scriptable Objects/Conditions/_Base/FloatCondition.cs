using UnityEngine;

public class FloatCondition : Condition
{
    public FloatReference _Value;

    public ComparisonOperator _ComparisonOperator;

    public FloatReference _ComparisonValue;

    public override bool IsTrue
    {
        get
        {
            switch (_ComparisonOperator)
            {
                case ComparisonOperator.Equals: return _Value == _ComparisonValue;
                case ComparisonOperator.NotEquals: return _Value != _ComparisonValue;
                case ComparisonOperator.Less: return _Value < _ComparisonValue;
                case ComparisonOperator.Greater: return _Value > _ComparisonValue;
                case ComparisonOperator.LessEquals: return _Value <= _ComparisonValue;
                case ComparisonOperator.GreaterEquals: return _Value >= _ComparisonValue;
                default: return false;
            }
        }
    }
}