namespace ObjektorienteradP.Common;

public class TextInputError : UserError
{
    public override string UEMessage() => "Du försökte använda en text input i ett endast numeriskt fält. Detta gav ett fel!";
}
