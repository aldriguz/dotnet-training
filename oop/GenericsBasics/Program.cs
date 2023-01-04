
var myBaseObject = new BaseClass()
{
    Field1 = "Value1",
    Field2 = "Value2",
    Field3 = "Value3",
    Field4 = "Value4",
    Field5 = "Value5"
};

var myExtendedObject = new ExtendedClass()
{
    UniqueField1 = "Unique1",
};

Console.WriteLine($"ExtendedClass matchs BaseClass: {ClassValidator.ExtendedClassValidator(myExtendedObject)}");