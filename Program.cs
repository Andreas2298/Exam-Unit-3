/* Task 1

Create the following functions

1. A function that returns the square of a number */

public class SquareProgram
{
    static void Main()
    {

        double output = SquareNumber(8.0);
        Console.WriteLine(output);
    }

    double SquareNumber(double number)
    {

        return Math.Pow(number, 2);
    }
}


// 2. A function that returns a length in mm assuming it has been given a length in inches.

public class ConvertProgram
{
    static void Main()
    {
        double output2 = Converting.InchesToMillimeters(inches);

        Console.WriteLine($"{Inches} is the same as {output2} millimeters");
    }

    double Convert(double inches)
    {
        double convertFactor = 25.4;
        return inches * convertFactor;
    }
}


// 3. A function that returns the root of a number

public class RootProgram
{

    static void Main()
    {

        double rootNumber = RootNumber(root);
        Console.WriteLine($"The root number of the number {root} is {rootNumber}");
    }

    public static double RootNumber(double root)

    {
        return Math.Sqrt(root);
    }
}


// 4. A function that returns the cube of a number

public class CubeProgram
{

    static void Main()
    {

        double CubeOutput = Calculating.CubeNumber(7.0);
        Console.WriteLine(CubeOutput);
    }

    double CubeNumber(double cube)
    {
        return Math.Pow(cube, 3);
    }
}


// 5. A function that returns the area of a circle given the radius.

public static double AreaOfCircle(double radius)
{
    double Pi = 3.14;
    return Pi * radius * radius;
}


// 6. A function that returns a greeting, given a name.

public static string Greeting(string name)

{
    return $"Good day, {name}! How are you today?"
}



// Task 2 Flatten those numbers



IntListA = [435, 2028, [[3047, 4910, 8146, 7999, 1433, 7211, 1197, 6002], 2821, 3508]]

IntListB = [[2098, 2403, [1003, [5619, 3021, 7433, [1529, 917]], 5266, 1938, [3535, 8334, 2427, 4818, 751, 5616, 2847, 3895, 8019, 8742, 7236, 6298], 2798, 4795, 342, 2619, 7476, 6541], 1385, 8644, 3866, 691, [9190, [1028, 457, 190, 7351, 826, 7883, 5175, 9385], 8872, 8163, 7460, [4316, 494, 3215, 9573, 8203, 1261, 7265, 5187, 3568, 5232, 4377, 771, 9205], 7723, [3546, 1752], 6979, 7971, 3437, 5354, 7573, 3432, [2489, 8624, 1440, 6216, 5953, 7847, 6735, 7089, 2950, 1086]], 928, 8943, 2735, 8524, [6764, 3435, 6327, 7671, 4769, 9117, 5716, [2630, 1004, 479, 9689, 2099, 163, 8254, 501, 2945], 550, 8623, 1199], 1176, 3888], 5168, [3124, 5208, [8333, 6834, 2720, 2330, 5096], [8146, 885, 8425, 5711, 5859, 2900, 5348], 2654, 4031, 6391, [6383, 7023, 6836, 2097, 5997, 446, 3833, 9256, 8207, [6374, 6438, 7251, 8302, 4419, 2991, 8423, 5260], [1639, 5362, 7085, 7340, 2221], 9070], 1398, 7675, [688, 9415, 4376, [4210, 6328, 4350, 8134, 6161], [1286, 9349, 1031, 5302, 4163, 9465, 9101, 1429, 5743, 2993, 4861, 3002], 8045, [1999], 8835, 3651, 8063, 4110, 9624, 8607], 8001, 304, 7088, 6758], 2574, 2882, 8542, 2504, 8347]


IntList = [0, 1, 2, [4, 5]]


flatlist = []


for (int i = 0; i < IntList.length; i++) #for i verdier mellom 0 og lengden av liste (4)
    
{
    IntList2 = IntList[i]

}

if (IntList2 is int)
{
    flatlist.add(IntList2)

}


else

{
    for (int j = 0; j < IntList2.Count; j++)

    {
        IntList3 = IntList2[j]
    }

}

if (IntList3 is int)
{
    flatlist.add(IntList3)

}

else

{
    for (int k = 0; k < IntList3.Count; k++)

    {
        IntList4 = IntList3[k]
    }

}

if (IntList4 is int)
{
    flatlist.add(IntList4)

}

else

{
    for (int L = 0; L < IntList4.Count; L++)

    {
        IntList5 = IntList4[L]
    }

}

if (IntList5 is int)
{
    flatlist.add(IntList5)

}

else

{
    for (int m = 0; m < IntList5.Count; m++)

    {
        IntList6 = IntList5[m]
    }

}

if (IntList6 is int)
{
    flatlist.add(IntList6)

}

else

{
    for (int n = 0; n < IntList6.Count; n++)

    {
        IntList7 = IntList6[n]
    }

}





