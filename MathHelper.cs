public static class MathHelper
{
    public static double PI = 3.141592654;

    // power(4,3) => 4^3
    // power(radius, 2) => radius^2
    public static double power(double num, int exp)
    {
        if(exp == 1) return num;
        return num * power(num, exp - 1);
    }

}