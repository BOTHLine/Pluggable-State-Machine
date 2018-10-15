using UnityEngine;

[System.Serializable]
public abstract class Condition
{
    public abstract bool IsTrue { get; }
}

public enum ComparisonOperator
{
    Equals,
    NotEquals,
    Less,
    Greater,
    LessEquals,
    GreaterEquals
}