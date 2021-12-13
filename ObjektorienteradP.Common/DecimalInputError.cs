namespace ObjektorienteradP.Common;

public class DecimalInputError : UserError
{
    public override string UEMessage() => "Du försökte använda en decimala input i ett endast heltal nummer fält. Detta gav ett fel!";
}
