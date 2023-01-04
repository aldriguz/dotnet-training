public static class ClassValidator
{

    public static bool ExtendedClassValidator(BaseClass objectToCheck)
    {
        if (objectToCheck == null)
            throw new ArgumentNullException();

        return objectToCheck is ExtendedClass;
    }
}