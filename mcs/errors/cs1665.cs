// cs1665.cs: Fixed sized buffer 'S.test20' must have a length greater than zero
// Line: 7
// Compiler options: -unsafe

public unsafe struct S
{
    public fixed bool test20 [-4];
}
