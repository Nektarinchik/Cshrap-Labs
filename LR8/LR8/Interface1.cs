namespace Transport
{
    interface ICondition
    {
        string condition { get; set; }
        string Maintainability();
    }
}