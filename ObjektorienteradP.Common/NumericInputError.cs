namespace ObjektorienteradP.Common;

public class NumericInputError : UserError
{
    public override string UEMessage() => "Du försökte använda en numerisk input i ett endast text fält. Detta gav ett fel!";
}
