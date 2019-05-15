using System;
using System.Globalization;

namespace ServiceProgram
{
    public class Class1
    {
      string myString = "wAr aNd pEaCe";//hardcoded value
      TextInfo myTI = new CultureInfo("en-US",false).TextInfo;   
      Console.WriteLine( "\"{0}\" to lowercase: {1}", myString, myTI.ToLower( myString ) );
      Console.WriteLine( "\"{0}\" to uppercase: {1}", myString, myTI.ToUpper( myString ) );
      Console.WriteLine( "\"{0}\" to titlecase: {1}", myString, myTI.ToTitleCase( myString ) );
    }
}